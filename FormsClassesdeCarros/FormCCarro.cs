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
    public partial class FormCCarro : Form
    {
        public FormCCarro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroC.Columns.Add("Matrícula", "Matrícula");
            gridCarroC.Columns.Add("Marca", "Marca");
            gridCarroC.Columns.Add("Modelo", "Modelo");
            gridCarroC.Columns.Add("Estado", "Estado");
            gridCarroC.Columns.Add("Combustível", "Combustível");
            gridCarroC.Columns.Add("NumPortas", "NumPortas");
            gridCarroC.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroC.MultiSelect = false;
            gridCarroC.EnableHeadersVisualStyles = false;
            gridCarroC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "C")
                    {
                        gridCarroC.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
