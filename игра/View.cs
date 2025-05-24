using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace игра
{
    public partial class GameView : Form
    {
        private Player _player;
        private Background _bg1, _bg2;
        private ThePeak _peak;

        public GameView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
        }

        public void Draw(Player player, Background bg1, Background bg2, ThePeak peak) 
        {
            _player = player;
            _bg1 = bg1;
            _bg2 = bg2;
            _peak = peak;
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (_player != null  && _bg1 != null && _bg2 != null && _peak != null)
            {
                Graphics g = e.Graphics;
                g.DrawImage(
                    _bg1.BackgroundImage,
                    new Rectangle(_bg1.X, _bg1.Y, _bg1.Width, _bg1.Height),
                    new Rectangle(0, 0, _bg1.BackgroundImage.Width, _bg1.BackgroundImage.Height),
                    GraphicsUnit.Pixel);

                g.DrawImage(
                    _bg2.BackgroundImage,
                    new Rectangle(_bg2.X, _bg2.Y, _bg2.Width, _bg2.Height),
                    new Rectangle(0, 0, _bg2.BackgroundImage.Width, _bg2.BackgroundImage.Height),
                    GraphicsUnit.Pixel);

                g.DrawImage(_player.PlayerImg, _player.X, _player.Y, _player.Size, _player.Size);

                g.DrawImage(_peak.PeakImg, _peak.X, _peak.Y, _peak.Size, _peak.Size);
            }
        }
    }
}
    
/*
 * 2.2 бесконечный уровень
 * 3 блоки
 * 4 ракета
 * 6 счетчик
 */