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
            this.SuspendLayout();
            // 
            // SolverPageButton
            // 
            this.SolverPageButton.Location = new System.Drawing.Point(303, 125);
            this.SolverPageButton.Name = "SolverPageButton";
            this.SolverPageButton.Size = new System.Drawing.Size(75, 23);
            this.SolverPageButton.TabIndex = 0;
            this.SolverPageButton.Text = "Solver";
            this.SolverPageButton.UseVisualStyleBackColor = true;
            this.SolverPageButton.Click += new System.EventHandler(this.SolverPageButton_Click);
            // 
            // PracticePageButton
            // 
            this.PracticePageButton.Location = new System.Drawing.Point(302, 212);
            this.PracticePageButton.Name = "PracticePageButton";
            this.PracticePageButton.Size = new System.Drawing.Size(75, 23);
            this.PracticePageButton.TabIndex = 1;
            this.PracticePageButton.Text = "Practice";
            this.PracticePageButton.UseVisualStyleBackColor = true;
            this.PracticePageButton.Click += new System.EventHandler(this.PracticePageButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracticePageButton);
            this.Controls.Add(this.SolverPageButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SolverPageButton;
        private System.Windows.Forms.Button PracticePageButton;
    }
}

