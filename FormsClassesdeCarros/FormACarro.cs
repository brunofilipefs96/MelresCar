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
    public partial class FormACarro : Form
    {
        public FormACarro()
        {
            InitializeComponent();
            gridCarroA.AllowUserToAddRows = false;
            gridCarroA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroA.Columns.Add("ID", "ID");
            gridCarroA.Columns.Add("Matrícula", "Matrícula");
            gridCarroA.Columns.Add("Marca", "Marca");
            gridCarroA.Columns.Add("Modelo", "Modelo");
            gridCarroA.Columns.Add("Estado", "Estado");
            gridCarroA.Columns.Add("Combustível", "Combustível");
            gridCarroA.Columns.Add("NumPortas", "NumPortas");
            gridCarroA.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroA.MultiSelect = false;
            gridCarroA.EnableHeadersVisualStyles = false;
            gridCarroA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroA.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroA.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroA.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroA.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroA.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "A")
                    {
                        gridCarroA.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonReservar_Click(object sender, EventArgs e)
        {

            if (gridCarroA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroA.Rows[gridCarroA.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Enabled = false;
            }
        }
    }
}
