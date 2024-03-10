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
    public partial class FormACamiao : Form
    {
        public FormACamiao()
        {
            InitializeComponent();
            gridCamiaoA.AllowUserToAddRows = false;
            gridCamiaoA.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamiaoA.Columns.Add("ID", "ID");
            gridCamiaoA.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoA.Columns.Add("Marca", "Marca");
            gridCamiaoA.Columns.Add("Modelo", "Modelo");
            gridCamiaoA.Columns.Add("Estado", "Estado");
            gridCamiaoA.Columns.Add("Combustível", "Combustível");
            gridCamiaoA.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamiaoA.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamiaoA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamiaoA.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamiaoA.RowHeadersVisible = false;
            gridCamiaoA.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamiaoA.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamiaoA.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamiaoA.GridColor = Color.FromArgb(96, 155, 173);
            gridCamiaoA.BorderStyle = BorderStyle.None;
            gridCamiaoA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamiaoA.ScrollBars = ScrollBars.Both;
            gridCamiaoA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoA.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }

        

        private void atualizaDataGridView()
        {
            gridCamiaoA.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camiao)
                {
                    Camiao camiao = (Camiao)veiculo;

                    if (camiao.ClasseVeiculo == "A")
                    {
                        gridCamiaoA.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }

        private void crownButton1_Click_1(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCamiaoA.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();
                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamiaoA.Rows[gridCamiaoA.CurrentRow.Index].Cells[0].Value));
                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCamiaoA(object sender, PaintEventArgs e)
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
