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
        float gravity;
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

            gravity = 0;

            timer1.Interval = 15;
            timer1.Tick += new EventHandler(update);
            timer1.Start();

            timer2.Interval = 15;
            timer2.Tick += new EventHandler(go);
            timer2.Start();
        }

        private void go(object sender, EventArgs e)
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

        private void update(object sender, EventArgs e)
        {
            if (player.Y < 455)
            {
                gravity += player.GravityValue;
                player.Y += gravity;

                Invalidate(); 
            }
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

            //if (e.KeyChar == (char)Keys.Space && !isJumping && player.Top == initialTop)
            //{
            //   isJumping = true;
            //}
        }
    }
}

        /*
              private bool isJumping = false;
              private int jumpSpeed = 15;
              private int gravity = 8;
              private int jumpHeight = 150;
              private int initialTop;

private void JumpTimer_Tick(object sender, EventArgs e)
{
   if (isJumping)
   {
       player.Top -= jumpSpeed;
       if (player.Top <= initialTop - jumpHeight)
       {
           isJumping = false;
       }
   }
   else if (player.Top < initialTop)
   {
       player.Top += gravity;
       if (player.Top > initialTop)
       {
           player.Top = initialTop;
       }
   }
}
}
*/
    
