using Automobile.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormACamioneta : Form
    {
        public FormACamioneta()
        {
            InitializeComponent();
            gridCamionetaA.AllowUserToAddRows = false;
            gridCamionetaA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamionetaA.Columns.Add("ID", "ID");
            gridCamionetaA.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaA.Columns.Add("Marca", "Marca");
            gridCamionetaA.Columns.Add("Modelo", "Modelo");
            gridCamionetaA.Columns.Add("Estado", "Estado");
            gridCamionetaA.Columns.Add("Combustível", "Combustível");
            gridCamionetaA.Columns.Add("NumEixos", "Nº Eixos");
            gridCamionetaA.Columns.Add("NumPassageiros", "Nº Passageiros");
            gridCamionetaA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamionetaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCamionetaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCamionetaA.MultiSelect = false;
            gridCamionetaA.EnableHeadersVisualStyles = false;
            gridCamionetaA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamionetaA.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaA.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaA.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaA.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaA.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCamionetaA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camioneta)
                {
                    Camioneta camioneta = (Camioneta)veiculo;

                    if (camioneta.ClasseVeiculo == "A")
                    {
                        gridCamionetaA.Rows.Add(veiculo.IdVeiculo, camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
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
            if (gridCamionetaA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamionetaA.Rows[gridCamionetaA.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCamionetaA(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
