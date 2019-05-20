namespace FifaProject
{
    partial class BetMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.scoreTextBox1 = new System.Windows.Forms.TextBox();
            this.bettorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bettorListTextBox = new System.Windows.Forms.RichTextBox();
            this.newBettorButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.colonLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.euroTextBox = new System.Windows.Forms.TextBox();
            this.cheatPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.euroTextBox);
            this.panel1.Controls.Add(this.euroLabel);
            this.panel1.Controls.Add(this.colonLabel);
            this.panel1.Controls.Add(this.scoreTextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.teamsComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.betButton);
            this.panel1.Controls.Add(this.scoreTextBox1);
            this.panel1.Controls.Add(this.bettorComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bettorListTextBox);
            this.panel1.Controls.Add(this.newBettorButton);
            this.panel1.Location = new System.Drawing.Point(29, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 351);
            this.panel1.TabIndex = 0;
            // 
            // scoreTextBox2
            // 
            this.scoreTextBox2.Location = new System.Drawing.Point(73, 131);
            this.scoreTextBox2.Name = "scoreTextBox2";
            this.scoreTextBox2.Size = new System.Drawing.Size(32, 20);
            this.scoreTextBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Op";
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.FormattingEnabled = true;
            this.teamsComboBox.Location = new System.Drawing.Point(20, 235);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(203, 21);
            this.teamsComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wed";
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.Black;
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.Color.White;
            this.betButton.Location = new System.Drawing.Point(20, 270);
            this.betButton.Margin = new System.Windows.Forms.Padding(30, 20, 60, 20);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(203, 61);
            this.betButton.TabIndex = 7;
            this.betButton.Text = "Gok";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // scoreTextBox1
            // 
            this.scoreTextBox1.Location = new System.Drawing.Point(20, 131);
            this.scoreTextBox1.Name = "scoreTextBox1";
            this.scoreTextBox1.Size = new System.Drawing.Size(32, 20);
            this.scoreTextBox1.TabIndex = 6;
            // 
            // bettorComboBox
            // 
            this.bettorComboBox.FormattingEnabled = true;
            this.bettorComboBox.Location = new System.Drawing.Point(20, 80);
            this.bettorComboBox.Name = "bettorComboBox";
            this.bettorComboBox.Size = new System.Drawing.Size(203, 21);
            this.bettorComboBox.TabIndex = 5;
            this.bettorComboBox.SelectedValueChanged += new System.EventHandler(this.bettorComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lijst van gokkers";
            // 
            // bettorListTextBox
            // 
            this.bettorListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettorListTextBox.Location = new System.Drawing.Point(241, 24);
            this.bettorListTextBox.Name = "bettorListTextBox";
            this.bettorListTextBox.ReadOnly = true;
            this.bettorListTextBox.Size = new System.Drawing.Size(376, 311);
            this.bettorListTextBox.TabIndex = 3;
            this.bettorListTextBox.Text = "";
            // 
            // newBettorButton
            // 
            this.newBettorButton.BackColor = System.Drawing.Color.Black;
            this.newBettorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBettorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBettorButton.ForeColor = System.Drawing.Color.White;
            this.newBettorButton.Location = new System.Drawing.Point(20, 24);
            this.newBettorButton.Margin = new System.Windows.Forms.Padding(30, 20, 60, 20);
            this.newBettorButton.Name = "newBettorButton";
            this.newBettorButton.Size = new System.Drawing.Size(203, 33);
            this.newBettorButton.TabIndex = 2;
            this.newBettorButton.Text = "Maak een gokker aan";
            this.newBettorButton.UseVisualStyleBackColor = false;
            this.newBettorButton.Click += new System.EventHandler(this.newBettorButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(53, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Gok Menu";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(29, 423);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.White;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.Black;
            this.newGameButton.Location = new System.Drawing.Point(576, 423);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(89, 23);
            this.newGameButton.TabIndex = 12;
            this.newGameButton.Text = "Nieuw Spel";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel.Location = new System.Drawing.Point(56, 130);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(13, 20);
            this.colonLabel.TabIndex = 13;
            this.colonLabel.Text = ":";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroLabel.Location = new System.Drawing.Point(16, 164);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(40, 18);
            this.euroLabel.TabIndex = 14;
            this.euroLabel.Text = "Euro";
            // 
            // euroTextBox
            // 
            this.euroTextBox.Location = new System.Drawing.Point(20, 185);
            this.euroTextBox.Name = "euroTextBox";
            this.euroTextBox.Size = new System.Drawing.Size(85, 20);
            this.euroTextBox.TabIndex = 15;
            // 
            // cheatPanel
            // 
            this.cheatPanel.Location = new System.Drawing.Point(615, -1);
            this.cheatPanel.Name = "cheatPanel";
            this.cheatPanel.Size = new System.Drawing.Size(78, 51);
            this.cheatPanel.TabIndex = 13;
            this.cheatPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cheatPanel_MouseDoubleClick);
            // 
            // BetMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.cheatPanel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.Name = "BetMenuForm";
            this.Text = "BetMenuForm";
            this.Load += new System.EventHandler(this.BetMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button newBettorButton;
        private System.Windows.Forms.RichTextBox bettorListTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.TextBox scoreTextBox1;
        private System.Windows.Forms.ComboBox bettorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TextBox scoreTextBox2;
        private System.Windows.Forms.TextBox euroTextBox;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Panel cheatPanel;
    }
}