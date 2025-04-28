using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 8;
            backGround1.Left -= speed;
            backGround2.Left -= speed;
            if (backGround2.Left <= 0)
            {
                backGround1.Left = 0;
                backGround2.Left = backGround1.Right;
            }
            int testGit = 0;
            int testGit1 = 0;
        }
    }
}
