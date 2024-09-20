namespace Wordle_Tool
{
    partial class UsersPage
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
            this.userCreateTextBox = new System.Windows.Forms.TextBox();
            this.userCreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.deleteUsersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userCreateTextBox
            // 
            this.userCreateTextBox.Location = new System.Drawing.Point(22, 64);
            this.userCreateTextBox.Name = "userCreateTextBox";
            this.userCreateTextBox.Size = new System.Drawing.Size(121, 20);
            this.userCreateTextBox.TabIndex = 0;
            // 
            // userCreateButton
            // 
            this.userCreateButton.Location = new System.Drawing.Point(157, 62);
            this.userCreateButton.Name = "userCreateButton";
            this.userCreateButton.Size = new System.Drawing.Size(75, 23);
            this.userCreateButton.TabIndex = 1;
            this.userCreateButton.Text = "Create";
            this.userCreateButton.UseVisualStyleBackColor = true;
            this.userCreateButton.Click += new System.EventHandler(this.userCreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create user";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delete user";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(157, 113);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 5;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // deleteUsersComboBox
            // 
            this.deleteUsersComboBox.FormattingEnabled = true;
            this.deleteUsersComboBox.Location = new System.Drawing.Point(22, 113);
            this.deleteUsersComboBox.Name = "deleteUsersComboBox";
            this.deleteUsersComboBox.Size = new System.Drawing.Size(121, 21);
            this.deleteUsersComboBox.TabIndex = 6;
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(244, 265);
            this.Controls.Add(this.deleteUsersComboBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCreateButton);
            this.Controls.Add(this.userCreateTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsersPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UsersPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersPage_FormClosed);
            this.Load += new System.EventHandler(this.UsersPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userCreateTextBox;
        private System.Windows.Forms.Button userCreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.ComboBox deleteUsersComboBox;
    }
}