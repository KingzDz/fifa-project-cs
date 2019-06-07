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
            this.matchLabel = new System.Windows.Forms.Label();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.matchComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.betMenuButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.matchesPanel = new System.Windows.Forms.Panel();
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.betPanel.SuspendLayout();
            this.matchesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchsTitleLabel
            // 
            this.matchsTitleLabel.AutoSize = true;
            this.matchsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchsTitleLabel.Location = new System.Drawing.Point(208, 9);
            this.matchsTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matchsTitleLabel.Name = "matchsTitleLabel";
            this.matchsTitleLabel.Size = new System.Drawing.Size(168, 31);
            this.matchsTitleLabel.TabIndex = 0;
            this.matchsTitleLabel.Text = "Wedstrijden";
            // 
            // betPanel
            // 
            this.betPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betPanel.BackColor = System.Drawing.Color.White;
            this.betPanel.Controls.Add(this.matchLabel);
            this.betPanel.Controls.Add(this.teamsLabel);
            this.betPanel.Controls.Add(this.matchComboBox);
            this.betPanel.Controls.Add(this.scheduleButton);
            this.betPanel.Controls.Add(this.betMenuButton);
            this.betPanel.Controls.Add(this.refreshButton);
            this.betPanel.Location = new System.Drawing.Point(39, 44);
            this.betPanel.Margin = new System.Windows.Forms.Padding(30);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(529, 456);
            this.betPanel.TabIndex = 2;
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchLabel.Location = new System.Drawing.Point(65, 257);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(402, 32);
            this.matchLabel.TabIndex = 16;
            this.matchLabel.Text = "De stand is nog niet bekend.";
            this.matchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLabel.Location = new System.Drawing.Point(42, 110);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(243, 32);
            this.teamsLabel.TabIndex = 15;
            this.teamsLabel.Text = "Team 1 - Team 2";
            this.teamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchComboBox
            // 
            this.matchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchComboBox.FormattingEnabled = true;
            this.matchComboBox.Location = new System.Drawing.Point(17, 18);
            this.matchComboBox.Name = "matchComboBox";
            this.matchComboBox.Size = new System.Drawing.Size(386, 24);
            this.matchComboBox.TabIndex = 14;
            this.matchComboBox.SelectedIndexChanged += new System.EventHandler(this.matchComboBox_SelectedIndexChanged);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scheduleButton.BackColor = System.Drawing.Color.Black;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.ForeColor = System.Drawing.Color.White;
            this.scheduleButton.Location = new System.Drawing.Point(17, 404);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(148, 34);
            this.scheduleButton.TabIndex = 13;
            this.scheduleButton.Text = "Schema";
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // betMenuButton
            // 
            this.betMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.betMenuButton.BackColor = System.Drawing.Color.Black;
            this.betMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betMenuButton.ForeColor = System.Drawing.Color.White;
            this.betMenuButton.Location = new System.Drawing.Point(383, 404);
            this.betMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.betMenuButton.Name = "betMenuButton";
            this.betMenuButton.Size = new System.Drawing.Size(127, 34);
            this.betMenuButton.TabIndex = 12;
            this.betMenuButton.Text = "Gok Menu";
            this.betMenuButton.UseVisualStyleBackColor = false;
            this.betMenuButton.Click += new System.EventHandler(this.betMenuButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(410, 18);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 28);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Ververs";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // matchesPanel
            // 
            this.matchesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchesPanel.BackColor = System.Drawing.Color.Silver;
            this.matchesPanel.Controls.Add(this.websiteLinkLabel);
            this.matchesPanel.Controls.Add(this.betPanel);
            this.matchesPanel.Controls.Add(this.matchsTitleLabel);
            this.matchesPanel.Location = new System.Drawing.Point(0, 0);
            this.matchesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.matchesPanel.Name = "matchesPanel";
            this.matchesPanel.Size = new System.Drawing.Size(607, 554);
            this.matchesPanel.TabIndex = 3;
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(75, 516);
            this.websiteLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(249, 17);
            this.websiteLinkLabel.TabIndex = 11;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "Team\'s aanmaken? Check de website!";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 554);
            this.Controls.Add(this.matchesPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Gok applicatie";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.betPanel.ResumeLayout(false);
            this.betPanel.PerformLayout();
            this.matchesPanel.ResumeLayout(false);
            this.matchesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label matchsTitleLabel;
        private System.Windows.Forms.Panel betPanel;
        private System.Windows.Forms.Panel matchesPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.LinkLabel websiteLinkLabel;
        private System.Windows.Forms.Button betMenuButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.ComboBox matchComboBox;
    }
}

