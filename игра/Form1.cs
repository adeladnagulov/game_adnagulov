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
        Player player;

        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();

            backGround1.SendToBack();
            backGround2.SendToBack();
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
            player = new Player(77, 375);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(player.playerImg, player.x, player.y, player.size, player.size);
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 8;
            backGround1.Left -= speed;
            backGround2.Left -= speed;
            if (backGround2.Left <= 0)
            {
                backGround1.Left = 0;
                backGround2.Left = backGround1.Right;
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
    }
}
