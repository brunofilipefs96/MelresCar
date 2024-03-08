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
    public partial class LucroDatas : Form
    {
        public LucroDatas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.ucReservas.atualizaDataGridView();
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
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
            labelLucro.Text = lucroTotal.ToString();    
        }
    }
}
