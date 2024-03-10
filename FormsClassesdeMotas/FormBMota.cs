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
            gridMotaB.Columns.Add("ID", "ID");
            gridMotaB.Columns.Add("Matrícula", "Matrícula");
            gridMotaB.Columns.Add("Marca", "Marca");
            gridMotaB.Columns.Add("Modelo", "Modelo");
            gridMotaB.Columns.Add("Estado", "Estado");
            gridMotaB.Columns.Add("Combustível", "Combustível");
            gridMotaB.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridMotaB.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridMotaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridMotaB.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridMotaB.RowHeadersVisible = false;
            gridMotaB.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridMotaB.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridMotaB.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridMotaB.GridColor = Color.FromArgb(96, 155, 173);
            gridMotaB.BorderStyle = BorderStyle.None;
            gridMotaB.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridMotaB.ScrollBars = ScrollBars.Both;
            gridMotaB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaB.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                        gridMotaB.Rows.Add(veiculo.IdVeiculo, mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
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
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintMotaB(object sender, PaintEventArgs e)
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
