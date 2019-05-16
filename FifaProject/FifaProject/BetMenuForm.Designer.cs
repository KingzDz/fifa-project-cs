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
            this.label3 = new System.Windows.Forms.Label();
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.bettorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bettorListTextBox = new System.Windows.Forms.RichTextBox();
            this.newBettorButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.teamsComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.betButton);
            this.panel1.Controls.Add(this.betTextBox);
            this.panel1.Controls.Add(this.bettorComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bettorListTextBox);
            this.panel1.Controls.Add(this.newBettorButton);
            this.panel1.Location = new System.Drawing.Point(29, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 351);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Op";
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.FormattingEnabled = true;
            this.teamsComboBox.Location = new System.Drawing.Point(20, 213);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(203, 21);
            this.teamsComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 140);
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
            this.betButton.Location = new System.Drawing.Point(20, 269);
            this.betButton.Margin = new System.Windows.Forms.Padding(30, 20, 60, 20);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(203, 61);
            this.betButton.TabIndex = 7;
            this.betButton.Text = "Gok";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(20, 161);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(203, 20);
            this.betTextBox.TabIndex = 6;
            // 
            // bettorComboBox
            // 
            this.bettorComboBox.FormattingEnabled = true;
            this.bettorComboBox.Location = new System.Drawing.Point(20, 110);
            this.bettorComboBox.Name = "bettorComboBox";
            this.bettorComboBox.Size = new System.Drawing.Size(203, 21);
            this.bettorComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lijst van gokkers";
            // 
            // bettorListTextBox
            // 
            this.bettorListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettorListTextBox.Location = new System.Drawing.Point(241, 54);
            this.bettorListTextBox.Name = "bettorListTextBox";
            this.bettorListTextBox.ReadOnly = true;
            this.bettorListTextBox.Size = new System.Drawing.Size(376, 276);
            this.bettorListTextBox.TabIndex = 3;
            this.bettorListTextBox.Text = "";
            // 
            // newBettorButton
            // 
            this.newBettorButton.BackColor = System.Drawing.Color.Black;
            this.newBettorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBettorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBettorButton.ForeColor = System.Drawing.Color.White;
            this.newBettorButton.Location = new System.Drawing.Point(20, 54);
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
            // BetMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(694, 450);
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
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.ComboBox bettorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.Label label2;
    }
}