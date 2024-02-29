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
    public partial class FormHCarro : Form
    {
        public FormHCarro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            Dock = DockStyle.Fill;
            gridCarroH.Columns.Add("Matrícula", "Matrícula");
            gridCarroH.Columns.Add("Marca", "Marca");
            gridCarroH.Columns.Add("Modelo", "Modelo");
            gridCarroH.Columns.Add("Estado", "Estado");
            gridCarroH.Columns.Add("Combustível", "Combustível");
            gridCarroH.Columns.Add("NumPortas", "NumPortas");
            gridCarroH.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroH.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroH.EnableHeadersVisualStyles = false;
            gridCarroH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.ScrollBars = ScrollBars.Vertical;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCarroH.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;

                        if (carro.ClasseVeiculo == "H")
                        {
                            gridCarroH.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                        }
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
