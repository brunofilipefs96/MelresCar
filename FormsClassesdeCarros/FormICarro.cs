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
    public partial class FormICarro : Form
    {
        public FormICarro()
        {
            InitializeComponent();
            gridCarroI.AllowUserToAddRows = false;
            gridCarroI.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroI.Columns.Add("ID", "ID");
            gridCarroI.Columns.Add("Matrícula", "Matrícula");
            gridCarroI.Columns.Add("Marca", "Marca");
            gridCarroI.Columns.Add("Modelo", "Modelo");
            gridCarroI.Columns.Add("Estado", "Estado");
            gridCarroI.Columns.Add("Combustível", "Combustível");
            gridCarroI.Columns.Add("NumPortas", "NumPortas");
            gridCarroI.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroI.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroI.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroI.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroI.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroI.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroI.RowHeadersVisible = false;
            gridCarroI.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroI.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroI.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroI.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroI.BorderStyle = BorderStyle.None;
            gridCarroI.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroI.ScrollBars = ScrollBars.Both;
            gridCarroI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroI.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroI.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "I")
                    {
                        gridCarroI.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCarroI.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroI.Rows[gridCarroI.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroI(object sender, PaintEventArgs e)
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
