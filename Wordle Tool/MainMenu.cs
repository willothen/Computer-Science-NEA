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
            Forms.mm = this;
        }

        private void SolverPageButton_Click(object sender, EventArgs e)
        {
            Forms.sp.Location = this.Location;
            Forms.sp.Show();

            this.Hide();
        }

        private void PracticePageButton_Click(object sender, EventArgs e)
        {
            Forms.pp.Location = this.Location;
            Forms.pp.Show();

            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
