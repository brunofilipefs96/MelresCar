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
    public partial class FormHCarro : Form
    {
        public FormHCarro()
        {
            InitializeComponent();
            gridCarroH.AllowUserToAddRows = false;
            gridCarroH.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroH.Columns.Add("ID", "ID");
            gridCarroH.Columns.Add("Matrícula", "Matrícula");
            gridCarroH.Columns.Add("Marca", "Marca");
            gridCarroH.Columns.Add("Modelo", "Modelo");
            gridCarroH.Columns.Add("Estado", "Estado");
            gridCarroH.Columns.Add("Combustível", "Combustível");
            gridCarroH.Columns.Add("NumPortas", "NumPortas");
            gridCarroH.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroH.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroH.MultiSelect = false;
            gridCarroH.EnableHeadersVisualStyles = false;
            gridCarroH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroH.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroH.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroH.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "H")
                    {
                        gridCarroH.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCarroH.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroH.Rows[gridCarroH.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
