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
    public partial class FormLCarro : Form
    {
        public FormLCarro()
        {
            InitializeComponent();
            gridCarroL.AllowUserToAddRows = false;
            gridCarroL.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroL.Columns.Add("ID", "ID");
            gridCarroL.Columns.Add("Matrícula", "Matrícula");
            gridCarroL.Columns.Add("Marca", "Marca");
            gridCarroL.Columns.Add("Modelo", "Modelo");
            gridCarroL.Columns.Add("Estado", "Estado");
            gridCarroL.Columns.Add("Combustível", "Combustível");
            gridCarroL.Columns.Add("NumPortas", "NumPortas");
            gridCarroL.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroL.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroL.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroL.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroL.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroL.ColumnHeadersDefaultCellStyle.Font = new Font("Stencil", 12);
            gridCarroL.RowHeadersVisible = false;
            gridCarroL.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroL.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroL.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroL.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroL.BorderStyle = BorderStyle.None;
            gridCarroL.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroL.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "L")
                    {
                        gridCarroL.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroL.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroL.Rows[gridCarroL.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroL(object sender, PaintEventArgs e)
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
