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
    public partial class FormBCarro : Form
    {
        public FormBCarro()
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
            gridCarroB.Columns.Add("Matrícula", "Matrícula");
            gridCarroB.Columns.Add("Marca", "Marca");
            gridCarroB.Columns.Add("Modelo", "Modelo");
            gridCarroB.Columns.Add("Estado", "Estado");
            gridCarroB.Columns.Add("Combustível", "Combustível");
            gridCarroB.Columns.Add("NumPortas", "NumPortas");
            gridCarroB.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroB.EnableHeadersVisualStyles = false;
            gridCarroB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.ScrollBars = ScrollBars.Vertical;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCarroB.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;

                        if (carro.ClasseVeiculo == "B")
                        {
                            gridCarroB.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
