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
    public partial class Menu : Form
    {
        public Menu()
        {
            this.ClientSize = new Size(800, 600);
            Init();
            InitializeComponent();
        }

        private void Init()
        {
            var title = new Label
            {
                Text = "Кубические приключения",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Top = 20,
                Left = (this.ClientSize.Width - 300) / 2
            };
        }
    }
}
