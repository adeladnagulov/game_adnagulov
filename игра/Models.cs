using System.Drawing;

namespace игра
{
    public class Player
    {
        public float X;
        public float Y;
        public int Size;
         public Image PlayerImg;
        public float GravityValue;
        public float JumpSpeed;
        public float FallSpeed;
        public bool IsJumping;
        public bool IsAlive;

        public Player(int x, int y)
        {
            PlayerImg = new Bitmap("player.png");
            this.X = x;
            this.Y = y;
            Size = 60;
            GravityValue = 0.1f;
            IsJumping = false;
            JumpSpeed = 0;
            FallSpeed = 0;
            IsAlive = true;
        }
    }
                
    public class Background
    {
        public Image BackgroundImage;
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public Background(int x, int y)
        {
            BackgroundImage = Image.FromFile("background.jpg");
            this.X = x;
            this.Y = y;
            Width = 800;
            Height = 600;
        }
    }

    public class ThePeak
    {
        public float X;
        public float Y;
        public int Size;
        public Image PeakImg;

        public ThePeak(int x, int y)
        {
            PeakImg = new Bitmap("Peak.png");
            this.X = x; 
            this.Y = y;
            Size = 50;
        }
    }

    public class Score 
    {
        public int Value;
        public int FinalValue;

        public Score(int value)
        {
            Value = value;
            FinalValue = 0;
        }
    }
}
