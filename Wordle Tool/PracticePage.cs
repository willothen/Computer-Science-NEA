﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Wordle_Tool
{
    public partial class PracticePage : Form
    {
        static Label[,] words;
        PracticeGame game;

        public PracticePage()
        {
            InitializeComponent();
        }

        private void PracticePage_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            BackButton.TabStop = false;
            words = new Label[6, 5];

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

            game = new PracticeGame(ref words);
            // FOR TESTING ONLY
            //testingLabel.Text = game.solution;
            testingLabel.Text = "blud";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Forms.mm.StartPosition = FormStartPosition.Manual;
            Forms.mm.Location = this.Location;
            Forms.mm.Show();

            this.Hide();
        }

        private void PracticePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Back)
            {
                game.RemoveCharacter();
            }
            else if (keyData == Keys.Return)
            {
                game.CheckEnteredRow();
            }
            else if (65 <= (int)keyData & (int)keyData <= 90)
            {
                game.AddCharacter((char)keyData);
            }

            //return base.ProcessCmdKey(ref msg, keyData);
            return true;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game = new PracticeGame(ref words);

            // FOR TESTING ONLY
            //testingLabel.Text = game.solution;
            testingLabel.Text = "blud";
        }
    }

    public class PracticeGame
    {
        private int currentLine = 0;
        private int nextCharIndex = 0;

        // FOR TESTING ONLY SET TO PRIVATE LATER
        public string solution;
        Label[,] words;

        public PracticeGame(ref Label[,] words)
        {
            this.words = words;

            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    Label label = words[i, a];
                    label.Text = " ";
                    label.BackColor = Color.FromArgb(18, 18, 19);
                    words[i, a] = label;
                }
            }

            Random rnd = new Random();
            solution = WordLists.answers[rnd.Next(WordLists.answers.Length)];
        }

        public void AddCharacter(char c)
        {
            if (nextCharIndex < 5 && currentLine <= 5)
            {
                words[currentLine, nextCharIndex].Text = c.ToString();
                nextCharIndex++;
            }
        }

        public void CheckEnteredRow()
        {
            if (nextCharIndex == 5)
            {
                string line = RowToString(currentLine);

                if (WordLists.answers.Contains(line) || WordLists.guessable.Contains(line))
                {
                    SetColours(CompareToSolution(line));

                    currentLine++;
                    nextCharIndex = 0;
                }
            }
        }

        // returns 0 for grey, 1 for yellow, and 2 for green
        private int[] CompareToSolution(string word)
        {
            int[] ints = new int[5];
            int[] letterCount = new int[5];
            List<char> chars = new List<char>();

            foreach (char c in solution)
            {
                chars.Add(c);
            }

            for (int i = 0; i < 5; i++)
            {
                if (word[i] == solution[i])
                {
                    ints[i] = 2;
                    chars.Remove(word[i]);
                }
                else if (solution.Contains(word[i]) & chars.Contains(word[i]))
                {
                    ints[i] = 1;
                    chars.Remove(word[i]);
                }
                else
                {
                    ints[i] = 0;
                }
            }

            return ints;
        }

        private void SetColours(int[] ints)
        {
            for (int i = 0; i < 5; i++)
            {
                switch (ints[i])
                {
                    case 0:
                        words[currentLine, i].BackColor = Color.Gray;
                        break;
                    case 1:
                        words[currentLine, i].BackColor = Color.FromArgb(181, 159, 59);
                        break;
                    case 2:
                        words[currentLine, i].BackColor = Color.Green;
                        break;
                }
            }
        }

        public void RemoveCharacter()
        {
            if (nextCharIndex > 0)
            {
                words[currentLine, nextCharIndex - 1].Text = " ";
                nextCharIndex--;
            }
        }

        string RowToString(int row)
        {
            string s = "";

            for (int i = 0; i < 5; i++)
            {
                s += words[row, i].Text;
            }

            return s.ToLower();
        }
    }
}
