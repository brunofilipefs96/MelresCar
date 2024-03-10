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
    public partial class FormBCarro : Form
    {
        public FormBCarro()
        {
            InitializeComponent();
            gridCarroB.AllowUserToAddRows = false;
            gridCarroB.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroB.Columns.Add("ID", "ID");
            gridCarroB.Columns.Add("Matrícula", "Matrícula");
            gridCarroB.Columns.Add("Marca", "Marca");
            gridCarroB.Columns.Add("Modelo", "Modelo");
            gridCarroB.Columns.Add("Estado", "Estado");
            gridCarroB.Columns.Add("Combustível", "Combustível");
            gridCarroB.Columns.Add("NumPortas", "NumPortas");
            gridCarroB.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroB.MultiSelect = false;
            gridCarroB.EnableHeadersVisualStyles = false;
            gridCarroB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroB.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroB.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroB.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "B")
                    {
                        gridCarroB.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
            if (gridCarroB.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            } else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroB.Rows[gridCarroB.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroB(object sender, PaintEventArgs e)
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
