namespace ApplesNBugs
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.PictureBox();
            this.instructions = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Highscore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "by Zlatkov";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplesNBugs.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = global::ApplesNBugs.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Quit
            // 
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Image = ((System.Drawing.Image)(resources.GetObject("Quit.Image")));
            this.Quit.Location = new System.Drawing.Point(184, 375);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(191, 84);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.MouseEnter += new System.EventHandler(this.Quit_MouseEnter);
            this.Quit.MouseLeave += new System.EventHandler(this.Quit_MouseLeave);
            // 
            // instructions
            // 
            this.instructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructions.Image = ((System.Drawing.Image)(resources.GetObject("instructions.Image")));
            this.instructions.Location = new System.Drawing.Point(26, 189);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(527, 74);
            this.instructions.TabIndex = 6;
            this.instructions.TabStop = false;
            this.instructions.Click += new System.EventHandler(this.instructions_Click_1);
            this.instructions.MouseEnter += new System.EventHandler(this.instructions_MouseEnter);
            this.instructions.MouseLeave += new System.EventHandler(this.instructions_MouseLeave);
            // 
            // play
            // 
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(183, 106);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(214, 77);
            this.play.TabIndex = 7;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(406, 471);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(148, 32);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "ver. 0.4.4 stable alpha\r\n\r\n";
            // 
            // Highscore
            // 
            this.Highscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Highscore.Image = ((System.Drawing.Image)(resources.GetObject("Highscore.Image")));
            this.Highscore.Location = new System.Drawing.Point(82, 280);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(431, 82);
            this.Highscore.TabIndex = 9;
            this.Highscore.TabStop = false;
            this.Highscore.Click += new System.EventHandler(this.Highscore_Click);
            this.Highscore.MouseEnter += new System.EventHandler(this.Highscore_MouseEnter);
            this.Highscore.MouseLeave += new System.EventHandler(this.Highscore_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 495);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.play);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Highscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Quit;
        private System.Windows.Forms.PictureBox instructions;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox Highscore;
    }
}