using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplesNBugs
{
    public partial class Highscore : Form
    {
        List<int> scores = new List<int>();
        List<Label> labels = new List<Label>();
        string score;

        //dir paths and file paths
        string dir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Apples 'N Bugs");
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Apples 'N Bugs", "ApplesNBugsScores.txt");

        public Highscore()
        {
            InitializeComponent();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon;
            //label list creation
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);

            //stream reader for score from textfile
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((score = reader.ReadLine()) != null)
                    {
                        scores.Add(int.Parse(score));
                    }
                }

                //remove duplicates
                var scoresX = scores.Distinct().ToList();

                //sort scores by descending
                if (scoresX.Count > 0)
                {
                    scoresX.Sort();
                    scoresX.Reverse();
                }

                if (scoresX.Count > 10)
                {
                    scoresX = scoresX.Take(10).ToList();
                }

                //assign every score to its label position
                for (int i = 0; i < scoresX.Count; i++)
                {
                    labels[i].Text = scoresX[i].ToString();
                }
            }
        }

        private void InitMenu()
        {
            Application.Run(new Menu());
        }

        private void Highscore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMenu));
                this.Close();
                i.Start();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMenu));
            this.Close();
            i.Start();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.Image = Properties.Resources.closeClick;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.Image = Properties.Resources.Close;
        }

        //static score data holder that stores within the exe
        public static int scoreHolder;

        private void Clear_Click(object sender, EventArgs e)
        {
            //clears labels
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = "";
            }

            //deletes score file
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void Clear_MouseEnter(object sender, EventArgs e)
        {
            this.Clear.Image = Properties.Resources.clearHighscoreClick;
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            this.Clear.Image = Properties.Resources.clearHighscore;
        }
    }
}
