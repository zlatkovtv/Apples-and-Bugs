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
    public partial class Dead : Form
    {
        public Dead()
        {
            InitializeComponent();
        }

        public void RestartGame()
        {
            Application.Run(new ApplesNbugs());
        }

        public void MainMenu()
        {
            Application.Run(new Menu());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dead_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Dead_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon;

            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            this.label1.Text = "Game Over!";
            this.label2.Text = String.Format("Score: " + ApplesNbugs.score);

            //create directory for score file
            string dir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Apples 'N Bugs");

            if (!Directory.Exists(dir))
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(dir);
                //makes score directory hidden
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden; 
            }

            //when dead screen appears, save current final score to file
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Apples 'N Bugs", "ApplesNBugsScores.txt");

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(ApplesNbugs.score);
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(RestartGame));
            Application.Exit();
            t.Start();
            //resets score for new restarted game
            ApplesNbugs.score = 0;
        }

        private void mmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu1 = new Menu();
            System.Threading.Thread m = new System.Threading.Thread(new System.Threading.ThreadStart(MainMenu));
            m.Start();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Restart_MouseEnter(object sender, EventArgs e)
        {
            this.Restart.Image = Properties.Resources.restartClick;
        }

        private void Restart_MouseLeave(object sender, EventArgs e)
        {
            this.Restart.Image = Properties.Resources.Restart;
        }

        private void mmenu_MouseEnter(object sender, EventArgs e)
        {
            this.mmenu.Image = Properties.Resources.mainMenuClick;
        }

        private void mmenu_MouseLeave(object sender, EventArgs e)
        {
            this.mmenu.Image = Properties.Resources.MainMenu;
        }

        private void Quit_MouseEnter(object sender, EventArgs e)
        {
            this.Quit.Image = Properties.Resources.quit2Click;
        }

        private void Quit_MouseLeave(object sender, EventArgs e)
        {
            this.Quit.Image = Properties.Resources.Quit2;
        }

        private void Dead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(RestartGame));
                Application.Exit();
                t.Start();
                //resets score for new restarted game
                ApplesNbugs.score = 0;
            }
        }
    }
}
