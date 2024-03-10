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
    public partial class FormJCarro : Form
    {
        public FormJCarro()
        {
            InitializeComponent();
            gridCarroJ.AllowUserToAddRows = false;
            gridCarroJ.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroJ.Columns.Add("ID", "ID");
            gridCarroJ.Columns.Add("Matrícula", "Matrícula");
            gridCarroJ.Columns.Add("Marca", "Marca");
            gridCarroJ.Columns.Add("Modelo", "Modelo");
            gridCarroJ.Columns.Add("Estado", "Estado");
            gridCarroJ.Columns.Add("Combustível", "Combustível");
            gridCarroJ.Columns.Add("NumPortas", "NumPortas");
            gridCarroJ.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroJ.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroJ.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroJ.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroJ.ColumnHeadersDefaultCellStyle.Font = new Font("Stencil", 12);
            gridCarroJ.RowHeadersVisible = false;
            gridCarroJ.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroJ.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroJ.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroJ.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroJ.BorderStyle = BorderStyle.None;
            gridCarroJ.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroJ.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "J")
                    {
                        gridCarroJ.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroJ.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroJ.Rows[gridCarroJ.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroJ(object sender, PaintEventArgs e)
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
