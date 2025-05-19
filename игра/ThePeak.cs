using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    internal class ThePeak
    {
        public float X;
        public float Y;
        public int Size;
        public Image PeakImg;

        public ThePeak(int x, int y)
        {
            PeakImg = new Bitmap("C:\\Users\\adela\\OneDrive\\Desktop\\работы\\С шарп\\игра\\игра\\R.png");
            this.X = x;
            this.Y = y;
            Size = 50;
        }
    }
}
