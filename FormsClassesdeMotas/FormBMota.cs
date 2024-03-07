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
    public partial class FormBMota : Form
    {
        public FormBMota()
        {
            InitializeComponent();
            gridMotaB.AllowUserToAddRows = false;
            gridMotaB.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridMotaB.Columns.Add("Matrícula", "Matrícula");
            gridMotaB.Columns.Add("Marca", "Marca");
            gridMotaB.Columns.Add("Modelo", "Modelo");
            gridMotaB.Columns.Add("Estado", "Estado");
            gridMotaB.Columns.Add("Combustível", "Combustível");
            gridMotaB.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridMotaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridMotaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMotaB.MultiSelect = false;
            gridMotaB.EnableHeadersVisualStyles = false;
            gridMotaB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridMotaB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.RowsDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridMotaB.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Mota)
                {
                    Mota mota = (Mota)veiculo;

                    if (mota.ClasseVeiculo == "B")
                    {
                        gridMotaB.Rows.Add(mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
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
            if (gridMotaB.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridMotaB.Rows[gridMotaB.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Enabled = false;
            }
        }
    }
}
