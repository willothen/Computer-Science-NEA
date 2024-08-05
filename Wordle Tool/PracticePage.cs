using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Wordle_Tool
{
    public partial class PracticePage : Form
    {
        Label[,] words = new Label[6, 5];
        int currentLine = 0;
        int charIndex = 0; //next character index

        void addCharacter(char c)
        {
            words[currentLine, charIndex].Text = c.ToString();
            charIndex++;
        }

        void removeCharacter()
        {
            words[currentLine, charIndex].Text = " ";
            charIndex--;
        }

        string rowToString(int row)
        {
            string s = "";

            for (int i = 0; i < 5; i++)
            {
                s += words[row, i].Text;
            }

            return s;
        }

        public PracticePage()
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

        private void PracticePage_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            int x = 50, y = 50;

            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    Label label = new Label();
                    label.Text = "";
                    label.Location = new Point(x, y);
                    label.BackColor = Color.FromArgb(18, 18, 19);
                    label.Size = new Size(50, 50);
                    label.Font = new Font("Arial", 33, FontStyle.Bold);
                    label.ForeColor = Color.White;
                    label.BorderStyle = BorderStyle.FixedSingle;

                    words[i, a] = label;

                    this.Controls.Add(label);

                    x += 55;
                }

                y += 55;
                x = 50;
            }
        }

        private void PracticePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PracticePage_KeyDown(object sender, KeyEventArgs e)
        {
            addCharacter((char)e.KeyCode);
        }
    }
}
