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
    public partial class FormACarro : Form
    {
        public FormACarro()
        {
            InitializeComponent();

            gridCarroA.AllowUserToAddRows = false;
            gridCarroA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroA.Columns.Add("ID", "ID");
            gridCarroA.Columns.Add("Matrícula", "Matrícula");
            gridCarroA.Columns.Add("Marca", "Marca");
            gridCarroA.Columns.Add("Modelo", "Modelo");
            gridCarroA.Columns.Add("Estado", "Estado");
            gridCarroA.Columns.Add("Combustível", "Combustível");
            gridCarroA.Columns.Add("NumPortas", "NumPortas");
            gridCarroA.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroA.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroA.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroA.RowHeadersVisible = false;
            gridCarroA.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroA.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroA.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroA.BorderStyle = BorderStyle.None;
            gridCarroA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroA.ScrollBars = ScrollBars.Both;
            gridCarroA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroA.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "A")
                    {
                        gridCarroA.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {

            if (gridCarroA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();
                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroA.Rows[gridCarroA.CurrentRow.Index].Cells[0].Value));
                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroA(object sender, PaintEventArgs e)
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