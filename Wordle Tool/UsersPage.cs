using System;
using System.Windows.Forms;

namespace Wordle_Tool
{
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void userCreateButton_Click(object sender, EventArgs e)
        {
            Users.CreateUser(userCreateTextBox.Text);
            userCreateTextBox.Text = string.Empty;

            Users.UpdateComboBoxes();
        }

        private void UsersPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Forms.MainMenu.StartPosition = FormStartPosition.Manual;
            Forms.MainMenu.Location = this.Location;
            Forms.MainMenu.Show();

            this.Hide();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            Users.users.Remove((User) deleteUsersComboBox.SelectedItem);
            deleteUsersComboBox.Text = string.Empty;

            Users.UpdateComboBoxes();
        }

        private void UsersPage_Load(object sender, EventArgs e)
        {
            Users.comboBoxes.Add(deleteUsersComboBox);
            Users.UpdateComboBoxes();
        }
    }
}
