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
        int gravity;
        private Background bg1;
        private Background bg2;
        private readonly Timer GameTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            Init();
            Invalidate();

            /*
            initialTop = player.Top;
            Timer jumpTimer = new Timer();
            jumpTimer.Interval = 20;
            jumpTimer.Tick += JumpTimer_Tick;
            jumpTimer.Start();
            */
        }

        public void Init()
        {
            string bgPath = "C:\\Users\\adela\\OneDrive\\Desktop\\работы\\С шарп\\игра\\игра\\background.jpg";

            bg1 = new Background(0, 0, this.ClientSize.Width, this.ClientSize.Height, bgPath);
            bg2 = new Background(this.ClientSize.Width, 0, this.ClientSize.Width, this.ClientSize.Height, bgPath);
            player = new Player(77, 355);

            timer1.Interval = 30;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            if (player.Y < 455)
            {
                player.Y += player.GravityValue;
                Invalidate(); 
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                bg1.BackgroundImage,
                new Rectangle(bg1.X, bg1.Y, bg1.Width, bg1.Height),
                new Rectangle(0, 0, bg1.BackgroundImage.Width, bg1.BackgroundImage.Height),
                GraphicsUnit.Pixel);

            e.Graphics.DrawImage(
                bg2.BackgroundImage,
                new Rectangle(bg2.X, bg2.Y, bg2.Width, bg2.Height),
                new Rectangle(0, 0, bg2.BackgroundImage.Width, bg2.BackgroundImage.Height),
                GraphicsUnit.Pixel);

            e.Graphics.DrawImage(player.PlayerImg, player.X, player.Y, player.Size, player.Size);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 8;
            bg1.X -= speed;
            bg2.X -= speed;
            if (bg1.X <= bg1.Width)
            {
                bg1.X = 0;
                bg2.X = bg1.Width;
            }

            Invalidate();
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
    
