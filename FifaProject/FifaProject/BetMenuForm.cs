using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FifaProject
{
    public partial class BetMenuForm : Form
    {
        List<Bettor> BettorList;
        FetchScores fetchedScores;
        public List<string> TeamList;
        public List<string> Schedule;
        public string TeamOne;
        public string TeamTwo;
        public Bettor activeBettor;

        public string SaveLocation = "fifa-save.json";

        int MatchId = 0;

        public BetMenuForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            bettorComboBox.Items.Clear();
            teamsComboBox.Items.Clear();

            if (BettorList.Count > 0)
            {
                for (int i = 0; i < BettorList.Count; i++)
                {
                    bettorComboBox.Items.Add(BettorList[i].Name);
                }
            }
            teamsComboBox.Items.Add(TeamOne);
            teamsComboBox.Items.Add(TeamTwo);
        }

        private void FindTeams()
        {
            string[] teams = Schedule[MatchId].Split('-');
            TeamOne = teams[0].Trim();
            TeamTwo = teams[1].Trim();
        }

        private void FetchScores()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string read = client.DownloadString("http://localhost/website/API/results.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
            // ik heb echt geen idee hoe ik dit moet laten werken
            //fetchedScores = JsonConvert.DeserializeObject<FetchScores>(read);

        }

        private void newBettorButton_Click(object sender, EventArgs e)
        {           
            BettorForm form = new BettorForm();
            form.BettorList = BettorList;
            form.ShowDialog();
            Bettor NewBettor = form.NewBettor;
            if (NewBettor != null)
            {
                BettorList.Add(NewBettor);
            }
            
            Initialize();
        }

        private void BetMenuForm_Load(object sender, EventArgs e)
        {
            string saveJson = "";
            try
            {
                 saveJson = File.ReadAllText(SaveLocation);
            }
            catch (System.IO.FileNotFoundException)
            {

            }

            if(saveJson != "")
            {
                BettorList = JsonConvert.DeserializeObject<List<Bettor>>(saveJson);
            }
            else
            {
                BettorList = new List<Bettor>();
            }

            FindTeams();
            Initialize();
            FetchScores();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            string scoreTeam1 = "";
            string scoreTeam2 = "";

            if (String.IsNullOrEmpty(scoreTextBox1.Text) || String.IsNullOrEmpty(scoreTextBox2.Text))
            {
                MessageBox.Show("Sorry, score mag niet leeg zijn");
            }

            if (scoreTextBox1.Text.All(char.IsDigit) == true && scoreTextBox2.Text.All(char.IsDigit) == true)
            {
                scoreTeam1 = scoreTextBox1.Text;
                scoreTeam2 = scoreTextBox2.Text;
            }

            
            int cash = int.Parse(euroTextBox.Text);
            string winningTeam = teamsComboBox.Text;

            // When bettor doesn't have enough cash for the bet
            if (activeBettor.Cash < cash)
            {
                MessageBox.Show("Sorry, u heeft niet genoeg geld voor deze gok.");
                return;
            }

            activeBettor.Score = $"{scoreTeam1}-{scoreTeam2}";
            
            if(euroTextBox.Text.All(char.IsDigit) == true)
            {
                activeBettor.CurrentBet = int.Parse(euroTextBox.Text);
            }
            else
            {
                MessageBox.Show("Geef alleen cijfers mee.");
            }

            activeBettor.TeamBetOn = teamsComboBox.Text;

            // Shows bet in bettorListTextBox
            bettorListTextBox.Text += activeBettor.Name + " wed " + activeBettor.CurrentBet + " euro op " + activeBettor.TeamBetOn + " | Stand: " + activeBettor.Score + "\n";

            // Resets textboxes
            bettorComboBox.Text = "";
            scoreTextBox1.Text = "";
            scoreTextBox2.Text = "";
            teamsComboBox.Text = "";
            euroTextBox.Text = "";
            Initialize();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string SaveData = JsonConvert.SerializeObject(BettorList);
            File.WriteAllText(SaveLocation, SaveData);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SaveLocation, "");
            bettorListTextBox.Text = "";
            BettorList = new List<Bettor>();
        }

        private void bettorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string bettorName = bettorComboBox.Text;

            for (int i = 0; i < BettorList.Count; i++)
            {
                if (bettorName == BettorList[i].Name)
                {
                    activeBettor = BettorList[i];

                    return;
                }
            }
        }

        private void cheatPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Secret cheat code gives user +500 cash
            string cheatCode = "";

            CheatForm cheatForm = new CheatForm();
            cheatForm.ShowDialog();
            cheatCode = cheatForm.Cheat;
            if (cheatCode == "make it rain")
            {
                if (activeBettor != null)
                {
                    activeBettor.Cash += 500;
                }
            }
        }
    }
}
