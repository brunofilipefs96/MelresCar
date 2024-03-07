using Automobile.Forms;
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
    public partial class FormGCarro : Form
    {
        public FormGCarro()
        {
            InitializeComponent();
            gridCarroG.AllowUserToAddRows = false;
            gridCarroG.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroG.Columns.Add("ID", "ID");
            gridCarroG.Columns.Add("Matrícula", "Matrícula");
            gridCarroG.Columns.Add("Marca", "Marca");
            gridCarroG.Columns.Add("Modelo", "Modelo");
            gridCarroG.Columns.Add("Estado", "Estado");
            gridCarroG.Columns.Add("Combustível", "Combustível");
            gridCarroG.Columns.Add("NumPortas", "NumPortas");
            gridCarroG.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroG.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroG.MultiSelect = false;
            gridCarroG.EnableHeadersVisualStyles = false;
            gridCarroG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroG.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroG.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroG.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroG.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroG.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroG.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "G")
                    {
                        gridCarroG.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCarroG.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroG.Rows[gridCarroG.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Enabled = false;
            }
        }
    }
}
