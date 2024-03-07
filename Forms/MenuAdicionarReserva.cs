using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile.Forms
{
    public partial class MenuAdicionarReserva : Form
    {
        private int _idVeiculo, _numCliente;
        private decimal _precoTotal;
        private bool _dataAtualCheckBox;
        public MenuAdicionarReserva()
        {
            InitializeComponent();
            _dataAtualCheckBox = false;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.RowCount = 0;
            dataGridViewClientes.Columns.Add("NumCliente", "NumCliente");
            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("Nif", "NIF");

            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.MultiSelect = false;

            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewClientes.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.RowsDefaultCellStyle.ForeColor = Color.White;


            Dock = DockStyle.Fill;
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.RowCount = 0;
            dataGridViewReservas.Columns.Add("ID", "ID");
            dataGridViewReservas.Columns.Add("Data Inicial", "Data Inicial");
            dataGridViewReservas.Columns.Add("Data Final", "Data Final");


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
            calculaPrecoTotal();
            atualizaDataGridView();
        }

        public void atualizaDataGridView()
        {

            dataGridViewClientes.Rows.Clear();
            foreach (var cliente in Program.melresCar.Clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.NumCliente, cliente.Nome, cliente.Nif);
            }

            dataGridViewReservas.Rows.Clear();
            foreach (var reserva in Program.melresCar.Reservas)
            {
                if (reserva.IdVeiculo == _idVeiculo)
                {
                    dataGridViewReservas.Rows.Add(reserva.IdReserva, reserva.DataInicio, reserva.DataFim);
                }
            }


        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in Program.melresCar.Clientes)
            {
                if (cliente.Nif == textBoxNif.Text)
                {
                    return;
                }
            }
            MessageBox.Show("Este cliente não existe!");
            MenuAdicionarCliente adicionarCliente = new MenuAdicionarCliente();
            adicionarCliente.Show();
        }
        public void veiculoSelecionado(int posicao)
        {
            _idVeiculo = posicao;
            atualizaDataGridView();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNif_TextChanged(object sender, EventArgs e)
        {
            dataGridViewClientes.Rows.Clear();
            foreach (var cliente in Program.melresCar.Clientes)
            {
                if (cliente.Nif.Contains(textBoxNif.Text))
                {
                    dataGridViewClientes.Rows.Add(cliente.NumCliente, cliente.Nome, cliente.Nif);
                }
            }

        }


        private void calculaPrecoTotal()
        {
            DateTime dataInicio = dateTimePicker1.Value;
            DateTime dataFim = dateTimePicker2.Value;
            TimeSpan diferenca = dataFim - dataInicio;
            int dias = diferenca.Days;
            dias++;
            _precoTotal = (dias * Program.melresCar.ProcuraPrecoVeiculo(_idVeiculo));
            precoTotal.Text = "Preço Total: " + _precoTotal.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calculaPrecoTotal();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            calculaPrecoTotal();
        }

        private void airCheckBox1_CheckedChanged(object sender)
        {
            if (airCheckBox1.Checked)
            {
                _dataAtualCheckBox = true;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                _dataAtualCheckBox = false;
                dateTimePicker1.Enabled = true;
            }
        }

        private void buttonAdicionarReserva_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!");
                return;
            }
            _numCliente = Convert.ToInt32(dataGridViewClientes.Rows[dataGridViewClientes.CurrentRow.Index].Cells[0].Value);

            if (!_dataAtualCheckBox)
            {
                if (dateTimePicker1.Value < DateTime.Now)
                {
                    MessageBox.Show("Data/Hora Inicial não pode ser inferior à Data/Hora atual!");
                    return;
                }

                if (dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    MessageBox.Show("Data/Hora Final não pode ser inferior à Data/Hora Inicial!");
                    return;
                }

                if (Program.melresCar.VerificaReservasExistentes(_idVeiculo, dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    MessageBox.Show("Já existem Reservas para esse Veículo nas Datas/Horas Inseridas!");
                    return;
                }
                Reserva novaReserva = new Reserva(dateTimePicker1.Value, dateTimePicker2.Value, _idVeiculo, _numCliente, _precoTotal);
                Program.melresCar.InserirReserva(novaReserva);

            }
            else
            {
                if (dateTimePicker2.Value <= DateTime.Now)
                {
                    MessageBox.Show("Data/Hora Final não pode ser inferior à Data/Hora atual!");
                    return;
                }
                if (Program.melresCar.VerificaReservasExistentes(_idVeiculo, DateTime.Now, dateTimePicker2.Value))
                {
                    MessageBox.Show("Já existem Reservas para esse Veículo nas Datas/Horas Inseridas!");
                    return;
                }
               
                Reserva novaReserva = new Reserva(DateTime.Now, dateTimePicker2.Value, _idVeiculo, _numCliente, _precoTotal);
                Program.melresCar.InserirReserva(novaReserva);
            }




            Program.melresCar.EscreverFicheiroCSV("reservas");

            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.ucReservas.atualizaDataGridView();
            menuPrincipalObject.Enabled = true;
            MessageBox.Show("Reserva adicionado com sucesso");
            this.Close();
        }


    }
}
