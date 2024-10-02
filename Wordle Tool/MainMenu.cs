using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle_Tool
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Forms.MainMenu = this;
            Users.PopulateComboBox(currentUserBox);
        }

        private void SolverPageButton_Click(object sender, EventArgs e)
        {
            Forms.SolverPage.Location = this.Location;
            Forms.SolverPage.Show();

            this.Hide();
        }

        private void PracticePageButton_Click(object sender, EventArgs e)
        {
            Forms.PracticePage.Location = this.Location;
            Forms.PracticePage.Show();

            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            Forms.UsersPage.Location = this.Location;
            Forms.UsersPage.Show();

            this.Hide();
        }

        private void currentUserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users.currentUser = (User)((ComboBox)sender).SelectedItem;
        }
    }
}
