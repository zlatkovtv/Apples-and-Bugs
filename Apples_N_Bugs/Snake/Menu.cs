using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplesNBugs
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon;
        }

        public void ThreadProc()
        {
            Application.Run(new Playmode());
        }

        public void InitInstr()
        {
            Application.Run(new Instructions());
        }

        public void InitHighscore()
        {
            Application.Run(new Highscore());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void play_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            this.Close();
            t.Start();
        }

        private void instructions_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitInstr));
            this.Close();
            i.Start();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            this.play.Image = Properties.Resources.playClick;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            this.play.Image = Properties.Resources.Play;
        }

        private void instructions_MouseEnter(object sender, EventArgs e)
        {
            this.instructions.Image = Properties.Resources.instructionsClick;
        }

        private void instructions_MouseLeave(object sender, EventArgs e)
        {
            this.instructions.Image = Properties.Resources.Instructions;
        }

        private void Quit_MouseEnter(object sender, EventArgs e)
        {
            this.Quit.Image = Properties.Resources.quitClick;
        }

        private void Quit_MouseLeave(object sender, EventArgs e)
        {
            this.Quit.Image = Properties.Resources.Quit;
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                this.Close();
                t.Start();
            }
        }

        private void Highscore_MouseEnter(object sender, EventArgs e)
        {
            this.Highscore.Image = Properties.Resources.highscoreClick;
        }

        private void Highscore_MouseLeave(object sender, EventArgs e)
        {
            this.Highscore.Image = Properties.Resources.Highscore;
        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            System.Threading.Thread h = new System.Threading.Thread(new System.Threading.ThreadStart(InitHighscore));
            this.Close();
            h.Start();
        }
    }
}
