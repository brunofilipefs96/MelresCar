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
    public partial class FormFCarro : Form
    {
        public FormFCarro()
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
            gridCarroF.Columns.Add("Matrícula", "Matrícula");
            gridCarroF.Columns.Add("Marca", "Marca");
            gridCarroF.Columns.Add("Modelo", "Modelo");
            gridCarroF.Columns.Add("Estado", "Estado");
            gridCarroF.Columns.Add("Combustível", "Combustível");
            gridCarroF.Columns.Add("NumPortas", "NumPortas");
            gridCarroF.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroF.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroF.EnableHeadersVisualStyles = false;
            gridCarroF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroF.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroF.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroF.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroF.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroF.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroF.ScrollBars = ScrollBars.Vertical;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCarroF.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;

                        if (carro.ClasseVeiculo == "F")
                        {
                            gridCarroF.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
