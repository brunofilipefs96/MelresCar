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
    public partial class FormCCamiao : Form
    {
        public FormCCamiao()
        {
            InitializeComponent();
            gridCamiaoC.AllowUserToAddRows = false;
            gridCamiaoC.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamiaoC.Columns.Add("ID", "ID");
            gridCamiaoC.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoC.Columns.Add("Marca", "Marca");
            gridCamiaoC.Columns.Add("Modelo", "Modelo");
            gridCamiaoC.Columns.Add("Estado", "Estado");
            gridCamiaoC.Columns.Add("Combustível", "Combustível");
            gridCamiaoC.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCamiaoC.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCamiaoC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCamiaoC.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCamiaoC.RowHeadersVisible = false;
            gridCamiaoC.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCamiaoC.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCamiaoC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCamiaoC.GridColor = Color.FromArgb(96, 155, 173);
            gridCamiaoC.BorderStyle = BorderStyle.None;
            gridCamiaoC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCamiaoC.ScrollBars = ScrollBars.Both;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoC.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCamiaoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            atualizaDataGridView();
        }



        private void atualizaDataGridView()
        {
            gridCamiaoC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camiao)
                {
                    Camiao camiao = (Camiao)veiculo;

                    if (camiao.ClasseVeiculo == "C")
                    {
                        gridCamiaoC.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }


        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCamiaoC.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCamiaoC.Rows[gridCamiaoC.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void PaintCamiaoC(object sender, PaintEventArgs e)
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
