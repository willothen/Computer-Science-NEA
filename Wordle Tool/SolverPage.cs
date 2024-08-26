using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Windows.Forms;

namespace Wordle_Tool
{
    public partial class SolverPage : Form
    {
        static Label[,] words;
        SolveWordle solve;

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

        private void SolverPage_Load(object sender, EventArgs e)
        {
            words = new Label[6, 5];

            int x = 50, y = 50;

            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    Label label = new Label();
                    label.Text = "";
                    label.Location = new Point(x, y);
                    label.BackColor = WordleColours.black;
                    label.Size = new Size(50, 50);
                    label.Font = new Font("Arial", 33, FontStyle.Bold);
                    label.ForeColor = Color.White;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Click += LabelClicked;

                    words[i, a] = label;

                    this.Controls.Add(label);

                    x += 55;
                }

                y += 55;
                x = 50;
            }

            solve = new SolveWordle(ref words);
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            solve.LetterClicked((Label)sender);
        }

        private void NextWordButtonClicked(object sender, EventArgs e)
        {
            solve.NextWordButtonClicked();
        }
    }

    public class SolveWordle
    {
        Label[,] words;
        string startWord = "salet";
        int currentRow = 0;
        List<char> unusedLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList<char>();
        List<char> greyLetters = new List<char>();
        List<string> possibleWords = WordLists.GetAllWordsList();
        char[] greenLetters = new char[5] { ' ', ' ', ' ', ' ', ' ' };
        char[,] yellowLetters = new char[6, 5];

        public SolveWordle(ref Label[,] words)
        {
            this.words = words;
            SetRow(startWord, 0);
        }

        private void SetRow(string s, int row)
        {
            for (int i = 0; i < s.Length; i++)
            {
                words[row, i].Text = s[i].ToString().ToUpper();
                words[row, i].BackColor = WordleColours.grey;
            }

            RemoveUsedLetters(s);
        }

        private void RemoveUsedLetters(string s)
        {
            foreach (char c in s)
            {
                unusedLetters.Remove(c);
            }
        }

        public void LetterClicked(Label l)
        {
            if (l.BackColor == WordleColours.grey)
            {
                l.BackColor = WordleColours.yellow;
            }
            else if (l.BackColor == WordleColours.yellow)
            {
                l.BackColor = WordleColours.green;
            }
            else if (l.BackColor == WordleColours.green)
            {
                l.BackColor = WordleColours.grey;
            }
        }

        private void CollectGreyLetters(int row)
        {
            for (int i = 0; i < 5; i++)
            {
                if (words[row, i].BackColor == WordleColours.grey)
                {
                    greyLetters.Add(words[row, i].Text.ToLower()[0]);
                }
            }
        }

        private void CollectYellowLetters(int row)
        {
            for (int i = 0; i < 5; i++)
            {
                if (words[row, i].BackColor == WordleColours.yellow)
                {
                    yellowLetters[row, i] = words[row, i].Text.ToLower()[0];
                }
            }
        }

        private void CollectGreenLetters(int row)
        {
            for (int i = 0; i < 5; i++)
            {
                if (words[row, i].BackColor == WordleColours.green)
                {
                    greenLetters[i] = words[row, i].Text.ToLower()[0];
                }
            }
        }

        public void NextWordButtonClicked()
        {
            CollectGreyLetters(currentRow);
            CollectYellowLetters(currentRow);
            CollectGreenLetters(currentRow);
            RemoveImpossibleWordsFromWordList();


            currentRow++;
            //SetRow("salet", currentRow);
        }

        public void RemoveImpossibleWordsFromWordList()
        {
            List<string> newPossibleWords = new List<string>();

            foreach (string s in possibleWords)
            {
                bool possible = true;

                for (int i = 0; i < 5; i++)
                {
                    // check green letters against all words
                    if (s[i] != greenLetters[i] && greenLetters[i] != ' ')
                    {
                        possible = false;
                        break;
                    }
                    // check if word contains a grey letter
                    else if (greyLetters.Contains(s[i]))
                    {
                        possible = false;
                        break;
                    }
                }

                // check yellow letters
                foreach (char c in yellowLetters)
                {
                    if (!s.Contains(c) && char.IsLetter(c))
                    {
                        possible = false;
                    }
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (s[j] == yellowLetters[i, j])
                        {
                            possible = false;
                        }
                    }
                }
                
                if (possible)
                {
                    newPossibleWords.Add(s);
                }
            }

            possibleWords = newPossibleWords;
        }

        private string BestNextWord()
        {


            return null;
        }
    }
}
