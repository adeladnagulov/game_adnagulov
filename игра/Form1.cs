using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace игра
{
    public partial class Form1 : Form
    {
        private Player player;
        private ThePeak peak;
        private float floor;
        private Background bg1;
        private Background bg2;

        private readonly Timer GameTimer = new Timer();
        private readonly Timer BackgroundTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            Init();
            Invalidate();
        }

        public void Init()
        {
            bg1 = new Background(0, 0);
            bg2 = new Background(bg1.Width, 0);
            player = new Player(77, 355);
            peak = new ThePeak(250, 465);

            floor = 455f;

            backgroundTimer.Interval = 15;
            backgroundTimer.Tick += new EventHandler(Go);
            backgroundTimer.Start();

            jumpTimer.Interval = 15;
            jumpTimer.Tick += new EventHandler(Jump);
            jumpTimer.Start();
        }

        private void Jump(object sender, EventArgs e)
        {
            if (player.IsJumping)
            {
                player.Y -= player.JumpSpeed;
                player.JumpSpeed -= player.GravityValue;

                if (player.JumpSpeed <= 0)
                {
                    player.IsJumping = false;
                    player.FallSpeed = 0;
                }
            }
            else if (player.Y < floor)
            {
                player.FallSpeed += player.GravityValue;
                player.Y += player.FallSpeed;

                if (player.Y >= floor)
                {
                    player.Y = floor;
                    player.FallSpeed = 0;
                }
            }
        }

        private void Go(object sender, EventArgs e)
        {
            int speed = 8;
            bg1.X -= speed;
            bg2.X -= speed;
            if (bg1.X <= -bg1.Width)
            {
                bg1.X = 0;
                bg2.X = bg1.Width;
            }

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(
                bg1.BackgroundImage,
                new Rectangle(bg1.X, bg1.Y, bg1.Width, bg1.Height),
                new Rectangle(0, 0, bg1.BackgroundImage.Width, bg1.BackgroundImage.Height),
                GraphicsUnit.Pixel);

            g.DrawImage(
                bg2.BackgroundImage,
                new Rectangle(bg2.X, bg2.Y, bg2.Width, bg2.Height),
                new Rectangle(0, 0, bg2.BackgroundImage.Width, bg2.BackgroundImage.Height),
                GraphicsUnit.Pixel);

            g.DrawImage(player.PlayerImg, player.X, player.Y, player.Size, player.Size);

            g.DrawImage(peak.PeakImg, peak.X, peak.Y, peak.Size, peak.Size);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyChar == (char)Keys.Space && !player.IsJumping && player.Y >= floor)
            {
                player.IsJumping = true;
                player.JumpSpeed = 5f;
            }
        }
    }
}
    
