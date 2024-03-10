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
    public partial class UC_ListarCamioneta : UserControl
    {
        public UC_ListarCamioneta()
        {
            InitializeComponent();
        }

        public void showClass(string selectedButton)
        {
            ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["ListaVeiculo"];
            listaVeiculoObject.Enabled = false;
            switch (selectedButton)
            {
                case "ACamioneta":
                    FormACamioneta formACamioneta = new FormACamioneta();
                    formACamioneta.Show();
                    break;
                case "BCamioneta":
                    FormBCamioneta formBCamioneta = new FormBCamioneta();
                    formBCamioneta.Show();
                    break;
                case "CCamioneta":
                    FormCCamioneta formCCamioneta = new FormCCamioneta();
                    formCCamioneta.Show();
                    break;
            }
        }

        private void ACamioneta_Click(object sender, EventArgs e)
        {
            showClass("ACamioneta");
        }

        private void BCamioneta_Click(object sender, EventArgs e)
        {
            showClass("BCamioneta");
        }

        private void CCamioneta_Click(object sender, EventArgs e)
        {
            showClass("CCamioneta");
        }

        private void PaintCamionetas(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
