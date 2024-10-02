namespace Wordle_Tool
{
    partial class MainMenu
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
            this.SolverPageButton = new System.Windows.Forms.Button();
            this.PracticePageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.currentUserBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SolverPageButton
            // 
            this.SolverPageButton.Location = new System.Drawing.Point(83, 117);
            this.SolverPageButton.Name = "SolverPageButton";
            this.SolverPageButton.Size = new System.Drawing.Size(75, 23);
            this.SolverPageButton.TabIndex = 0;
            this.SolverPageButton.Text = "Solver";
            this.SolverPageButton.UseVisualStyleBackColor = true;
            this.SolverPageButton.Click += new System.EventHandler(this.SolverPageButton_Click);
            // 
            // PracticePageButton
            // 
            this.PracticePageButton.Location = new System.Drawing.Point(83, 146);
            this.PracticePageButton.Name = "PracticePageButton";
            this.PracticePageButton.Size = new System.Drawing.Size(75, 23);
            this.PracticePageButton.TabIndex = 1;
            this.PracticePageButton.Text = "Practice";
            this.PracticePageButton.UseVisualStyleBackColor = true;
            this.PracticePageButton.Click += new System.EventHandler(this.PracticePageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wordle Tool";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(83, 204);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(83, 175);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 23);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // currentUserBox
            // 
            this.currentUserBox.FormattingEnabled = true;
            this.currentUserBox.Location = new System.Drawing.Point(83, 74);
            this.currentUserBox.Name = "currentUserBox";
            this.currentUserBox.Size = new System.Drawing.Size(121, 21);
            this.currentUserBox.TabIndex = 5;
            this.currentUserBox.SelectedIndexChanged += new System.EventHandler(this.currentUserBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current User: ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(244, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentUserBox);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PracticePageButton);
            this.Controls.Add(this.SolverPageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SolverPageButton;
        private System.Windows.Forms.Button PracticePageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button usersButton;
        public System.Windows.Forms.ComboBox currentUserBox;
        private System.Windows.Forms.Label label2;
    }
}

