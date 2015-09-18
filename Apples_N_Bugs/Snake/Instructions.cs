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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void InitMenu()
        {
            Application.Run(new Menu());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMenu));
            this.Close();
            i.Start();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.Image = Properties.Resources.closeClick;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.Image = Properties.Resources.Close;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Instructions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                System.Threading.Thread i = new System.Threading.Thread(new System.Threading.ThreadStart(InitMenu));
                this.Close();
                i.Start();
            }
        }
    }
}
