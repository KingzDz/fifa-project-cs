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
        public string Format = "{0} wed {1} euro op {2} met {3} als eindstand. | {4} euro \n";

        public string SaveLocation = "fifa-save.json";

        int MatchId = 0;
        int BetId = 0;

        public BetMenuForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            // Leeg eerst de comboboxes
            bettorComboBox.Items.Clear();
            teamsComboBox.Items.Clear();
            matchComboBox.Items.Clear();

            // Als er Bettors zijn stop ze dan in de bettorComboBox
            if (BettorList.Count > 0)
            {
                for (int i = 0; i < BettorList.Count; i++)
                {
                    bettorComboBox.Items.Add(BettorList[i].Name);
                }
            }
            // Stop de teams uit deze ronde in teamsComboBox
            teamsComboBox.Items.Add(TeamOne);
            teamsComboBox.Items.Add(TeamTwo);

            // Stop een lijst van matches in matchComboBox    
            
            if (Schedule.Count > 0)
            {
                for (int i = 0; i < Schedule.Count; i++)
                {
                    matchComboBox.Items.Add(Schedule[i]);
                }
            }
        }

        private void FindTeams()
        {
            // Kijkt welke twee teams tegen elkaar moeten spelen
            // MatchId is de id van de ronde
            string[] teams = Schedule[MatchId].Split('-');
            TeamOne = teams[0].Trim();
            TeamTwo = teams[1].Trim();
        }

        private void FetchScores()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string read = client.DownloadString("http://sybrandbos.nl/website/API/results.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
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
                NewBettor.MatchesBetOn = new List<Bettor.Matches>();
            }
            
            Initialize();
        }

        private void BetMenuForm_Load(object sender, EventArgs e)
        {
            // Haal de save informatie op
            string saveJson = "";
            try
            {
                 saveJson = File.ReadAllText(SaveLocation);
            }
            catch (System.IO.FileNotFoundException)
            {

            }

            // Kijk of er een savegame is. Zo niet, maak een nieuwe aan.
            if(saveJson != "")
            {
                BettorList = JsonConvert.DeserializeObject<List<Bettor>>(saveJson);
            }
            else
            {
                BettorList = new List<Bettor>();
            }
            matchComboBox.SelectedItem = MatchId;

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

            try
            {
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

            //activeBettor.Score = $"{scoreTeam1}-{scoreTeam2}";
            
            if(euroTextBox.Text.All(char.IsDigit) == true)
            {
                //activeBettor.CurrentBet = int.Parse(euroTextBox.Text);
                string listMessage = string.Format(Format, activeBettor.Name, int.Parse(euroTextBox.Text), teamsComboBox.Text, $"{scoreTeam1}-{scoreTeam2}", activeBettor.Cash);
                activeBettor.SetBet(Schedule[MatchId], int.Parse(euroTextBox.Text), teamsComboBox.Text, $"{scoreTeam1}-{scoreTeam2}", listMessage);
                bettorListTextBox.Text += listMessage;

            }
            catch (System.FormatException)
            {
                
            }
          }
            

            //activeBettor.TeamBetOn = teamsComboBox.Text;

            // Shows bet in bettorListTextBox
            
            

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

        private void matchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatchId = matchComboBox.SelectedIndex;
            bettorListTextBox.Text = "";

            // wanneer je de match verandert kijkt dit of een gokker al een weddenschap op die match heeft geplaats
            for (int i = 0; i < BettorList.Count; i++)
            {
                for (int o = 0; o < BettorList[i].MatchesBetOn.Count; o++)
                {
                    if (BettorList[i].MatchesBetOn[o].MatchName == Schedule[MatchId])
                    {
                        bettorListTextBox.Text += BettorList[i].MatchesBetOn[o].ListMessage;
                    }
                    
                }               
            }
            FindTeams();
            Initialize();
        }
    }
}
