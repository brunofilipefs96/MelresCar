using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            dataGridViewReservas.EnableHeadersVisualStyles = false;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewReservas.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewReservas.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewReservas.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewReservas.RowsDefaultCellStyle.ForeColor = Color.White;

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

        private void buttonCriarReserva_Click(object sender, EventArgs e)
        {
            ListaVeiculo listaVeiculo = new ListaVeiculo();
            listaVeiculo.Show();
        }

        private void buttonLucroDatas_Click(object sender, EventArgs e)
        {
            MenuMostrarLucro menuMostrarLucro = new MenuMostrarLucro();
            menuMostrarLucro.Show();
        }
    }
}
