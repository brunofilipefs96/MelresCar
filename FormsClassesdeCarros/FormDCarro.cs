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
    public partial class FormDCarro : Form
    {
        public FormDCarro()
        {
            InitializeComponent();
            gridCarroD.AllowUserToAddRows = false;
            gridCarroD.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroD.Columns.Add("ID", "ID");
            gridCarroD.Columns.Add("Matrícula", "Matrícula");
            gridCarroD.Columns.Add("Marca", "Marca");
            gridCarroD.Columns.Add("Modelo", "Modelo");
            gridCarroD.Columns.Add("Estado", "Estado");
            gridCarroD.Columns.Add("Combustível", "Combustível");
            gridCarroD.Columns.Add("NumPortas", "NumPortas");
            gridCarroD.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroD.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroD.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroD.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroD.RowHeadersVisible = false;
            gridCarroD.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroD.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroD.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroD.BorderStyle = BorderStyle.None;
            gridCarroD.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroD.ScrollBars = ScrollBars.Both;
            gridCarroD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroD.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroD.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "D")
                    {
                        gridCarroD.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroD.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroD.Rows[gridCarroD.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroD(object sender, PaintEventArgs e)
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
