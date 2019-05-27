﻿using System;
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
            string json = client.DownloadString("http://sybrandbos.nl/website/API/results.php?key=J93hdb4Ua83AkVWo0cbxIsn2ibw3nlxX3");
            fetchedScores = JsonConvert.DeserializeObject<FetchScores>(json);
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
            if (saveJson != "")
            {
                BettorList = JsonConvert.DeserializeObject<List<Bettor>>(saveJson);
            }
            else
            {
                BettorList = new List<Bettor>();
            }
            matchComboBox.SelectedItem = MatchId;

            fetchCompetitionScores();
            FindTeams();
            Initialize();
            FetchScores();
        }

        /// <summary>
        /// Checks if there are scores available for the competition.
        /// </summary>
        public void fetchCompetitionScores()
        {
            // CODE SCHRIJVEN ALS JE SCORES KAN INVULLEN BIJ PHP

            string[] playedMatch = new string[5] { "1", "Manchester", "2", "NAC", "3" };
            FetchScores();

            if (fetchedScores == null ) // When there are scores available
            {
                string message = "Er zijn nieuwe scores beschikbaar. Kijk op je gewonnen hebt!";
                string title = "Scores beschikbaar.";
                MessageBox.Show(message, title);

                foreach (Bettor bettor in BettorList)
                {
                    int i = 0;
                    foreach (Bettor.Matches match in bettor.MatchesBetOn)
                    {
                        if (match.MatchName == $"{playedMatch[1]} - {playedMatch[3]}")
                        {
                            //string currentMatch = "Manchester - NAC"; // This must happen dynamic from the API
                            //string score = "2-3"; // voorbeeld

                            if ($"{playedMatch[2]}-{playedMatch[4]}" == match.Score) // if score == usersBet
                            {
                                int moneyWon = match.CurrentBet * 2;

                                bettor.Cash += moneyWon;

                                match.ResetValues();

                                message = $"Gefeliciteerd! Uw heeft {moneyWon} gewonnen op de wedstrijd {match.MatchName}.";
                                title = "Gewonnen!";
                                MessageBox.Show(message, title);
                            }
                            else if (false) // When score is not available yet
                            {

                            }
                            else
                            {
                                match.ResetValues();

                                message = $"Volgende keer beter! Uw heeft {match.CurrentBet} verloren op de wedstrijd {match.MatchName}.";
                                title = "Jammer!";
                                MessageBox.Show(message, title);
                            }
                        }

                        i++;
                    }

                    // Deletes all the empty bets from the list
                    bettor.MatchesBetOn.RemoveAll(r => r.MatchName == null);
                }
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            string scoreTeam1 = "";
            string scoreTeam2 = "";

            if (String.IsNullOrEmpty(scoreTextBox1.Text) || String.IsNullOrEmpty(scoreTextBox2.Text) || String.IsNullOrEmpty(bettorComboBox.Text) || String.IsNullOrEmpty(euroTextBox.Text) || String.IsNullOrEmpty(teamsComboBox.Text))
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
                string winningTeam = teamsComboBox.Text;

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
                string listMessage = string.Format(Format, activeBettor.Name, int.Parse(euroTextBox.Text), teamsComboBox.Text, $"{scoreTeam1}-{scoreTeam2}", activeBettor.Cash);
                activeBettor.SetBet(Schedule[MatchId], int.Parse(euroTextBox.Text), teamsComboBox.Text, $"{scoreTeam1}-{scoreTeam2}", listMessage);
                bettorListTextBox.Text += listMessage;

                // Resets textboxes
                bettorComboBox.Text = "";
                scoreTextBox1.Text = "";
                scoreTextBox2.Text = "";
                teamsComboBox.Text = "";
                euroTextBox.Text = "";
                Initialize();
            }
                   
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
            bettorComboBox.Text = "";
            scoreTextBox1.Text = "";
            scoreTextBox2.Text = "";
            teamsComboBox.Text = "";
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

        private void bettorComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

    }
}
