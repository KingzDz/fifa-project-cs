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
        string read;

        string TeamOne, TeamTwo;
        int FirstScore, SecondScore;

        List<Label> labels;
        List<FetchTeam.Record> team;
        FetchSchedule fetchedSchedule;
        FetchScores.RootObject fetchedScore;

        decimal balance = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            initializeTeams();
            
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
            initializeTeams();

            System.Net.WebClient client = new System.Net.WebClient();
            read = client.DownloadString("http://sybrandbos.nl/website/API/schedules.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
            fetchedSchedule = JsonConvert.DeserializeObject<FetchSchedule>(read);
            for (int i = 0; i < fetchedSchedule.matches.Count; i++)
            {
                matchComboBox.Items.Add(fetchedSchedule.matches[i]);
            }
           
            
        }

        public void initializeTeams()
        {
            json = new System.Net.WebClient().DownloadString("http://sybrandbos.nl/website/API/results.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");

            fetchedScore = JsonConvert.DeserializeObject<FetchScores.RootObject>(json);

            teamsLabel.Text = matchComboBox.Text;
            matchLabel.Text = "De stand is nog niet bekend.";
            for (int i = 0; i < fetchedScore.Records.Count; i++)
            {
                string format = "{0} - {1}";
                string match = string.Format(format, fetchedScore.Records[i].firstteam, fetchedScore.Records[i].secondteam);
                if (match == matchComboBox.Text)
                {
                    matchLabel.Text = string.Format(format, fetchedScore.Records[i].firstscore, fetchedScore.Records[i].secondscore); ;
                }
                
            }

        }

        private void matchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            initializeTeams();
        }

        private void betMenuButton_Click(object sender, EventArgs e)
        {
            BetMenuForm betForm = new BetMenuForm();
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
