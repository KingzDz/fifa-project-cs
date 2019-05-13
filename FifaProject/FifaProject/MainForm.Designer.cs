namespace FifaProject
{
    partial class MainForm
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
            this.matchsTitleLabel = new System.Windows.Forms.Label();
            this.betPanel = new System.Windows.Forms.Panel();
            this.teamPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teamLabel2 = new System.Windows.Forms.Label();
            this.teamLabel1 = new System.Windows.Forms.Label();
            this.scoreTeam1 = new System.Windows.Forms.TextBox();
            this.colon1 = new System.Windows.Forms.Label();
            this.scoreTeam2 = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.currentBalenceLabel = new System.Windows.Forms.Label();
            this.currentBalenceTitleLabel = new System.Windows.Forms.Label();
            this.matchesPanel = new System.Windows.Forms.Panel();
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.newBettorButton = new System.Windows.Forms.Button();
            this.betPanel.SuspendLayout();
            this.teamPanel.SuspendLayout();
            this.matchesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchsTitleLabel
            // 
            this.matchsTitleLabel.AutoSize = true;
            this.matchsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchsTitleLabel.Location = new System.Drawing.Point(134, 36);
            this.matchsTitleLabel.Name = "matchsTitleLabel";
            this.matchsTitleLabel.Size = new System.Drawing.Size(138, 26);
            this.matchsTitleLabel.TabIndex = 0;
            this.matchsTitleLabel.Text = "Wedstrijden";
            // 
            // betPanel
            // 
            this.betPanel.BackColor = System.Drawing.Color.White;
            this.betPanel.Controls.Add(this.newBettorButton);
            this.betPanel.Controls.Add(this.teamPanel);
            this.betPanel.Controls.Add(this.refreshButton);
            this.betPanel.Controls.Add(this.betButton);
            this.betPanel.Controls.Add(this.currentBalenceLabel);
            this.betPanel.Controls.Add(this.currentBalenceTitleLabel);
            this.betPanel.Location = new System.Drawing.Point(59, 85);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(338, 321);
            this.betPanel.TabIndex = 2;
            // 
            // teamPanel
            // 
            this.teamPanel.Controls.Add(this.textBox1);
            this.teamPanel.Controls.Add(this.teamLabel2);
            this.teamPanel.Controls.Add(this.teamLabel1);
            this.teamPanel.Controls.Add(this.scoreTeam1);
            this.teamPanel.Controls.Add(this.colon1);
            this.teamPanel.Controls.Add(this.scoreTeam2);
            this.teamPanel.Location = new System.Drawing.Point(13, 41);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(311, 230);
            this.teamPanel.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(111, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 24);
            this.textBox1.TabIndex = 11;
            // 
            // teamLabel2
            // 
            this.teamLabel2.AutoSize = true;
            this.teamLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel2.Location = new System.Drawing.Point(213, 10);
            this.teamLabel2.Name = "teamLabel2";
            this.teamLabel2.Size = new System.Drawing.Size(86, 18);
            this.teamLabel2.TabIndex = 2;
            this.teamLabel2.Text = "Team Twee";
            // 
            // teamLabel1
            // 
            this.teamLabel1.AutoSize = true;
            this.teamLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel1.Location = new System.Drawing.Point(6, 10);
            this.teamLabel1.Name = "teamLabel1";
            this.teamLabel1.Size = new System.Drawing.Size(76, 18);
            this.teamLabel1.TabIndex = 1;
            this.teamLabel1.Text = "Team Eén";
            // 
            // scoreTeam1
            // 
            this.scoreTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTeam1.Location = new System.Drawing.Point(111, 7);
            this.scoreTeam1.Name = "scoreTeam1";
            this.scoreTeam1.Size = new System.Drawing.Size(31, 24);
            this.scoreTeam1.TabIndex = 7;
            // 
            // colon1
            // 
            this.colon1.AutoSize = true;
            this.colon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon1.Location = new System.Drawing.Point(148, 10);
            this.colon1.Name = "colon1";
            this.colon1.Size = new System.Drawing.Size(12, 18);
            this.colon1.TabIndex = 9;
            this.colon1.Text = ":";
            // 
            // scoreTeam2
            // 
            this.scoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTeam2.Location = new System.Drawing.Point(166, 7);
            this.scoreTeam2.Name = "scoreTeam2";
            this.scoreTeam2.Size = new System.Drawing.Size(31, 24);
            this.scoreTeam2.TabIndex = 8;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(249, 15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Ververs";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.Black;
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.Color.White;
            this.betButton.Location = new System.Drawing.Point(13, 277);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(94, 28);
            this.betButton.TabIndex = 10;
            this.betButton.Text = "Wed";
            this.betButton.UseVisualStyleBackColor = false;
            // 
            // currentBalenceLabel
            // 
            this.currentBalenceLabel.AutoSize = true;
            this.currentBalenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalenceLabel.Location = new System.Drawing.Point(152, 14);
            this.currentBalenceLabel.Name = "currentBalenceLabel";
            this.currentBalenceLabel.Size = new System.Drawing.Size(61, 24);
            this.currentBalenceLabel.TabIndex = 4;
            this.currentBalenceLabel.Text = "€150,-";
            // 
            // currentBalenceTitleLabel
            // 
            this.currentBalenceTitleLabel.AutoSize = true;
            this.currentBalenceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalenceTitleLabel.Location = new System.Drawing.Point(15, 14);
            this.currentBalenceTitleLabel.Name = "currentBalenceTitleLabel";
            this.currentBalenceTitleLabel.Size = new System.Drawing.Size(131, 24);
            this.currentBalenceTitleLabel.TabIndex = 3;
            this.currentBalenceTitleLabel.Text = "Huidige saldo:";
            // 
            // matchesPanel
            // 
            this.matchesPanel.BackColor = System.Drawing.Color.Silver;
            this.matchesPanel.Controls.Add(this.websiteLinkLabel);
            this.matchesPanel.Controls.Add(this.betPanel);
            this.matchesPanel.Controls.Add(this.matchsTitleLabel);
            this.matchesPanel.Location = new System.Drawing.Point(0, 0);
            this.matchesPanel.Name = "matchesPanel";
            this.matchesPanel.Size = new System.Drawing.Size(455, 450);
            this.matchesPanel.TabIndex = 3;
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(56, 419);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(282, 13);
            this.websiteLinkLabel.TabIndex = 11;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "Schema\'s bekijken, team\'s aanmaken? Check de website!";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
            // 
            // newBettorButton
            // 
            this.newBettorButton.BackColor = System.Drawing.Color.Black;
            this.newBettorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBettorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBettorButton.ForeColor = System.Drawing.Color.White;
            this.newBettorButton.Location = new System.Drawing.Point(219, 277);
            this.newBettorButton.Name = "newBettorButton";
            this.newBettorButton.Size = new System.Drawing.Size(105, 28);
            this.newBettorButton.TabIndex = 12;
            this.newBettorButton.Text = "Nieuwe Gokker";
            this.newBettorButton.UseVisualStyleBackColor = false;
            this.newBettorButton.Click += new System.EventHandler(this.newBettorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.matchesPanel);
            this.Name = "MainForm";
            this.Text = "Gok applicatie";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.betPanel.ResumeLayout(false);
            this.betPanel.PerformLayout();
            this.teamPanel.ResumeLayout(false);
            this.teamPanel.PerformLayout();
            this.matchesPanel.ResumeLayout(false);
            this.matchesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label matchsTitleLabel;
        private System.Windows.Forms.Panel betPanel;
        private System.Windows.Forms.Panel matchesPanel;
        private System.Windows.Forms.Label currentBalenceLabel;
        private System.Windows.Forms.Label currentBalenceTitleLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.LinkLabel websiteLinkLabel;
        private System.Windows.Forms.Panel teamPanel;
        private System.Windows.Forms.Label teamLabel2;
        private System.Windows.Forms.Label teamLabel1;
        private System.Windows.Forms.TextBox scoreTeam1;
        private System.Windows.Forms.Label colon1;
        private System.Windows.Forms.TextBox scoreTeam2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newBettorButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

