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
    public partial class FormBCamiao : Form
    {
        public FormBCamiao()
        {
            InitializeComponent();
            gridCamiaoB.AllowUserToAddRows = false;
            gridCamiaoB.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamiaoB.Columns.Add("ID", "ID");
            gridCamiaoB.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoB.Columns.Add("Marca", "Marca");
            gridCamiaoB.Columns.Add("Modelo", "Modelo");
            gridCamiaoB.Columns.Add("Estado", "Estado");
            gridCamiaoB.Columns.Add("Combustível", "Combustível");
            gridCamiaoB.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamiaoB.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamiaoB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamiaoB.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamiaoB.RowHeadersVisible = false;
            gridCamiaoB.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamiaoB.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamiaoB.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamiaoB.GridColor = Color.FromArgb(96, 155, 173);
            gridCamiaoB.BorderStyle = BorderStyle.None;
            gridCamiaoB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamiaoB.ScrollBars = ScrollBars.Both;
            gridCamiaoB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoB.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }



        private void atualizaDataGridView()
        {
            gridCamiaoB.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camiao)
                {
                    Camiao camiao = (Camiao)veiculo;

                    if (camiao.ClasseVeiculo == "B")
                    {
                        gridCamiaoB.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }

        private void PaintCamiaoB(object sender, PaintEventArgs e)
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

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCamiaoB.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                if (Convert.ToDecimal(gridCamiaoB.Rows[gridCamiaoB.CurrentRow.Index].Cells[7].Value) == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("O preço diário deste veículo é 0€, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamiaoB.Rows[gridCamiaoB.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
