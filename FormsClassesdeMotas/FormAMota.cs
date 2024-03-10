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
            gridMotaA.Columns.Add("ID", "ID");
            gridMotaA.Columns.Add("Matrícula", "Matrícula");
            gridMotaA.Columns.Add("Marca", "Marca");
            gridMotaA.Columns.Add("Modelo", "Modelo");
            gridMotaA.Columns.Add("Estado", "Estado");
            gridMotaA.Columns.Add("Combustível", "Combustível");
            gridMotaA.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridMotaA.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridMotaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridMotaA.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridMotaA.RowHeadersVisible = false;
            gridMotaA.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridMotaA.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridMotaA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridMotaA.GridColor = Color.FromArgb(96, 155, 173);
            gridMotaA.BorderStyle = BorderStyle.None;
            gridMotaA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridMotaA.ScrollBars = ScrollBars.Both;
            gridMotaA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaA.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                        gridMotaA.Rows.Add(veiculo.IdVeiculo, mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
                    }
                }
            }
        }
        

        private void crownButton1_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridMotaA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridMotaA.Rows[gridMotaA.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintMotaA(object sender, PaintEventArgs e)
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
