using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class UC_MenuPrincipal : UserControl
    {
        public UC_MenuPrincipal()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void PaintMenuprincipal(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96,155,173),1);

            Rectangle area = new Rectangle(0, 0, this.Width -1, this.Height -1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96,155,173), Color.FromArgb(245,251,251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
