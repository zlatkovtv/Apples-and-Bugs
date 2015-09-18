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
    public partial class Playmode : Form
    {
        public Playmode()
        {
            InitializeComponent();
        }

        public void StartGame()
        {
            Application.Run(new ApplesNbugs());
        }

        private void Playmode_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartGame));
            Application.Exit();
            t.Start();
            //resets score for new restarted game
            ApplesNbugs.score = 0;

            ApplesNbugs.isHard = false;
        }

        private void Normal_MouseEnter(object sender, EventArgs e)
        {
            this.Normal.Image = Properties.Resources.NormalClick;
        }

        private void Normal_MouseLeave(object sender, EventArgs e)
        {
            this.Normal.Image = Properties.Resources.Normal;
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartGame));
            Application.Exit();
            t.Start();
            //resets score for new restarted game
            ApplesNbugs.score = 0;

            ApplesNbugs.isHard = true;
        }

        private void Hard_MouseEnter(object sender, EventArgs e)
        {
            Hard.Image = Properties.Resources.hardClick;
        }

        private void Hard_MouseLeave(object sender, EventArgs e)
        {
            Hard.Image = Properties.Resources.Hard;
        }
    }
}
