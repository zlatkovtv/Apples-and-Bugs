namespace ApplesNBugs
{
    partial class Playmode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playmode));
            this.Hard = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Normal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal)).BeginInit();
            this.SuspendLayout();
            // 
            // Hard
            // 
            this.Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hard.Image = ((System.Drawing.Image)(resources.GetObject("Hard.Image")));
            this.Hard.Location = new System.Drawing.Point(265, 81);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(175, 78);
            this.Hard.TabIndex = 1;
            this.Hard.TabStop = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            this.Hard.MouseEnter += new System.EventHandler(this.Hard_MouseEnter);
            this.Hard.MouseLeave += new System.EventHandler(this.Hard_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ApplesNBugs.Properties.Resources.GameplayMode;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(420, 54);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Normal
            // 
            this.Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Normal.Image = ((System.Drawing.Image)(resources.GetObject("Normal.Image")));
            this.Normal.Location = new System.Drawing.Point(12, 91);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(232, 59);
            this.Normal.TabIndex = 3;
            this.Normal.TabStop = false;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            this.Normal.MouseEnter += new System.EventHandler(this.Normal_MouseEnter);
            this.Normal.MouseLeave += new System.EventHandler(this.Normal_MouseLeave);
            // 
            // Playmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 162);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Hard);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Playmode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playmode";
            this.Load += new System.EventHandler(this.Playmode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Hard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Normal;


    }
}