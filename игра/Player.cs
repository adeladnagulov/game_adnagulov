using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace игра
{
    internal class Player
    {
        public int X;
        public int Y;
        public int Size;
        public Image PlayerImg;
        public int GravityValue;

        public Player(int x, int y)
        {
            PlayerImg = new Bitmap("C:\\Users\\adela\\OneDrive\\Desktop\\работы\\С шарп\\игра\\игра\\player.png");
            this.X = x;
            this.Y = y;
            Size = 60;
            GravityValue = 4;
        }
    }
}
