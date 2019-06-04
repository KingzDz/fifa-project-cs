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
        FetchScores.RootObject fetchedScores;
        public List<string> TeamList;
        public List<string> Schedule;
        public string TeamOne;
        public string TeamTwo;
        public Bettor activeBettor;
        public string Format = "{0} wed {1} euro dat {2} wint met {3} als eindstand. | {4} euro \n";
        string listMessage;

        public string SaveLocation = "fifa-save.json";

        int MatchId = 0;

        public BetMenuForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            // Leeg eerst de comboboxes
            matchComboBox.Items.Clear();

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
            string json = client.DownloadString("http://sybrandbos.nl/website/API/results.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
            fetchedScores = JsonConvert.DeserializeObject<FetchScores.RootObject>(json);
        }

        private void BetMenuForm_Load(object sender, EventArgs e)
        {
            getSaveGame(SaveLocation);

            matchComboBox.SelectedItem = MatchId;

            selectBettor(); // Chooses which bettor is active
            
            FindTeams();
            Initialize();

            // Sets the labels
            balanceLabel.Text = $"€{activeBettor.Cash},-";
            titleLabel.Text += $"   Gokker: {activeBettor.Name}";
            teamOneLabel.Text = TeamOne;
            teamTwoLabel.Text = TeamTwo;
        }

        /// <summary>
        /// Gets the JSON file, from the save location, and converts it to a class.
        /// </summary>
        /// <param name="saveLocation"></param>
        public void getSaveGame(string saveLocation)
        {
            string saveJson = "";

            try
            {
                saveJson = File.ReadAllText(saveLocation);

                if (saveJson != "")
                {
                    BettorList = JsonConvert.DeserializeObject<List<Bettor>>(saveJson);
                }
                else
                {
                    BettorList = new List<Bettor>();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                BettorList = new List<Bettor>();
            }
        }

        /// <summary>
        /// Opens a form where a bettor must been chosen, otherwise this form closes.
        /// </summary>
        public void selectBettor()
        {
            UserForm userForm = new UserForm();
            userForm.saveLocation = SaveLocation;
            userForm.bettorList = BettorList;
            userForm.ShowDialog();
            activeBettor = userForm.bettor;
            BettorList = userForm.bettorList;

            if (activeBettor == null)
            {
                this.Close();
                return;
            }
        }

        /// <summary>
        /// Checks if there are scores available for the competition.
        /// </summary>
        public void fetchCompetitionScores()
        {
            FetchScores(); // Fetches the scores from the API

            if (fetchedScores.Records[0] != null && activeBettor.MatchesBetOn.Any() == true) // When there are scores available
            {
                string message = "Er zijn nieuwe scores beschikbaar. Kijk op je gewonnen hebt!";
                string title = "Scores beschikbaar.";
                MessageBox.Show(message, title);
                
                int i = 0;
                foreach (Bettor.Matches match in activeBettor.MatchesBetOn)
                {

                    foreach (FetchScores.Record record in fetchedScores.Records)
                    {

                        if ($"{record.firstteam} - {record.secondteam}" == match.MatchName) // When the match is available
                        {

                            if ($"{record.firstscore}-{record.secondscore}" == match.Score) // When the score is correct
                            {
                                int moneyWon = match.CurrentBet * 3;

                                activeBettor.Cash += moneyWon;

                                message = $"Gefeliciteerd! Uw heeft {moneyWon} gewonnen op de wedstrijd {match.MatchName}.";
                                title = "Gewonnen!";
                                MessageBox.Show(message, title);

                                match.ResetValues();
                            }
                            else if ($"{record.firstscore}-{record.secondscore}" != match.Score) // When the score is not correct
                            {
                                string[] scores = match.Score.Split('-'); // Splits match scores to array

                                if (record.firstscore > record.secondscore)
                                {

                                    if (int.Parse(scores[0]) > int.Parse(scores[1]))
                                    {
                                        int moneyWon = match.CurrentBet * 2;

                                        activeBettor.Cash += moneyWon;

                                        message = $"Gefeliciteerd! Uw heeft {moneyWon} gewonnen op de wedstrijd {match.MatchName}.";
                                        title = "Gewonnen!";
                                        MessageBox.Show(message, title);

                                        match.ResetValues();
                                    }
                                }
                                else if (record.firstscore < record.secondscore)
                                {

                                    if (int.Parse(scores[0]) < int.Parse(scores[1]))
                                    {
                                        int moneyWon = match.CurrentBet * 2;

                                        activeBettor.Cash += moneyWon;

                                        message = $"Gefeliciteerd! Uw heeft {moneyWon} gewonnen op de wedstrijd {match.MatchName}.";
                                        title = "Gewonnen!";
                                        MessageBox.Show(message, title);

                                        match.ResetValues();
                                    }
                                }
                                else
                                {
                                    message = $"Volgende keer beter! Uw heeft {match.CurrentBet} verloren op de wedstrijd {match.MatchName}.";
                                    title = "Jammer!";
                                    MessageBox.Show(message, title);

                                    match.ResetValues();
                                }
                            }
                        }
                    }

                    i++;
                }

                // Deletes all the empty bets from the list
                activeBettor.MatchesBetOn.RemoveAll(r => r.MatchName == null);
            }

            savingGame(SaveLocation);
            balanceLabel.Text = $"€{activeBettor.Cash},-"; // Update balance label
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            string scoreTeam1 = "";
            string scoreTeam2 = "";

            if (String.IsNullOrEmpty(scoreTextBox1.Text) || String.IsNullOrEmpty(scoreTextBox2.Text) || String.IsNullOrEmpty(euroTextBox.Text))
            {
                MessageBox.Show("Vul eerst het formulier in!");

            }
            else if (!scoreTextBox1.Text.All(char.IsDigit) || !scoreTextBox2.Text.All(char.IsDigit) || !euroTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Geef alleen cijfers mee!");
            }
            else
            {
                scoreTeam1 = scoreTextBox1.Text;
                scoreTeam2 = scoreTextBox2.Text;

                int cash = int.Parse(euroTextBox.Text);       

                // When bettor has not enough cash for the bet.
                if (activeBettor.Cash - cash < 0)
                {
                    MessageBox.Show("Sorry, u heeft niet genoeg geld voor deze gok.");
                    return;
                }
                else
                {
                    activeBettor.Cash -= cash;
                }

                // Set bet and bet message
                
                if (int.Parse(scoreTeam1) > int.Parse(scoreTeam2))
                {
                    listMessage = string.Format(Format, activeBettor.Name, int.Parse(euroTextBox.Text),
                    TeamOne, $"{scoreTeam1}-{scoreTeam2}", activeBettor.Cash);

                    activeBettor.SetBet(Schedule[MatchId], int.Parse(euroTextBox.Text), TeamOne, $"{scoreTeam1}-{scoreTeam2}", listMessage);
                }
                else if(int.Parse(scoreTeam1) < int.Parse(scoreTeam2))
                {
                    listMessage = string.Format(Format, activeBettor.Name, int.Parse(euroTextBox.Text),
                    TeamTwo, $"{scoreTeam1}-{scoreTeam2}", activeBettor.Cash);

                    activeBettor.SetBet(Schedule[MatchId], int.Parse(euroTextBox.Text), TeamTwo, $"{scoreTeam1}-{scoreTeam2}", listMessage);
                }
                else
                {
                    Format = "{0} wed {1} euro op een gelijk spel met {2} als eindstand. | {3} euro \n";

                    listMessage = string.Format(Format, activeBettor.Name, int.Parse(euroTextBox.Text),
                    $"{scoreTeam1}-{scoreTeam2}", activeBettor.Cash);

                    activeBettor.SetBet(Schedule[MatchId], int.Parse(euroTextBox.Text), "Gelijkspel", $"{scoreTeam1}-{scoreTeam2}", listMessage);

                }

                bettorListTextBox.Text += listMessage;

                // Resets textboxes
                scoreTextBox1.Text = "";
                scoreTextBox2.Text = "";
                euroTextBox.Text = "";

                Initialize();
            }

            savingGame(SaveLocation);
            balanceLabel.Text = $"€{activeBettor.Cash},-"; // Update balance label
        }

        public void savingGame(string saveLocation)
        {
            string saveData = JsonConvert.SerializeObject(BettorList);
            File.WriteAllText(saveLocation, saveData);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SaveLocation, "");
            bettorListTextBox.Text = "";
            scoreTextBox1.Text = "";
            scoreTextBox2.Text = "";
            euroTextBox.Text = "";
            BettorList = new List<Bettor>();
            
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

            savingGame(SaveLocation);
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
            teamOneLabel.Text = TeamOne;
            teamTwoLabel.Text = TeamTwo;
            Initialize();
        }

        private void BetMenuForm_Shown(object sender, EventArgs e)
        {
            fetchCompetitionScores();
        }

        private void switchBettorButton_Click(object sender, EventArgs e)
        {
            savingGame(SaveLocation);

            this.Close();
            BetMenuForm betForm = new BetMenuForm();
            betForm.Schedule = Schedule;
            betForm.Show();

        }
    }
}
