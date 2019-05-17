using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaProject
{
    public partial class BetMenuForm : Form
    {
        List<Bettor> BettorList;
        public List<string> TeamList;
        public List<string> Schedule;
        public string TeamOne;
        public string TeamTwo;

        int MatchId = 0;

        public BetMenuForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            bettorListTextBox.Text = "";
            bettorComboBox.Items.Clear();
            teamsComboBox.Items.Clear();

            if (BettorList.Count > 0)
            {
                for (int i = 0; i < BettorList.Count; i++)
                {
                    bettorListTextBox.Text += BettorList[i].Name + " wed " + BettorList[i].CurrentBet + " euro op " + BettorList[i].TeamBetOn + " | " + BettorList[i].Cash + " Euro" + "\n";
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

        private void newBettorButton_Click(object sender, EventArgs e)
        {           
            BettorForm form = new BettorForm();
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
            BettorList = new List<Bettor>();
            FindTeams();
            Initialize();
            
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BettorList.Count; i++)
            {
                if (bettorComboBox.Text == BettorList[i].Name)
                {
                    if(betTextBox.Text.All(char.IsDigit) == true)
                    {
                        BettorList[i].CurrentBet = int.Parse(betTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Geef alleen cijfers mee.");
                    }
                    BettorList[i].TeamBetOn = teamsComboBox.Text;
                }
            }
            Initialize();
        }
    }
}
