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
using Automobile.Forms;

namespace Automobile
{
    public partial class UC_Reservas : UserControl
    {
        public UC_Reservas()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.RowCount = 0;
            dataGridViewReservas.Columns.Add("ID", "ID");
            dataGridViewReservas.Columns.Add("Data Reserva", "Data Reserva");
            dataGridViewReservas.Columns.Add("Data Inicial", "Data Inicial");
            dataGridViewReservas.Columns.Add("Data Final", "Data Final");
            dataGridViewReservas.Columns.Add("Matrícula", "Matrícula");
            dataGridViewReservas.Columns.Add("NIF Cliente", "NIF Cliente");
            dataGridViewReservas.Columns.Add("Preço Total (€)", "Preço Total (€)");
            

            dataGridViewReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservas.MultiSelect = false;

            dataGridViewReservas.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.Font = new Font("Stencil", 10);
            dataGridViewReservas.RowHeadersVisible = false;
            dataGridViewReservas.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            dataGridViewReservas.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewReservas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewReservas.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewReservas.BorderStyle = BorderStyle.None;
            dataGridViewReservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            atualizaDataGridView();
        }

        public void atualizaDataGridView()
        {
            dataGridViewReservas.Rows.Clear();
            foreach (var reserva in Program.melresCar.Reservas)
            {
                dataGridViewReservas.Rows.Add(reserva.IdReserva, reserva.DataReserva, reserva.DataInicio, reserva.DataFim, Program.melresCar.ProcurarMatriculaVeiculo(reserva.IdVeiculo), Program.melresCar.ProcuraNifCliente(reserva.NumCliente), reserva.PrecoTotal);
            }
        }
        private void buttonCriarReserva_Click_1(object sender, EventArgs e)
        {
            ListaVeiculo listaVeiculo = new ListaVeiculo();
            listaVeiculo.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }
        private void buttonLucroEntreDatas_Click_1(object sender, EventArgs e)
        {
            LucroDatas lucroDatas = new LucroDatas();
            lucroDatas.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }
        private void PaintReservas(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void buttonRemReserva_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.CurrentCell == null)
            {
                MessageBox.Show("Selecione uma reserva para remover");
                return;
            }
            else
            {
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover essa reserva?", "Remover Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    menuPrincipalObject.Enabled = true;
                    return;
                }
                int posicaoListaReserva = Program.melresCar.ProcuraPosicaoReservaLista(Convert.ToInt32(dataGridViewReservas.Rows[dataGridViewReservas.CurrentRow.Index].Cells[0].Value));
                Program.melresCar.Reservas.RemoveAt(posicaoListaReserva);
                Program.melresCar.EscreverFicheiroCSV("reservas");
                atualizaDataGridView();
                MessageBox.Show("Reserva removida com sucesso");
                menuPrincipalObject.Enabled = true;
            }
        }
    }
}
