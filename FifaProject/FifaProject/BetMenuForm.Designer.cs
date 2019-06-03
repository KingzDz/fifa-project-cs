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
            this.label4 = new System.Windows.Forms.Label();
            this.matchComboBox = new System.Windows.Forms.ComboBox();
            this.euroTextBox = new System.Windows.Forms.TextBox();
            this.euroLabel = new System.Windows.Forms.Label();
            this.colonLabel = new System.Windows.Forms.Label();
            this.scoreTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.scoreTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bettorListTextBox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.cheatPanel = new System.Windows.Forms.Panel();
            this.balanceTitleLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.teamOneLabel = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.teamTwoLabel);
            this.panel1.Controls.Add(this.teamOneLabel);
            this.panel1.Controls.Add(this.balanceLabel);
            this.panel1.Controls.Add(this.balanceTitleLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.matchComboBox);
            this.panel1.Controls.Add(this.euroTextBox);
            this.panel1.Controls.Add(this.euroLabel);
            this.panel1.Controls.Add(this.colonLabel);
            this.panel1.Controls.Add(this.scoreTextBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.betButton);
            this.panel1.Controls.Add(this.scoreTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bettorListTextBox);
            this.panel1.Location = new System.Drawing.Point(29, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 351);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ronde:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matchComboBox
            // 
            this.matchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchComboBox.FormattingEnabled = true;
            this.matchComboBox.ItemHeight = 13;
            this.matchComboBox.Location = new System.Drawing.Point(298, 24);
            this.matchComboBox.Name = "matchComboBox";
            this.matchComboBox.Size = new System.Drawing.Size(319, 21);
            this.matchComboBox.TabIndex = 2;
            this.matchComboBox.SelectedIndexChanged += new System.EventHandler(this.matchComboBox_SelectedIndexChanged);
            // 
            // euroTextBox
            // 
            this.euroTextBox.Location = new System.Drawing.Point(20, 185);
            this.euroTextBox.Name = "euroTextBox";
            this.euroTextBox.Size = new System.Drawing.Size(85, 20);
            this.euroTextBox.TabIndex = 6;
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
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel.Location = new System.Drawing.Point(16, 107);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(13, 20);
            this.colonLabel.TabIndex = 13;
            this.colonLabel.Text = ":";
            // 
            // scoreTextBox2
            // 
            this.scoreTextBox2.Location = new System.Drawing.Point(19, 130);
            this.scoreTextBox2.Name = "scoreTextBox2";
            this.scoreTextBox2.Size = new System.Drawing.Size(32, 20);
            this.scoreTextBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
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
            this.betButton.TabIndex = 8;
            this.betButton.Text = "Gok";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // scoreTextBox1
            // 
            this.scoreTextBox1.Location = new System.Drawing.Point(19, 85);
            this.scoreTextBox1.Name = "scoreTextBox1";
            this.scoreTextBox1.Size = new System.Drawing.Size(32, 20);
            this.scoreTextBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gokkers die op deze ronde wedden";
            // 
            // bettorListTextBox
            // 
            this.bettorListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettorListTextBox.Location = new System.Drawing.Point(241, 80);
            this.bettorListTextBox.Name = "bettorListTextBox";
            this.bettorListTextBox.ReadOnly = true;
            this.bettorListTextBox.Size = new System.Drawing.Size(376, 256);
            this.bettorListTextBox.TabIndex = 0;
            this.bettorListTextBox.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(42, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(194, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Gok Menu    | ";
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
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "Nieuw Spel";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // cheatPanel
            // 
            this.cheatPanel.Location = new System.Drawing.Point(615, -1);
            this.cheatPanel.Name = "cheatPanel";
            this.cheatPanel.Size = new System.Drawing.Size(78, 51);
            this.cheatPanel.TabIndex = 13;
            this.cheatPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cheatPanel_MouseDoubleClick);
            // 
            // balanceTitleLabel
            // 
            this.balanceTitleLabel.AutoSize = true;
            this.balanceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTitleLabel.Location = new System.Drawing.Point(16, 24);
            this.balanceTitleLabel.Name = "balanceTitleLabel";
            this.balanceTitleLabel.Size = new System.Drawing.Size(50, 18);
            this.balanceTitleLabel.TabIndex = 18;
            this.balanceTitleLabel.Text = "Saldo:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(84, 24);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(37, 18);
            this.balanceLabel.TabIndex = 19;
            this.balanceLabel.Text = "€0,-\r\n";
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneLabel.Location = new System.Drawing.Point(57, 88);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.Size = new System.Drawing.Size(46, 17);
            this.teamOneLabel.TabIndex = 20;
            this.teamOneLabel.Text = "label5";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoLabel.Location = new System.Drawing.Point(59, 131);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(46, 17);
            this.teamTwoLabel.TabIndex = 21;
            this.teamTwoLabel.Text = "label5";
            // 
            // BetMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.cheatPanel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.Name = "BetMenuForm";
            this.Text = "BetMenuForm";
            this.Load += new System.EventHandler(this.BetMenuForm_Load);
            this.Shown += new System.EventHandler(this.BetMenuForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox bettorListTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.TextBox scoreTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TextBox scoreTextBox2;
        private System.Windows.Forms.TextBox euroTextBox;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Panel cheatPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox matchComboBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceTitleLabel;
        private System.Windows.Forms.Label teamTwoLabel;
        private System.Windows.Forms.Label teamOneLabel;
    }
}