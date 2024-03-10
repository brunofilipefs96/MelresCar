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
            gridCamionetaC.Columns.Add("ID", "ID");
            gridCamionetaC.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaC.Columns.Add("Marca", "Marca");
            gridCamionetaC.Columns.Add("Modelo", "Modelo");
            gridCamionetaC.Columns.Add("Estado", "Estado");
            gridCamionetaC.Columns.Add("Combustível", "Combustível");
            gridCamionetaC.Columns.Add("NumEixos", "Nº Eixos");
            gridCamionetaC.Columns.Add("NumPassageiros", "Nº Passageiros");
            gridCamionetaC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamionetaC.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamionetaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamionetaC.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamionetaC.RowHeadersVisible = false;
            gridCamionetaC.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamionetaC.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamionetaC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamionetaC.GridColor = Color.FromArgb(96, 155, 173);
            gridCamionetaC.BorderStyle = BorderStyle.None;
            gridCamionetaC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamionetaC.ScrollBars = ScrollBars.Both;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaC.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                        gridCamionetaC.Rows.Add(veiculo.IdVeiculo, camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
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

        private void PaintCamionetaC(object sender, PaintEventArgs e)
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
