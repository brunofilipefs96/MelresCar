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
    public partial class FormBCamioneta : Form
    {
        public FormBCamioneta()
        {
            InitializeComponent();
            gridCamionetaB.AllowUserToAddRows = false;
            gridCamionetaB.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamionetaB.Columns.Add("ID", "ID");
            gridCamionetaB.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaB.Columns.Add("Marca", "Marca");
            gridCamionetaB.Columns.Add("Modelo", "Modelo");
            gridCamionetaB.Columns.Add("Estado", "Estado");
            gridCamionetaB.Columns.Add("Combustível", "Combustível");
            gridCamionetaB.Columns.Add("NumEixos", "Nº Eixos");
            gridCamionetaB.Columns.Add("NumPassageiros", "Nº Passageiros");
            gridCamionetaB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamionetaB.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamionetaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamionetaB.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamionetaB.RowHeadersVisible = false;
            gridCamionetaB.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamionetaB.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamionetaB.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamionetaB.GridColor = Color.FromArgb(96, 155, 173);
            gridCamionetaB.BorderStyle = BorderStyle.None;
            gridCamionetaB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamionetaB.ScrollBars = ScrollBars.Both;
            gridCamionetaB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaB.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCamionetaB.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camioneta)
                {
                    Camioneta camioneta = (Camioneta)veiculo;

                    if (camioneta.ClasseVeiculo == "B")
                    {
                        gridCamionetaB.Rows.Add(veiculo.IdVeiculo, camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
                    }
                }
            }
        }


        private void PaintCamionetaB(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCamionetaB.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                if (Convert.ToDecimal(gridCamionetaB.Rows[gridCamionetaB.CurrentRow.Index].Cells[8].Value) == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("O preço diário deste veículo é 0€, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamionetaB.Rows[gridCamionetaB.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
