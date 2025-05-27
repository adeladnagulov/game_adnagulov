using System;
using System.Drawing;
using System.Windows.Forms;

namespace игра
{
    public partial class Menu : Form
    {
        public int SelectedLevel = 1;
        public Menu()
        {
            this.ClientSize = new Size(800, 600);
            InitializeComponent();
        }

        private void ClickStart(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClickExit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
