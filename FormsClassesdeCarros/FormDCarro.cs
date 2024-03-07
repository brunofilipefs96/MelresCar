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
    public partial class FormDCarro : Form
    {
        public FormDCarro()
        {
            InitializeComponent();
            gridCarroD.AllowUserToAddRows = false;
            gridCarroD.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroD.Columns.Add("ID", "ID");
            gridCarroD.Columns.Add("Matrícula", "Matrícula");
            gridCarroD.Columns.Add("Marca", "Marca");
            gridCarroD.Columns.Add("Modelo", "Modelo");
            gridCarroD.Columns.Add("Estado", "Estado");
            gridCarroD.Columns.Add("Combustível", "Combustível");
            gridCarroD.Columns.Add("NumPortas", "NumPortas");
            gridCarroD.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroD.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroD.MultiSelect = false;
            gridCarroD.EnableHeadersVisualStyles = false;
            gridCarroD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroD.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroD.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroD.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroD.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroD.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroD.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroD.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "D")
                    {
                        gridCarroD.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroD.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroD.Rows[gridCarroD.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Enabled = false;
            }
        }
    }
}
