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
    public partial class UC_ListarMota : UserControl
    {
        public UC_ListarMota()
        {
            InitializeComponent();
        }
        public void showClass(string selectedButton)
        {
            ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["ListaVeiculo"];
            listaVeiculoObject.Enabled = false;
            switch (selectedButton)
            {
                case "AMota":
                    FormAMota formAMota = new FormAMota();
                    formAMota.Show();
                    break;
                case "BMota":
                    FormBMota formBMota = new FormBMota();
                    formBMota.Show();
                    break;
                case "CMota":
                    FormCMota formCMota = new FormCMota();
                    formCMota.Show();
                    break;
            }
        }
        private void AMota_Click_1(object sender, EventArgs e)
        {
            showClass("AMota");
        }
        private void BMota_Click_1(object sender, EventArgs e)
        {
            showClass("BMota");
        }
        private void CMota_Click_1(object sender, EventArgs e)
        {
            showClass("CMota");
        }
        private void PaintMota(object sender, PaintEventArgs e)
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
