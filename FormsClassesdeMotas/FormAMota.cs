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
    public partial class FormAMota : Form
    {
        public FormAMota()
        {
            InitializeComponent();
            gridMotaA.AllowUserToAddRows = false;
            gridMotaA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridMotaA.Columns.Add("Matrícula", "Matrícula");
            gridMotaA.Columns.Add("Marca", "Marca");
            gridMotaA.Columns.Add("Modelo", "Modelo");
            gridMotaA.Columns.Add("Estado", "Estado");
            gridMotaA.Columns.Add("Combustível", "Combustível");
            gridMotaA.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridMotaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridMotaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMotaA.MultiSelect = false;
            gridMotaA.EnableHeadersVisualStyles = false;
            gridMotaA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridMotaA.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.RowsDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridMotaA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Mota)
                {
                    Mota mota = (Mota)veiculo;

                    if (mota.ClasseVeiculo == "A")
                    {
                        gridMotaA.Rows.Add(mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
                    }
                }
            }
        }
        

        private void crownButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

            menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridMotaA.Rows[gridMotaA.CurrentRow.Index].Cells[0].Value));

            menuAdicionarReserva.Show();
            ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
            listaVeiculoObject.Enabled = false;
        }
    }
}
