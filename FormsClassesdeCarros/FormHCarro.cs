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
    public partial class FormHCarro : Form
    {
        public FormHCarro()
        {
            InitializeComponent();
            gridCarroH.AllowUserToAddRows = false;
            gridCarroH.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroH.Columns.Add("ID", "ID");
            gridCarroH.Columns.Add("Matrícula", "Matrícula");
            gridCarroH.Columns.Add("Marca", "Marca");
            gridCarroH.Columns.Add("Modelo", "Modelo");
            gridCarroH.Columns.Add("Estado", "Estado");
            gridCarroH.Columns.Add("Combustível", "Combustível");
            gridCarroH.Columns.Add("NumPortas", "NumPortas");
            gridCarroH.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroH.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroH.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroH.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroH.RowHeadersVisible = false;
            gridCarroH.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroH.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroH.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroH.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroH.BorderStyle = BorderStyle.None;
            gridCarroH.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroH.ScrollBars = ScrollBars.Both;
            gridCarroH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroH.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroH.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "H")
                    {
                        gridCarroH.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroH.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroH.Rows[gridCarroH.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroH(object sender, PaintEventArgs e)
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
