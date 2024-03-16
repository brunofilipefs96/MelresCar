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

            gridCamionetaA.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamionetaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamionetaA.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamionetaA.RowHeadersVisible = false;
            gridCamionetaA.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamionetaA.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamionetaA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamionetaA.GridColor = Color.FromArgb(96, 155, 173);
            gridCamionetaA.BorderStyle = BorderStyle.None;
            gridCamionetaA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamionetaA.ScrollBars = ScrollBars.Both;
            gridCamionetaA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaA.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamionetaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void PaintCamionetaA(object sender, PaintEventArgs e)
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
            if (gridCamionetaA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                if (Convert.ToDecimal(gridCamionetaA.Rows[gridCamionetaA.CurrentRow.Index].Cells[8].Value) == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("O preço diário deste veículo é 0€, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamionetaA.Rows[gridCamionetaA.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
