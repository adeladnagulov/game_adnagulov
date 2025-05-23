using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace игра
{
    public class GameController
    {
        public GameView Vieb;
        private Player Player;
        private ThePeak Peak;
        private Background Bg1;
        private Background Bg2;
        private float floor;
        private Timer GameTimer;
        private int BackgroundSpeed = 8;
        public GameController()
        {
            Bg1 = new Background(0, 0);
            Bg2 = new Background(Bg1.Width, 0);
            Player = new Player(77, 355);
            Peak = new ThePeak(250, 465);
            floor = 455f;

            GameTimer = new Timer();
            GameTimer.Interval = 15;
            GameTimer.Tick += new EventHandler(OnTimerTick);
            GameTimer.Start();

            Vieb = new GameView();
            Vieb.KeyPress += SpasePress;

            Vieb.Draw(Player, Bg1, Bg2, Peak);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            Jump();
            BackgroundMovement();
            Vieb.Draw(Player, Bg1, Bg2, Peak);
        }

        private void SpasePress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && !Player.IsJumping && Player.Y >= floor)
            {
                Player.IsJumping = true;
                Player.JumpSpeed = 5f;
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                Vieb.Close();
            }
        }

        private void Jump()
        {
            if (Player.IsJumping)
            {
                Player.Y -= Player.JumpSpeed;
                Player.JumpSpeed -= Player.GravityValue;

                if (Player.JumpSpeed <= 0)
                {
                    Player.IsJumping = false;
                    Player.FallSpeed = 0;
                }
            }
            else if (Player.Y < floor)
            {
                Player.FallSpeed += Player.GravityValue;
                Player.Y += Player.FallSpeed;

                if (Player.Y >= floor)
                {
                    Player.Y = floor;
                    Player.FallSpeed = 0;
                }
            }
        }

        private void BackgroundMovement()
        {
            Bg1.X -= BackgroundSpeed;
            Bg2.X -= BackgroundSpeed;
            if (Bg1.X <= -Bg1.Width)
            {
                Bg1.X = 0;
                Bg2.X = Bg1.Width;
            }
        }
    }
}
