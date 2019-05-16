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
                    bettorListTextBox.Text += BettorList[i].Name + " | " + BettorList[i].Cash + " Euro" + " | Wed " + BettorList[i].CurrentBet + " Op " + BettorList[i].TeamBetOn + "\n";
                    bettorComboBox.Items.Add(BettorList[i].Name);
                }
            }
            for (int i = 0; i < TeamList.Count; i++)
            {
                teamsComboBox.Items.Add(TeamList[i]);
            }
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
            Initialize();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BettorList.Count; i++)
            {
                if (bettorComboBox.Text == BettorList[i].Name)
                {
                    BettorList[i].CurrentBet = int.Parse(betTextBox.Text);
                    BettorList[i].TeamBetOn = teamsComboBox.Text;
                }
            }
            Initialize();
        }
    }
}
