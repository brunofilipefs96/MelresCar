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
    public partial class FormCCamiao : Form
    {
        public FormCCamiao()
        {
            InitializeComponent();
            gridCamiaoC.AllowUserToAddRows = false;
            gridCamiaoC.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamiaoC.Columns.Add("ID", "ID");
            gridCamiaoC.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoC.Columns.Add("Marca", "Marca");
            gridCamiaoC.Columns.Add("Modelo", "Modelo");
            gridCamiaoC.Columns.Add("Estado", "Estado");
            gridCamiaoC.Columns.Add("Combustível", "Combustível");
            gridCamiaoC.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamiaoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCamiaoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCamiaoC.MultiSelect = false;
            gridCamiaoC.EnableHeadersVisualStyles = false;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamiaoC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }



        private void atualizaDataGridView()
        {
            gridCamiaoC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camiao)
                {
                    Camiao camiao = (Camiao)veiculo;

                    if (camiao.ClasseVeiculo == "C")
                    {
                        gridCamiaoC.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }


        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCamiaoC.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamiaoC.Rows[gridCamiaoC.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }
    }
}
