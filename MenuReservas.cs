using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class MenuReservas : Form
    {
        public MenuReservas()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
