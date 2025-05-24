using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            while (true)
            {
                if (new Menu().ShowDialog() != DialogResult.OK)
                    break;

                bool restart;
                do
                {
                    restart = false;
                    var game = new GameController();
                    using (game.Vieb)
                    {
                        Application.Run(game.Vieb);
                        if (!game.Player.IsAlive)
                            restart = new LossMenu(game.Score.FinalValue).ShowDialog() == DialogResult.OK;
                    }
                } while (restart);
            }
        }
    }
}
