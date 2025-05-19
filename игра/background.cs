using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    internal class Background
    {
        public Image BackgroundImage;
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public Background(int x, int y)
        {
            BackgroundImage = Image.FromFile("C:\\Users\\adela\\OneDrive\\Desktop\\работы\\С шарп\\игра\\игра\\background.jpg");
            this.X = x;
            this.Y = y;
            Width = 800;
            Height = 600;
        }
    }
}
