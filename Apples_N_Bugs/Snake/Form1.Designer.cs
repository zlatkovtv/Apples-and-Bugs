namespace ApplesNBugs
{
    partial class ApplesNbugs
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
            this.components = new System.ComponentModel.Container();
            this.GameFlowTimer = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.Paused = new System.Windows.Forms.PictureBox();
            this.CountDown = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.SpeedUp = new System.Windows.Forms.PictureBox();
            this.frenzyPowerUp = new System.Windows.Forms.PictureBox();
            this.fivePlus = new System.Windows.Forms.PictureBox();
            this.powerUpTimer = new System.Windows.Forms.Timer(this.components);
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            this.scorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenzyPowerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePlus)).BeginInit();
            this.SuspendLayout();
            // 
            // GameFlowTimer
            // 
            this.GameFlowTimer.Interval = 5;
            this.GameFlowTimer.Tick += new System.EventHandler(this.GameFlowTimer_Tick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.CountDown);
            this.screen.Controls.Add(this.apple);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.SpeedUp);
            this.screen.Controls.Add(this.frenzyPowerUp);
            this.screen.Controls.Add(this.fivePlus);
            this.screen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.screen.Location = new System.Drawing.Point(0, 35);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(650, 650);
            this.screen.TabIndex = 0;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.LightBlue;
            this.scorePanel.Controls.Add(this.scoreLabel);
            this.scorePanel.Controls.Add(this.Paused);
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scorePanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePanel.Location = new System.Drawing.Point(0, 0);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(650, 35);
            this.scorePanel.TabIndex = 9;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(211, 7);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(63, 17);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // Paused
            // 
            this.Paused.Image = global::ApplesNBugs.Properties.Resources.Paused;
            this.Paused.Location = new System.Drawing.Point(387, 6);
            this.Paused.Name = "Paused";
            this.Paused.Size = new System.Drawing.Size(104, 25);
            this.Paused.TabIndex = 4;
            this.Paused.TabStop = false;
            this.Paused.Visible = false;
            // 
            // CountDown
            // 
            this.CountDown.Image = global::ApplesNBugs.Properties.Resources.Three;
            this.CountDown.Location = new System.Drawing.Point(309, 558);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(33, 47);
            this.CountDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountDown.TabIndex = 7;
            this.CountDown.TabStop = false;
            // 
            // apple
            // 
            this.apple.Image = global::ApplesNBugs.Properties.Resources.Apple;
            this.apple.InitialImage = global::ApplesNBugs.Properties.Resources.Apple;
            this.apple.Location = new System.Drawing.Point(465, 215);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(20, 20);
            this.apple.TabIndex = 1;
            this.apple.TabStop = false;
            this.apple.Click += new System.EventHandler(this.apple_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::ApplesNBugs.Properties.Resources.playerRight;
            this.player.Location = new System.Drawing.Point(132, 215);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 35);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // SpeedUp
            // 
            this.SpeedUp.Enabled = false;
            this.SpeedUp.Image = global::ApplesNBugs.Properties.Resources.speedUp;
            this.SpeedUp.Location = new System.Drawing.Point(380, 158);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(30, 30);
            this.SpeedUp.TabIndex = 8;
            this.SpeedUp.TabStop = false;
            this.SpeedUp.Visible = false;
            // 
            // frenzyPowerUp
            // 
            this.frenzyPowerUp.Enabled = false;
            this.frenzyPowerUp.Image = global::ApplesNBugs.Properties.Resources.frenzyPowerUp;
            this.frenzyPowerUp.Location = new System.Drawing.Point(196, 131);
            this.frenzyPowerUp.Name = "frenzyPowerUp";
            this.frenzyPowerUp.Size = new System.Drawing.Size(30, 30);
            this.frenzyPowerUp.TabIndex = 6;
            this.frenzyPowerUp.TabStop = false;
            this.frenzyPowerUp.Visible = false;
            // 
            // fivePlus
            // 
            this.fivePlus.Enabled = false;
            this.fivePlus.Image = global::ApplesNBugs.Properties.Resources.plusFive;
            this.fivePlus.Location = new System.Drawing.Point(442, 99);
            this.fivePlus.Name = "fivePlus";
            this.fivePlus.Size = new System.Drawing.Size(35, 30);
            this.fivePlus.TabIndex = 5;
            this.fivePlus.TabStop = false;
            this.fivePlus.Visible = false;
            // 
            // powerUpTimer
            // 
            this.powerUpTimer.Interval = 1000;
            this.powerUpTimer.Tick += new System.EventHandler(this.powerUpTimer_Tick);
            // 
            // StartTimer
            // 
            this.StartTimer.Enabled = true;
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // ApplesNbugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 685);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplesNbugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apples \'N Bugs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplesNbugs_FormClosing);
            this.Load += new System.EventHandler(this.ApplesNbugs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.screen.ResumeLayout(false);
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenzyPowerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePlus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameFlowTimer;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox Paused;
        private System.Windows.Forms.PictureBox fivePlus;
        private System.Windows.Forms.PictureBox frenzyPowerUp;
        private System.Windows.Forms.Timer powerUpTimer;
        private System.Windows.Forms.PictureBox CountDown;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.PictureBox SpeedUp;
        private System.Windows.Forms.Panel scorePanel;
    }
}

