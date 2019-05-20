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
    public partial class CheatForm : Form
    {
        public string Cheat;

        public CheatForm()
        {
            InitializeComponent();
        }

        private void cheatButton_Click(object sender, EventArgs e)
        {
            Cheat = cheatTextBox.Text;
            this.Close();
        }
    }
}
