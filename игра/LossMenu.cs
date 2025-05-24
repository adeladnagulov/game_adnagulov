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
    public partial class LossMenu : Form
    {
        public int FinalScore;
        public LossMenu(int finalScore)
        {
            this.ClientSize = new Size(800, 600);
            InitializeComponent();
            this.FinalScore = finalScore;
            TakeResult(finalScore);
        }

        public void TakeResult(int finalScore)
        {

            var scoreLabel = new Label
            {
                Text = $"Ваш счет: {finalScore}",
                Font = new Font("Arial", 20),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(120, 150)
            };
            this.Controls.Add(scoreLabel);
        }

        private void ClickRepeat(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClickGoMenu(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
