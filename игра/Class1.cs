using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    internal class Class1 
    {
        private bool isJumping = false;
        private int jumpSpeed = 15;
        private int jumpHeight = 150;
        private int initialTop;
        private int gravity = 8;

        public void JumpTimer_Tick(object sender, EventArgs e)
        {
            if (isJumping)
            {
                player.Top -= jumpSpeed;
                if (player.Top <= initialTop - jumpHeight)
                {
                    isJumping = false;
                }
            }
            else if (player.Top < initialTop)
            {
                player.Top += gravity;
                if (player.Top > initialTop)
                {
                    player.Top = initialTop;
                }
            }
        }
    }

}
