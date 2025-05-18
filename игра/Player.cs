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
        public int x;
        public int y;
        public int size;
        public Image playerImg;

        public Player(int x, int y)
        {
            playerImg = new Bitmap("C:\\Users\\adela\\OneDrive\\Desktop\\работы\\С шарп\\игра\\игра\\player.png");
            this.x = x;
            this.y = y;
            size = 50;
        }
    }
}
