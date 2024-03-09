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
    public partial class FormACamiao : Form
    {
        public FormACamiao()
        {
            InitializeComponent();
            gridCamiaoA.AllowUserToAddRows = false;
            gridCamiaoA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamiaoA.Columns.Add("ID", "ID");
            gridCamiaoA.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoA.Columns.Add("Marca", "Marca");
            gridCamiaoA.Columns.Add("Modelo", "Modelo");
            gridCamiaoA.Columns.Add("Estado", "Estado");
            gridCamiaoA.Columns.Add("Combustível", "Combustível");
            gridCamiaoA.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamiaoA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCamiaoA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCamiaoA.MultiSelect = false;
            gridCamiaoA.EnableHeadersVisualStyles = false;
            gridCamiaoA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamiaoA.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoA.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoA.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoA.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoA.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        

        private void atualizaDataGridView()
        {
            gridCamiaoA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camiao)
                {
                    Camiao camiao = (Camiao)veiculo;

                    if (camiao.ClasseVeiculo == "A")
                    {
                        gridCamiaoA.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }

        private void crownButton1_Click_1(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCamiaoA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();
                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamiaoA.Rows[gridCamiaoA.CurrentRow.Index].Cells[0].Value));
                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
