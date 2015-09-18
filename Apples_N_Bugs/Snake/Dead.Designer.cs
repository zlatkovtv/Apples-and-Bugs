namespace ApplesNBugs
{
    partial class Dead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dead));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.PictureBox();
            this.mmenu = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // Restart
            // 
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.Image = ((System.Drawing.Image)(resources.GetObject("Restart.Image")));
            this.Restart.Location = new System.Drawing.Point(176, 12);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(185, 41);
            this.Restart.TabIndex = 5;
            this.Restart.TabStop = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            this.Restart.MouseEnter += new System.EventHandler(this.Restart_MouseEnter);
            this.Restart.MouseLeave += new System.EventHandler(this.Restart_MouseLeave);
            // 
            // mmenu
            // 
            this.mmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mmenu.Image = ((System.Drawing.Image)(resources.GetObject("mmenu.Image")));
            this.mmenu.Location = new System.Drawing.Point(159, 62);
            this.mmenu.Name = "mmenu";
            this.mmenu.Size = new System.Drawing.Size(195, 45);
            this.mmenu.TabIndex = 6;
            this.mmenu.TabStop = false;
            this.mmenu.Click += new System.EventHandler(this.mmenu_Click);
            this.mmenu.MouseEnter += new System.EventHandler(this.mmenu_MouseEnter);
            this.mmenu.MouseLeave += new System.EventHandler(this.mmenu_MouseLeave);
            // 
            // Quit
            // 
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Image = ((System.Drawing.Image)(resources.GetObject("Quit.Image")));
            this.Quit.Location = new System.Drawing.Point(248, 106);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(113, 49);
            this.Quit.TabIndex = 7;
            this.Quit.TabStop = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.MouseEnter += new System.EventHandler(this.Quit_MouseEnter);
            this.Quit.MouseLeave += new System.EventHandler(this.Quit_MouseLeave);
            // 
            // Dead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 167);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.mmenu);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You are dead!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dead_FormClosing);
            this.Load += new System.EventHandler(this.Dead_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dead_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Restart;
        private System.Windows.Forms.PictureBox mmenu;
        private System.Windows.Forms.PictureBox Quit;
    }
}