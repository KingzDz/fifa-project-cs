namespace FifaProject
{
    partial class CheatForm
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
            this.cheatTextBox = new System.Windows.Forms.TextBox();
            this.cheatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cheatTextBox
            // 
            this.cheatTextBox.Location = new System.Drawing.Point(12, 12);
            this.cheatTextBox.Name = "cheatTextBox";
            this.cheatTextBox.Size = new System.Drawing.Size(286, 20);
            this.cheatTextBox.TabIndex = 0;
            // 
            // cheatButton
            // 
            this.cheatButton.Location = new System.Drawing.Point(119, 38);
            this.cheatButton.Name = "cheatButton";
            this.cheatButton.Size = new System.Drawing.Size(75, 23);
            this.cheatButton.TabIndex = 1;
            this.cheatButton.Text = "Klik niet hier!";
            this.cheatButton.UseVisualStyleBackColor = true;
            this.cheatButton.Click += new System.EventHandler(this.cheatButton_Click);
            // 
            // CheatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 71);
            this.Controls.Add(this.cheatButton);
            this.Controls.Add(this.cheatTextBox);
            this.Name = "CheatForm";
            this.Text = "CheatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cheatTextBox;
        private System.Windows.Forms.Button cheatButton;
    }
}