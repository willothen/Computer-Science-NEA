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
    public partial class SolverPage : Form
    {
        public SolverPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Forms.mm.StartPosition = FormStartPosition.Manual;
            Forms.mm.Location = this.Location;
            Forms.mm.Show();

            this.Hide();
        }

        private void SolverPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
