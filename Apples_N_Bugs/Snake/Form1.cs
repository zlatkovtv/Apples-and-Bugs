using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ApplesNBugs
{
    public partial class ApplesNbugs : Form
    {
        public static bool isHard;

        private bool left = false;
        private bool right = true;
        private bool up = false;
        private bool down = false;

        public static int score = 0;
        private bool isPaused;
        private bool isDead;
        private bool isFrenzied;
        private bool isSpeededUp;
        private int counter = 0;
        private int gameStartCounter = 3;
        //isStarting bool to check if StartTimer is active. If yes, then movement is disabled
        private bool isStarting = true;
        //apple and bug direction in hard mode
        private int appleDir;
        private int bugDir;

        List<PictureBox> bugs = new List<PictureBox>();
        Random rd = new Random();

        public void AppleMove()
        {
            //decide in which direction the apple should start moving
            appleDir = rd.Next(1, 5);
            bugDir = rd.Next(1, 5);
            apple.Left = rd.Next(0, screen.Size.Width - apple.Size.Width);
            apple.Top = rd.Next(0, screen.Size.Height - apple.Size.Height);
            //TODO if apple spawns in any of bugs or in the score label, move again
            // --> Think its working with double check, TEST SOME MORE
            foreach (var s in bugs)
            {
                while (((apple.Bounds.IntersectsWith(s.Bounds)) && (s.Visible == true)) || apple.Bounds.IntersectsWith(scoreLabel.Bounds))
                {
                    apple.Left = rd.Next(0, screen.Size.Width - apple.Size.Width);
                    apple.Top = rd.Next(0, screen.Size.Height - apple.Size.Height);
                }
            }

            //second while loop to check if apple has spawned in a bug for a second time. Dont think one is enough
            foreach (var s in bugs)
            {
                while (((apple.Bounds.IntersectsWith(s.Bounds)) && (s.Visible == true)) || apple.Bounds.IntersectsWith(scoreLabel.Bounds))
                {
                    apple.Left = rd.Next(0, screen.Size.Width - apple.Size.Width);
                    apple.Top = rd.Next(0, screen.Size.Height - apple.Size.Height);
                }
            }
        }

        //Dead message opener /new form
        public  void InitDead()
        {
            Application.Run(new Dead());
            isDead = true;
        }

        public ApplesNbugs()
        {
            InitializeComponent();
            //double buffer for smoother player movement
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.AllPaintingInWmPaint
                          , true);
        }

        private void GameFlowTimer_Tick(object sender, EventArgs e)
        {
            //score printer
            scoreLabel.Text = String.Format("Score: " + score);
            scoreLabel.BringToFront();
            Paused.BringToFront();

            //movement x3 and not whole two because transition doesnt work
            //&& teleport if out of border

            //flip player image direction with change of direction

            //speed is 3 ATM, 6 when frenzied
            if (left == true)
            {
                //sets either normal pic or frenzied pic for direction
                if (isFrenzied == true)
                {
                    player.Image = Properties.Resources.Frenzy;
                }
                else
                {
                    player.Image = Properties.Resources.Player;
                }

                if (player.Right == 0)
                {
                    player.Left = screen.Size.Width;
                }
                player.Left -= 1;
                if (player.Right == 0)
                {
                    player.Left = screen.Size.Width;
                }
                player.Left -= 1;
                if (player.Right == 0)
                {
                    player.Left = screen.Size.Width;
                }
                player.Left -= 1;

                if (isSpeededUp)
                {
                    if (player.Right == 0)
                    {
                        player.Left = screen.Size.Width;
                    }
                    player.Left -= 1;
                    if (player.Right == 0)
                    {
                        player.Left = screen.Size.Width;
                    }
                    player.Left -= 1;
                    if (player.Right == 0)
                    {
                        player.Left = screen.Size.Width;
                    }
                    player.Left -= 1;
                }
            }
            else if (up == true)
            {
                if (isFrenzied == true)
                {
                    player.Image = Properties.Resources.frenzyUp;
                }
                else
                {
                    player.Image = Properties.Resources.playerUp;
                }

                if (player.Bottom == 0)
                {
                    player.Top = screen.Size.Height;
                }
                player.Top -= 1;
                if (player.Bottom == 0)
                {
                    player.Top = screen.Size.Height;
                }
                player.Top -= 1;
                if (player.Bottom == 0)
                {
                    player.Top = screen.Size.Height;
                }
                player.Top -= 1;
                if (isSpeededUp)
                {
                    if (player.Bottom == 0)
                    {
                        player.Top = screen.Size.Height;
                    }
                    player.Top -= 1;
                    if (player.Bottom == 0)
                    {
                        player.Top = screen.Size.Height;
                    }
                    player.Top -= 1;
                    if (player.Bottom == 0)
                    {
                        player.Top = screen.Size.Height;
                    }
                    player.Top -= 1;
                }
            }
            else if (down == true)
            {
                if (isFrenzied == true)
                {
                    player.Image = Properties.Resources.frenzyDown;
                }
                else
                {
                    player.Image = Properties.Resources.playerDown;
                }

                if (player.Top == screen.Height)
                {
                    player.Top = 0 - player.Height;
                }
                player.Top += 1;
                if (player.Top == screen.Height)
                {
                    player.Top = 0 - player.Height;
                }
                player.Top += 1;
                if (player.Top == screen.Height)
                {
                    player.Top = 0 - player.Height;
                }
                player.Top += 1;
                if (isSpeededUp)
                {
                    if (player.Top == screen.Height)
                    {
                        player.Top = 0 - player.Height;
                    }
                    player.Top += 1;
                    if (player.Top == screen.Height)
                    {
                        player.Top = 0 - player.Height;
                    }
                    player.Top += 1;
                    if (player.Top == screen.Height)
                    {
                        player.Top = 0 - player.Height;
                    }
                    player.Top += 1;
                }
            }
            else if (right == true)
            {
                if (isFrenzied == true)
                {
                    player.Image = Properties.Resources.frenzyRight;
                }
                else
                {
                    player.Image = Properties.Resources.playerRight;
                }

                if (player.Left == screen.Size.Width)
                {
                    player.Left = 0 - player.Width;
                }
                player.Left += 1;
                if (player.Left == screen.Size.Width)
                {
                    player.Left = 0 - player.Width;
                }
                player.Left += 1;
                if (player.Left == screen.Size.Width)
                {
                    player.Left = 0 - player.Width;
                }
                player.Left += 1;
                if (isSpeededUp)
                {
                    if (player.Left == screen.Size.Width)
                    {
                        player.Left = 0 - player.Width;
                    }
                    player.Left += 1;
                    if (player.Left == screen.Size.Width)
                    {
                        player.Left = 0 - player.Width;
                    }
                    player.Left += 1;
                    if (player.Left == screen.Size.Width)
                    {
                        player.Left = 0 - player.Width;
                    }
                    player.Left += 1;
                }
            }

            //in hard mode apple and bugs moves in random directions
            //apple speed is 3 ATM
            if (isHard && !isDead)
            {
                if (appleDir == 1)
                {
                    if (apple.Right == 0)
                    {
                        apple.Left = screen.Size.Width;
                    }
                    apple.Left -= 1;
                    if (apple.Right == 0)
                    {
                        apple.Left = screen.Size.Width;
                    }
                    apple.Left -= 1;
                    if (apple.Right == 0)
                    {
                        apple.Left = screen.Size.Width;
                    }
                    apple.Left -= 1;
                }
                else if (appleDir == 2)
                {
                    if (apple.Bottom == 0)
                    {
                        apple.Top = screen.Size.Height;
                    }
                    apple.Top -= 1;
                    if (apple.Bottom == 0)
                    {
                        apple.Top = screen.Size.Height;
                    }
                    apple.Top -= 1;
                    if (apple.Bottom == 0)
                    {
                        apple.Top = screen.Size.Height;
                    }
                    apple.Top -= 1;
                }
                else if (appleDir == 3)
                {
                    if (apple.Top == screen.Height)
                    {
                        apple.Top = 0 - apple.Height;
                    }
                    apple.Top += 1;
                    if (apple.Top == screen.Height)
                    {
                        apple.Top = 0 - apple.Height;
                    }
                    apple.Top += 1;
                    if (apple.Top == screen.Height)
                    {
                        apple.Top = 0 - apple.Height;
                    }
                    apple.Top += 1;
                }
                else if (appleDir == 4)
                {
                    if (apple.Left == screen.Size.Width)
                    {
                        apple.Left = 0 - apple.Width;
                    }
                    apple.Left += 1;
                    if (apple.Left == screen.Size.Width)
                    {
                        apple.Left = 0 - apple.Width;
                    }
                    apple.Left += 1;
                    if (apple.Left == screen.Size.Width)
                    {
                        apple.Left = 0 - apple.Width;
                    }
                    apple.Left += 1;
                }

                //bugs are moving randomly in hard mode
                foreach (var s in bugs)
                {
                    if (bugDir == 4)
                    {
                        if (s.Right == 0)
                        {
                            s.Left = screen.Size.Width;
                        }
                        s.Left -= 1;
                    }
                    else if (bugDir == 1)
                    {
                        if (s.Bottom == 0)
                        {
                            s.Top = screen.Size.Height;
                        }
                        s.Top -= 1;
                    }
                    else if (bugDir == 2)
                    {
                        if (s.Top == screen.Height)
                        {
                            s.Top = 0 - s.Height;
                        }
                        s.Top += 1;
                    }
                    else if (bugDir == 3)
                    {
                        if (s.Left == screen.Size.Width)
                        {
                            s.Left = 0 - s.Width;
                        }
                        s.Left += 1;
                    }
                }
            }

            //in normal mode spawns a randomly moving bug every 10th 
            if (!isHard && !isDead)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (bugs.Count >= 10 * i)
                    {
                        if (bugDir == 4)
                        {
                            if (bugs[10 * i - 1].Right == 0)
                            {
                                bugs[10 * i - 1].Left = screen.Size.Width;
                            }
                            bugs[10 * i - 1].Left -= 1;
                        }
                        else if (bugDir == 1)
                        {
                            if (bugs[10 * i - 1].Bottom == 0)
                            {
                                bugs[10 * i - 1].Top = screen.Size.Height;
                            }
                            bugs[10 * i - 1].Top -= 1;
                        }
                        else if (bugDir == 2)
                        {
                            if (bugs[10 * i - 1].Top == screen.Height)
                            {
                                bugs[10 * i - 1].Top = 0 - bugs[10 * i - 1].Height;
                            }
                            bugs[10 * i - 1].Top += 1;
                        }
                        else if (bugDir == 3)
                        {
                            if (bugs[10 * i - 1].Left == screen.Size.Width)
                            {
                                bugs[10 * i - 1].Left = 0 - bugs[10 * i - 1].Width;
                            }
                            bugs[10 * i - 1].Left += 1;
                        }
                    }
                }
            }

            //player collides with apple
            if (player.Bounds.IntersectsWith(apple.Bounds))
            {
                AppleMove();

                //score setter
                score++;

                //bug spawner
                bugs.Add(new PictureBox());
                //doesnt work
                bugs[bugs.Count - 1].Parent = screen;
                bugs[bugs.Count - 1].Image = Properties.Resources.Bug;
                bugs[bugs.Count - 1].BackColor = Color.Transparent;
                bugs[bugs.Count - 1].Width = 20;
                bugs[bugs.Count - 1].Height = 20;

                //bugs cant spawn in player, bugs spawn in opposite side of player location

                if (player.Left >= (screen.Width / 2))
                {
                    bugs[bugs.Count - 1].Left = rd.Next(0, screen.Width / 2);
                    bugs[bugs.Count - 1].Top = rd.Next(0, screen.Size.Height - bugs[bugs.Count - 1].Size.Height);
                }
                else if ((player.Left + player.Width) < (screen.Width / 2))
                {
                    bugs[bugs.Count - 1].Left = rd.Next(screen.Width / 2, screen.Size.Width - bugs[bugs.Count - 1].Size.Width);
                    bugs[bugs.Count - 1].Top = rd.Next(0, screen.Size.Height - bugs[bugs.Count - 1].Size.Height);
                }

                //bugs cant spawn in eachother or in score label --> FREEZES FROM TIME TO TIME, TEST AGAIN
                if (bugs.Count > 1)
                {
                    for (int i = 0; i < bugs.Count - 1; i++)
                    {
                        while (((bugs[bugs.Count - 1].Bounds.IntersectsWith(bugs[i].Bounds)) && (bugs[i].Visible == true)) || bugs[bugs.Count - 1].Bounds.IntersectsWith(scoreLabel.Bounds))
                        {
                            if (bugs[bugs.Count - 1].Left >= (screen.Width / 2))
                            {
                                bugs[bugs.Count - 1].Left = rd.Next(screen.Width / 2, screen.Size.Width - bugs[bugs.Count - 1].Size.Width);
                                bugs[bugs.Count - 1].Top = rd.Next(0, screen.Size.Height - bugs[bugs.Count - 1].Size.Height);
                            }
                            else if ((bugs[bugs.Count - 1].Left + bugs[bugs.Count - 1].Width) < (screen.Width / 2))
                            {
                                bugs[bugs.Count - 1].Left = rd.Next(0, screen.Width / 2);
                                bugs[bugs.Count - 1].Top = rd.Next(0, screen.Size.Height - bugs[bugs.Count - 1].Size.Height);
                            }
                        }
                    }
                }

                //brings bugs on top, but not on top of scorePanel
                bugs[bugs.Count - 1].BringToFront();
                scorePanel.BringToFront();

                int percentage = rd.Next(0, 101);

                //only spawn buffs if other buffs dont exist

                //spawn +5 has a 10% chance
                if (percentage > 90)
                {
                    if ((fivePlus.Enabled == false) && (frenzyPowerUp.Enabled == false) && (SpeedUp.Enabled == false))
                    {
                        fivePlus.Left = rd.Next(0, screen.Size.Width - fivePlus.Size.Width);
                        fivePlus.Top = rd.Next(0, screen.Size.Height - fivePlus.Size.Height);

                        foreach (var s in bugs)
                        {
                            while ((fivePlus.Bounds.IntersectsWith(s.Bounds)) && (s.Visible == true))
                            {
                                fivePlus.Left = rd.Next(0, screen.Size.Width - fivePlus.Size.Width);
                                fivePlus.Top = rd.Next(0, screen.Size.Height - fivePlus.Size.Height);
                            }
                        }

                        fivePlus.Visible = true;
                        fivePlus.Enabled = true;
                    }
                }
                //spawn frenzy has a 10% chance
                else if ((percentage <= 90) && (percentage > 80))
                {
                    if ((fivePlus.Enabled == false) && (frenzyPowerUp.Enabled == false) && (SpeedUp.Enabled == false))
                    {

                        frenzyPowerUp.Left = rd.Next(0, screen.Size.Width - frenzyPowerUp.Size.Width);
                        frenzyPowerUp.Top = rd.Next(0, screen.Size.Height - frenzyPowerUp.Size.Height);

                        foreach (var s in bugs)
                        {
                            while ((frenzyPowerUp.Bounds.IntersectsWith(s.Bounds)) && (s.Visible == true))
                            {
                                frenzyPowerUp.Left = rd.Next(0, screen.Size.Width - frenzyPowerUp.Size.Width);
                                frenzyPowerUp.Top = rd.Next(0, screen.Size.Height - frenzyPowerUp.Size.Height);
                            }
                        }

                        frenzyPowerUp.Visible = true;
                        frenzyPowerUp.Enabled = true;
                    }
                }
                //spawns speed up with a 10% probability
                else if ((percentage <= 80) && (percentage > 70))
                {
                    if ((fivePlus.Enabled == false) && (frenzyPowerUp.Enabled == false) && (SpeedUp.Enabled == false))
                    {
                        SpeedUp.Left = rd.Next(0, screen.Size.Width - SpeedUp.Size.Width);
                        SpeedUp.Top = rd.Next(0, screen.Size.Height - SpeedUp.Size.Height);

                        foreach (var s in bugs)
                        {
                            while ((SpeedUp.Bounds.IntersectsWith(s.Bounds)) && (s.Visible == true))
                            {
                                SpeedUp.Left = rd.Next(0, screen.Size.Width - SpeedUp.Size.Width);
                                SpeedUp.Top = rd.Next(0, screen.Size.Height - SpeedUp.Size.Height);
                            }
                        }

                        SpeedUp.Visible = true;
                        SpeedUp.Enabled = true;
                    }
                }
            }

            //player collides with visible of bugs when not frenzied
            foreach (var s in bugs)
            {
                if ((player.Bounds.IntersectsWith(s.Bounds)) && !isDead && (s.Visible == true))
                {
                    if (isFrenzied == false)
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(InitDead));
                        GameFlowTimer.Enabled = false;
                        isDead = true;
                        left = false;
                        up = false;
                        down = false;
                        right = false;
                        t.Start();
                    }
                        //if player is frenzied , destroy bugs touched
                    else
                    {
                        this.Controls.Remove(s);
                        s.Visible = false;
                    }
                }
            }

            //player collides with plusFive powerup
            if (fivePlus.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(fivePlus.Bounds))
                {
                    score += 5;
                    //remove powerup picturebox on collision
                    fivePlus.Enabled = false;
                    fivePlus.Visible = false;
                }
            }
            //player collides with frenzy powerup
            else if (frenzyPowerUp.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(frenzyPowerUp.Bounds))
                {
                    //remove powerup picturebox on collision
                    frenzyPowerUp.Enabled = false;
                    frenzyPowerUp.Visible = false;

                    isFrenzied = true;

                    //start timer for 3 seconds and remove buff
                    powerUpTimer.Interval = 1000;
                    CountDown.Visible = true;
                    CountDown.Image = Properties.Resources.Three;
                    counter = 3;
                    powerUpTimer.Enabled = true;
                }
            }
            //player collides with speed up powerup
            else if (SpeedUp.Enabled == true)
            {
                if (player.Bounds.IntersectsWith(SpeedUp.Bounds))
                {
                    SpeedUp.Enabled = false;
                    SpeedUp.Visible = false;

                    isSpeededUp = true;

                    //start timer for 3 seconds and remove buff
                    powerUpTimer.Interval = 1000;
                    CountDown.Visible = true;
                    CountDown.Image = Properties.Resources.Three;
                    counter = 3;
                    powerUpTimer.Enabled = true;
                }
            }
            
            //DONT THINK I NEED IT AFTER LAST PATCH WHERE EVERYTHING CANT SPAWN IN ANYTHING

            //apple.BringToFront(); // ------> doesnt work, apple is beneath bugs
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //cant do anything while game is starting, only pause
            if (!isStarting)
            {
                if ((!isPaused) && (!isDead))
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        right = false;
                        up = false;
                        down = false;
                        left = true;
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        left = false;
                        up = false;
                        down = false;
                        right = true;
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        left = false;
                        right = false;
                        down = false;
                        up = true;
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        left = false;
                        right = false;
                        up = false;
                        down = true;
                    }
                }
                //pause, arrow buttons and collision only enabled when player is alive and is not collided. Otherwise game stops all functions
                if (!isDead)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        isPaused = !(isPaused);
                    }
                }

                if (isPaused)
                {
                    powerUpTimer.Enabled = false;
                    GameFlowTimer.Enabled = false;
                    Paused.Visible = true;
                }
                else
                {
                    GameFlowTimer.Enabled = true;
                    powerUpTimer.Enabled = true;
                    Paused.Visible = false;
                }
            }
            //handles pause in game start time
            else
            {
                if (!isDead)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        StartTimer.Enabled = !StartTimer.Enabled;
                        Paused.Visible = !Paused.Visible;
                    }
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void ApplesNbugs_Load(object sender, EventArgs e)
        {
            //sets form icon
            this.Icon = Properties.Resources.Icon;

            //adds scorePanel to ApplesNBugs control
            this.Controls.Add(scorePanel);

            //sets initial apple coordinates
            apple.Left = rd.Next(screen.Width / 2, screen.Size.Width - apple.Size.Width);
            apple.Top = rd.Next(0, screen.Size.Height - apple.Size.Height);

            //sets initial apple direction in hard mode
            appleDir = rd.Next(1, 5);
            bugDir = rd.Next(1, 5);

            //BOLD score label and paused label
            scoreLabel.Font = new Font(scoreLabel.Font, FontStyle.Bold);
        }

        private void apple_Click(object sender, EventArgs e)
        {

        }

        private void ApplesNbugs_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void powerUpTimer_Tick(object sender, EventArgs e)
        {
            //waits 3 seconds, disables Timer and turns off frenzy buff
            if (isFrenzied)
            {
                counter--;
                switch (counter)
                {
                    case 0:
                        isFrenzied = false;
                        powerUpTimer.Enabled = false;
                        CountDown.Visible = false;
                        break;
                    case 1:
                        CountDown.Image = Properties.Resources.One;
                        break;
                    case 2:
                        CountDown.Image = Properties.Resources.Two;
                        break;
                    case 3:
                        CountDown.Image = Properties.Resources.Three;
                        break;
                    default:
                        break;
                }
            }
            //waits 3 seconds, disables Timer and turns off speed up buff
            else if (isSpeededUp)
            {
                counter--;
                switch (counter)
                {
                    case 0:
                        isSpeededUp = false;
                        powerUpTimer.Enabled = false;
                        CountDown.Visible = false;
                        break;
                    case 1:
                        CountDown.Image = Properties.Resources.One;
                        break;
                    case 2:
                        CountDown.Image = Properties.Resources.Two;
                        break;
                    case 3:
                        CountDown.Image = Properties.Resources.Three;
                        break;
                    default:
                        break;
                }
            }
            
        }

        //timer that holds 3 seconds before game starts
        private void StartTimer_Tick(object sender, EventArgs e)
        {
            gameStartCounter--;
            switch (gameStartCounter)
            {
                case 0:
                    isStarting = false;
                    CountDown.Visible = false;
                    GameFlowTimer.Enabled = true;
                    StartTimer.Enabled = false;
                    break;
                case 1:
                    CountDown.Image = Properties.Resources.One;
                    break;
                case 2:
                    CountDown.Image = Properties.Resources.Two;
                    break;
                case 3:
                    CountDown.Image = Properties.Resources.Three;
                    break;
                default:
                    break;
            }
        }
    }
}
