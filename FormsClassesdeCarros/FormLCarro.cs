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
    public partial class FormLCarro : Form
    {
        public FormLCarro()
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
            gridCarroL.Columns.Add("Matrícula", "Matrícula");
            gridCarroL.Columns.Add("Marca", "Marca");
            gridCarroL.Columns.Add("Modelo", "Modelo");
            gridCarroL.Columns.Add("Estado", "Estado");
            gridCarroL.Columns.Add("Combustível", "Combustível");
            gridCarroL.Columns.Add("NumPortas", "NumPortas");
            gridCarroL.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroL.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroL.EnableHeadersVisualStyles = false;
            gridCarroL.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroL.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroL.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroL.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroL.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroL.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroL.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroL.ScrollBars = ScrollBars.Vertical;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCarroL.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;

                        if (carro.ClasseVeiculo == "L")
                        {
                            gridCarroL.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
