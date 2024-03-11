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
    public partial class FormCMota : Form
    {
        public FormCMota()
        {
            InitializeComponent();
            gridMotaC.AllowUserToAddRows = false;
            gridMotaC.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridMotaC.Columns.Add("ID", "ID");
            gridMotaC.Columns.Add("Matrícula", "Matrícula");
            gridMotaC.Columns.Add("Marca", "Marca");
            gridMotaC.Columns.Add("Modelo", "Modelo");
            gridMotaC.Columns.Add("Estado", "Estado");
            gridMotaC.Columns.Add("Combustível", "Combustível");
            gridMotaC.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridMotaC.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridMotaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridMotaC.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridMotaC.RowHeadersVisible = false;
            gridMotaC.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridMotaC.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridMotaC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridMotaC.GridColor = Color.FromArgb(96, 155, 173);
            gridMotaC.BorderStyle = BorderStyle.None;
            gridMotaC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridMotaC.ScrollBars = ScrollBars.Both;
            gridMotaC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaC.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridMotaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridMotaC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Mota)
                {
                    Mota mota = (Mota)veiculo;

                    if (mota.ClasseVeiculo == "C")
                    {
                        gridMotaC.Rows.Add(veiculo.IdVeiculo, mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
                    }
                }
            }
        }

        private void PaintMotaC(object sender, PaintEventArgs e)
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
            if (gridMotaC.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridMotaC.Rows[gridMotaC.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
