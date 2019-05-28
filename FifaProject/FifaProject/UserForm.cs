using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FifaProject
{
    public partial class UserForm : Form
    {
        public Bettor bettor;
        public string saveLocation;
        public List<Bettor> bettorList;

        public UserForm()
        {
            InitializeComponent();
        }

        private void bettorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bettorName = bettorComboBox.Text;

            // Checks which bettor has been chosen.
            foreach (Bettor b in bettorList)
            {
                if (b.Name == bettorName)
                {
                    bettor = b;

                    this.Close(); // Closes this form
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            getSaveGame(saveLocation);
            initialize();
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
                    bettorList = JsonConvert.DeserializeObject<List<Bettor>>(saveJson);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                bettorList = new List<Bettor>();
            }
        }

        /// <summary>
        /// Initializes the bettorComboBox
        /// </summary>
        public void initialize()
        {
            bettorComboBox.Items.Clear();
            
            if (bettorList.Count > 0)
            {
                for (int i = 0; i < bettorList.Count; i++)
                {
                    bettorComboBox.Items.Add(bettorList[i].Name);
                }
            }
        }

        private void newBettorButton_Click(object sender, EventArgs e)
        {
            BettorForm bettorForm = new BettorForm();
            bettorForm.ShowDialog();
            bettor = bettorForm.NewBettor;
            bettorList.Add(bettor);

            this.Close();
        }
    }
}
