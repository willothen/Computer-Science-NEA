namespace Wordle_Tool
{
    partial class SolverPage
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NextWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(16, 15);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextWordButton
            // 
            this.NextWordButton.Location = new System.Drawing.Point(593, 110);
            this.NextWordButton.Name = "NextWordButton";
            this.NextWordButton.Size = new System.Drawing.Size(143, 23);
            this.NextWordButton.TabIndex = 1;
            this.NextWordButton.Text = "next word";
            this.NextWordButton.UseVisualStyleBackColor = true;
            this.NextWordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolverPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.NextWordButton);
            this.Controls.Add(this.BackButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SolverPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wordle Solver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SolverPage_FormClosed);
            this.Load += new System.EventHandler(this.SolverPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextWordButton;
    }
}