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
    public partial class FormCCamioneta : Form
    {
        public FormCCamioneta()
        {
            InitializeComponent();
            gridCamionetaC.AllowUserToAddRows = false;
            gridCamionetaC.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamionetaC.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaC.Columns.Add("Marca", "Marca");
            gridCamionetaC.Columns.Add("Modelo", "Modelo");
            gridCamionetaC.Columns.Add("Estado", "Estado");
            gridCamionetaC.Columns.Add("Combustível", "Combustível");
            gridCamionetaC.Columns.Add("NumEixos", "NumEixos");
            gridCamionetaC.Columns.Add("NumPassageiros", "NumPassageiros");
            gridCamionetaC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamionetaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCamionetaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCamionetaC.MultiSelect = false;
            gridCamionetaC.EnableHeadersVisualStyles = false;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamionetaC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCamionetaC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camioneta)
                {
                    Camioneta camioneta = (Camioneta)veiculo;

                    if (camioneta.ClasseVeiculo == "C")
                    {
                        gridCamionetaC.Rows.Add(camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
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
            if (gridCamionetaC.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamionetaC.Rows[gridCamionetaC.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
