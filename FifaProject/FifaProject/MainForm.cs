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
        string jsonTeams;

        public MainForm()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // When user clicks this button the teams must refresh
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sybrandbos.nl/website/");
        }

        public async Task<string> fetchTeams()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string url = "https://sybrandbos.nl/website/API/read.php";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    jsonTeams = await response.Content.ReadAsStringAsync();
                    return jsonTeams;
                }
                catch
                {
                    // iets ging mis 
                    return "";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string json = await fetchTeams();
            string json = new System.Net.WebClient().DownloadString("https://sybrandbos.nl/website/API/read.php");

            FetchTeam.RootObject fetchedTeams = JsonConvert.DeserializeObject<FetchTeam.RootObject>(json);

            //List<FetchTeam.Record> teams = new List<FetchTeam.Record>();
            
            // gets all labels from teamPanel
            var labelsVar = teamPanel.Controls.OfType<Label>();
            // convert labels to list
            List<Label> labels = new List<Label>();
            foreach (Label label in labelsVar)
            {
                labels.Add(label);
            }

            int j = 0;
            //foreach (FetchTeam.Record team in fetchedTeams.records)
            List<FetchTeam.Record> team = fetchedTeams.records;
            for (int k = 0; k < team.Count(); k++)
            {
                //foreach (Label label in labels)
                for (; j < labels.Count(); j++, k++)
                {
                    // put all labels in an array
                    if (!labels[j].Text.Contains(":"))
                    {
                        labels[j].Text = team[k].TeamName;
                    }
                }

                //teams.Add(team[k]);
                
                // get label from array

                Label teamLabel = new Label();
                teamLabel.Text = team[k].TeamName;
                teamLabel.Location = new System.Drawing.Point(16, 64);
                teamLabel.AutoSize = true;
                this.Controls.Add(teamLabel);
            }
            
            for (int i = 0; i < fetchedTeams.records.Count; i++)
            {
                //teamLabel1.Text = teams[i];
            }
        }
    }
}
