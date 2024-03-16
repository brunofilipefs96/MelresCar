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
    public partial class LucroDatas : Form
    {
        public LucroDatas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = false;
            dataInicio.Date = Program.DataHoraDoSistema().Date;
            dataFim.Date = Program.DataHoraDoSistema().Date;
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.ucReservas.atualizaDataGridView();
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            labelLucro.Visible = true;
            decimal lucroTotal = 0;
            if (dataFim.Date < dataInicio.Date)
            {
                MessageBox.Show("A data Final deve ser superior à Data Inicial!");
            }
            else
            {
                DateTime dataDias = dataInicio.Date;

                while (dataDias <= dataFim.Date)
                {
                    foreach (var reserva in Program.melresCar.Reservas)
                    {
                        if (reserva.DataInicio.Date <= dataDias && reserva.DataFim.Date >= dataDias)
                        {
                            lucroTotal += reserva.PrecoTotal;
                        }
                    }

                    dataDias = dataDias.AddDays(1);
                }
            }
            labelLucro.Text = string.Format("{0:#,0.00}", lucroTotal);
        }

        private void PaintLucroDatas(object sender, PaintEventArgs e)
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
