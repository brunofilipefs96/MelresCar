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
    public partial class FormJCarro : Form
    {
        public FormJCarro()
        {
            InitializeComponent();
            gridCarroJ.AllowUserToAddRows = false;
            gridCarroJ.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroJ.Columns.Add("ID", "ID");
            gridCarroJ.Columns.Add("Matrícula", "Matrícula");
            gridCarroJ.Columns.Add("Marca", "Marca");
            gridCarroJ.Columns.Add("Modelo", "Modelo");
            gridCarroJ.Columns.Add("Estado", "Estado");
            gridCarroJ.Columns.Add("Combustível", "Combustível");
            gridCarroJ.Columns.Add("NumPortas", "NumPortas");
            gridCarroJ.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroJ.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroJ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroJ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroJ.MultiSelect = false;
            gridCarroJ.EnableHeadersVisualStyles = false;
            gridCarroJ.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroJ.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroJ.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "J")
                    {
                        gridCarroJ.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroJ.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroJ.Rows[gridCarroJ.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Enabled = false;
            }
        }
    }
}
