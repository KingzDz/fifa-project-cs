using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;

namespace FifaProject
{
    public partial class MainForm : Form
    {
        string json;
        string fullSchedule;

        List<Label> labels;
        List<FetchTeam.Record> team;
        FetchSchedule fetchedSchedule;

        decimal balance = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // When user clicks this button the teams must refresh
            //initializeTeams();
            
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sybrandbos.nl/website/");
        }

        /*public async Task fetchTeams()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string url = "https://sybrandbos.nl/website/API/read.php";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    json = await response.Content.ReadAsStringAsync();
                }
                catch
                {
                    // iets ging mis
                    MessageBox.Show("Iets ging mis");
                }
            }
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var iets = fetchTeams();

            //iets.Wait();
            currentBalenceLabel.Text = $"€{balance.ToString()}";
            initializeTeams();

            System.Net.WebClient client = new System.Net.WebClient();
            string read = client.DownloadString("http://sybrandbos.nl/website/API/schedules.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
            fetchedSchedule = JsonConvert.DeserializeObject<FetchSchedule>(read);
        }

        public void initializeTeams()
        {
            json = new System.Net.WebClient().DownloadString("http://sybrandbos.nl/website/API/read.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");

            FetchTeam.RootObject fetchedTeams = JsonConvert.DeserializeObject<FetchTeam.RootObject>(json);

            // gets all labels from teamPanel
            var labelsVar = teamPanel.Controls.OfType<Label>();

            // convert all teamLabels to a list
            labels = new List<Label>();
            foreach (Label label in labelsVar)
            {
                if (!label.Text.Contains(":"))
                {
                    labels.Add(label);
                }
            }

            bool isLeftSide = true;
            int locationY = teamLabel1.Location.Y;
            int locationTextBoxY = scoreTeam1.Location.Y;
            int j = 0;

            team = fetchedTeams.records;
            for (int k = 0; k < team.Count(); k++)
            {
                for (; j < labels.Count(); j++, k++)
                {
                    labels[j].Text = team[k].TeamName;
                }

                if (isLeftSide)
                {
                    Label teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = team[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(6, locationY += 30);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    // adding score section
                    TextBox scoreTeam = new TextBox();
                    scoreTeam.Size = new System.Drawing.Size(31, 24);
                    scoreTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam.Location = new System.Drawing.Point(111, locationTextBoxY += 30);
                    teamPanel.Controls.Add(scoreTeam);

                    TextBox scoreTeam2 = new TextBox();
                    scoreTeam2.Size = new System.Drawing.Size(31, 24);
                    scoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam2.Location = new System.Drawing.Point(166, locationTextBoxY);
                    teamPanel.Controls.Add(scoreTeam2);

                    Label colonLabel = new Label();
                    colonLabel.AutoSize = true;
                    colonLabel.Text = ":";
                    colonLabel.Location = new System.Drawing.Point(148, locationY);
                    colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(colonLabel);


                    isLeftSide = false;
                }
                else
                {
                    Label teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = team[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(213, locationY);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    isLeftSide = true;
                }
            }
        }

        private void betMenuButton_Click(object sender, EventArgs e)
        {
            BetMenuForm betForm = new BetMenuForm();
            List<string> TeamList = new List<string>();
            for (int i = 0; i < team.Count; i++)
            {
                TeamList.Add(team[i].TeamName);
            }
            betForm.TeamList = TeamList;
            betForm.Schedule = fetchedSchedule.matches;
            betForm.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                fullSchedule = "";

                for (int i = 0; i < fetchedSchedule.matches.Count; i++)
                {
                    fullSchedule += fetchedSchedule.matches[i] + "\n";
                }

                MessageBox.Show(fullSchedule);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een fout opgetreden. Er kon geen verbinding worden gemaakt met de website!");
            }
            
        }

    }
}
