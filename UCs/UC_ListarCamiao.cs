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
    public partial class UC_ListarCamiao : UserControl
    {
        public UC_ListarCamiao()
        {
            InitializeComponent();
        }

        public void showClass(string selectedButton)
        {
            ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["ListaVeiculo"];
            listaVeiculoObject.Enabled = false;
            switch (selectedButton)
            {
                case "ACamiao":
                    FormACamiao formACamiao = new FormACamiao();
                    formACamiao.Show();
                    break;
                case "BCamiao":
                    FormBCamiao formBCamiao = new FormBCamiao();
                    formBCamiao.Show();
                    break;
                case "CCamiao":
                    FormCCamiao formCCamiao = new FormCCamiao();
                    formCCamiao.Show();
                    break;
            }
        }

        private void ACamiao_Click(object sender, EventArgs e)
        {
            showClass("ACamiao");
        }

        private void BCamiao_Click(object sender, EventArgs e)
        {
            showClass("BCamiao");
        }

        private void CCamiao_Click(object sender, EventArgs e)
        {
            showClass("CCamiao");
        }

        private void PaintCamioes(object sender, PaintEventArgs e)
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
