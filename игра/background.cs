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
        public Image BackgroundImage { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; }
        public int Height { get; }

        public Background(int x, int y, int width, int height, string imagePath)
        {
            BackgroundImage = Image.FromFile(imagePath);
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
