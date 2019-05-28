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
    public partial class BettorForm : Form
    {
        public Bettor NewBettor;

        public BettorForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {                     
            if(nameTextBox.Text != "")
            {
                NewBettor = new Bettor(nameTextBox.Text, 150);

                this.Close();
            }
            else
            {
                MessageBox.Show("Voer eerst een naam in!");
            }
        }
    }
}
