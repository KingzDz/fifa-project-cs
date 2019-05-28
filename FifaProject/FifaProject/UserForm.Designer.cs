namespace FifaProject
{
    partial class UserForm
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
            this.bettorComboBox = new System.Windows.Forms.ComboBox();
            this.newBettorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bettorComboBox
            // 
            this.bettorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bettorComboBox.FormattingEnabled = true;
            this.bettorComboBox.ItemHeight = 13;
            this.bettorComboBox.Location = new System.Drawing.Point(21, 39);
            this.bettorComboBox.Name = "bettorComboBox";
            this.bettorComboBox.Size = new System.Drawing.Size(203, 21);
            this.bettorComboBox.TabIndex = 1;
            this.bettorComboBox.SelectedIndexChanged += new System.EventHandler(this.bettorComboBox_SelectedIndexChanged);
            // 
            // newBettorButton
            // 
            this.newBettorButton.BackColor = System.Drawing.Color.Black;
            this.newBettorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBettorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBettorButton.ForeColor = System.Drawing.Color.White;
            this.newBettorButton.Location = new System.Drawing.Point(21, 117);
            this.newBettorButton.Margin = new System.Windows.Forms.Padding(30, 20, 60, 20);
            this.newBettorButton.Name = "newBettorButton";
            this.newBettorButton.Size = new System.Drawing.Size(203, 33);
            this.newBettorButton.TabIndex = 2;
            this.newBettorButton.Text = "Maak een gokker aan";
            this.newBettorButton.UseVisualStyleBackColor = false;
            this.newBettorButton.Click += new System.EventHandler(this.newBettorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kies een gokker.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Of maak een nieuwe aan.";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bettorComboBox);
            this.Controls.Add(this.newBettorButton);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bettorComboBox;
        private System.Windows.Forms.Button newBettorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}