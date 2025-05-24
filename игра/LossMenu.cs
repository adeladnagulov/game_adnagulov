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
        public LossMenu()
        {
            this.ClientSize = new Size(800, 600);
            InitializeComponent();
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
