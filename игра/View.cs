using System.Drawing;
using System.Windows.Forms;

namespace игра
{   
    public partial class GameView : Form
    {
        private Player _player;
        private Background _bg1, _bg2;
        private ThePeak _peak1, _peak2, _doublePeak1, _doublePeak2;
        private Score _score;

        public GameView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
        }

        public void Draw(Player player, Background bg1, Background bg2, ThePeak peak1, ThePeak peak2, Score score, ThePeak doublePeak1, ThePeak doublePeak2) 
        {
            _player = player;
            _bg1 = bg1;
            _bg2 = bg2;
            _peak1 = peak1;
            _peak2 = peak2;
            _score = score;
            _doublePeak1 = doublePeak1;
            _doublePeak2 = doublePeak2;
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (_player != null  && _bg1 != null && _bg2 != null && _peak1 != null && _doublePeak1 != null && _doublePeak2 != null && _peak2 != null)
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

                g.DrawImage(_peak1.PeakImg, _peak1.X, _peak1.Y, _peak1.Size, _peak1.Size);

                g.DrawImage(_peak2.PeakImg, _peak2.X, _peak2.Y, _peak2.Size, _peak2.Size);

                g.DrawImage(_doublePeak1.PeakImg, _doublePeak1.X, _doublePeak1.Y, _doublePeak1.Size, _doublePeak1.Size);

                g.DrawImage(_doublePeak2.PeakImg, _doublePeak2.X, _doublePeak2.Y, _doublePeak2.Size, _doublePeak2.Size);  

                g.DrawString($"Счёт: {_score.Value}", new Font("Arial", 16), Brushes.White, 10, 10);
            }
        }
    }
}