using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Player Player;
        private ThePeak Peak1;
        private ThePeak Peak2;
        private ThePeak DoublePeak1;
        private ThePeak DoublePeak2;
        private Background Bg1;
        private Background Bg2;
        private float floor;
        private Timer GameTimer;
        private Timer ScoreTimer;
        public Score Score;
        private int BackgroundSpeed = 5;
        public GameController()
        {
            Bg1 = new Background(0, 0);
            Bg2 = new Background(Bg1.Width, 0);
            Player = new Player(77, 355);
            Peak1 = new ThePeak(950, 465);
            Peak2 = new ThePeak(2400, 465);
            DoublePeak1 = new ThePeak(1650, 465);
            DoublePeak2 = new ThePeak(1700, 465);
            Score = new Score(0);  
            floor = 455f;

            GameTimer = new Timer();
            GameTimer.Interval = 15;
            GameTimer.Tick += new EventHandler(OnTimerTick);
            GameTimer.Start();

            ScoreTimer = new Timer();
            ScoreTimer.Interval = 300;
            ScoreTimer.Tick += (s, e) => Score.Value++;
            ScoreTimer.Start();

            Vieb = new GameView();
            Vieb.KeyPress += SpasePress;

            Vieb.Draw(Player, Bg1, Bg2, Peak1, Peak2, Score, DoublePeak1, DoublePeak2);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (Player.IsAlive)
            {
                Jump();
                BackgroundMovement();
                MovePeak();
                Vieb.Draw(Player, Bg1, Bg2, Peak1, Peak2, Score, DoublePeak1, DoublePeak2);
            }
            else
            {
                Vieb.Close();
            }
        }

        private void SpasePress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && !Player.IsJumping && Player.Y >= floor)
            {
                Player.IsJumping = true;
                Player.JumpSpeed = 4f;
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

        private void MovePeak()
        {
            Peak1.X -= BackgroundSpeed;
            DoublePeak1.X -= BackgroundSpeed;
            DoublePeak2.X -= BackgroundSpeed;
            Peak2.X -= BackgroundSpeed;
            CreateNewPeak();
            if (Collide(Player, Peak1) || Collide(Player, DoublePeak1) || Collide(Player, DoublePeak2) || Collide(Player, Peak2))
            { 
                Player.IsAlive = false;
            }
        }

        private bool Collide(Player player, ThePeak peak)
        {
            var delta = new PointF();
            delta.X = player.X - peak.X;
            delta.Y = player.Y - peak.Y;
            if(Math.Abs(delta.X) <= player.Size/2 + peak.Size/2 && Math.Abs(delta.Y) <= player.Size / 2 + peak.Size / 2)
            {
                Score.FinalValue = Score.Value;
                Score.Value = 0;
                return true;    
            }
            return false;
        }

        private void CreateNewPeak()
        {
            Random rnd = new Random();
            if (Peak1.X < Player.X - 800)
            {
                Peak1 = new ThePeak((int)(Player.X + 1000 + rnd.Next(-300, 300)), 465);
            }

            if (DoublePeak1.X < Player.X - 800)
            {
                DoublePeak1 = new ThePeak((int)(Player.X + 1000), 465);
            }

            if (DoublePeak2.X < Player.X - 800)
            {
                DoublePeak2 = new ThePeak((int)(Player.X + 1000), 465);
            }

            if (Peak2.X < Player.X - 800) 
            {
                Peak2 = new ThePeak((int)(Player.X + 1000 + rnd.Next(-300, 300)), 465);
            }
        }
    }
}
