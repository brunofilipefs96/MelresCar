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
    public partial class FormFCarro : Form
    {
        public FormFCarro()
        {
            InitializeComponent();
            gridCarroF.AllowUserToAddRows = false;
            gridCarroF.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroF.Columns.Add("ID", "ID");
            gridCarroF.Columns.Add("Matrícula", "Matrícula");
            gridCarroF.Columns.Add("Marca", "Marca");
            gridCarroF.Columns.Add("Modelo", "Modelo");
            gridCarroF.Columns.Add("Estado", "Estado");
            gridCarroF.Columns.Add("Combustível", "Combustível");
            gridCarroF.Columns.Add("NumPortas", "NumPortas");
            gridCarroF.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroF.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroF.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroF.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroF.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroF.RowHeadersVisible = false;
            gridCarroF.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroF.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroF.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroF.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroF.BorderStyle = BorderStyle.None;
            gridCarroF.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroF.ScrollBars = ScrollBars.Both;
            gridCarroF.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroF.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroF.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "F")
                    {
                        gridCarroF.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void PaintCarroF(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCarroF.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroF.Rows[gridCarroF.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
