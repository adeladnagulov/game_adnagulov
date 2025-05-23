using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    public class GameController
    {
        public GameController()
        {
            bg1 = new Background(0, 0);
            bg2 = new Background(bg1.Width, 0);
            player = new Player(77, 355);
            peak = new ThePeak(250, 465);
        }
    }
}
