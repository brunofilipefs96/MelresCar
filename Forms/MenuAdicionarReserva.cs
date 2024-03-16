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
            dateTimePicker1.MinDate = Program.DataHoraDoSistema();
            dateTimePicker2.MinDate = Program.DataHoraDoSistema();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            Dock = DockStyle.Fill;

            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.RowCount = 0;
            dataGridViewClientes.Columns.Add("NumCliente", "NumCliente");
            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("Nif", "NIF");

            dataGridViewClientes.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            dataGridViewClientes.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewClientes.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientes.ScrollBars = ScrollBars.Both;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClientes.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Dock = DockStyle.Fill;
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.RowCount = 0;
            dataGridViewReservas.Columns.Add("ID", "ID");
            dataGridViewReservas.Columns.Add("Data Inicial", "Data Inicial");
            dataGridViewReservas.Columns.Add("Data Final", "Data Final");


            dataGridViewReservas.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            dataGridViewReservas.RowHeadersVisible = false;
            dataGridViewReservas.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            dataGridViewReservas.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewReservas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewReservas.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewReservas.BorderStyle = BorderStyle.None;
            dataGridViewReservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewReservas.ScrollBars = ScrollBars.Both;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewReservas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            calculaPrecoTotal();

            if (Program.melresCar.DaysAdded != 0)
            {
                airCheckBox1.Hide();
            }
        }

        private void atualizaManutencao()
        {
            bool manutencao = false;
            if (airCheckBox1 != null)
            {
                if (Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataInicioManutencao.Date >= dateTimePicker1.Value.Date || Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataFimManutencao.Date >= dateTimePicker1.Value.Date || Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataInicioManutencao.Date >= dateTimePicker2.Value.Date || Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataFimManutencao.Date >= dateTimePicker2.Value.Date)
                {
                    manutencao = true;
                }
            }
            else
            {
                if (Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataInicioManutencao >= Program.DataHoraDoSistema() || Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataFimManutencao >= Program.DataHoraDoSistema())
                {
                    manutencao = true;
                }
            }

            if (!manutencao)
            {
                labelDatasManutencao.Text = "";
            }
            else
            {
                labelDatasManutencao.Text = "Datas de Manutenção: " + Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataInicioManutencao.ToString("dd/MM/yyyy") + " - " + Program.melresCar.Veiculos[Program.melresCar.ProcuraPosicaoVeiculoLista(_idVeiculo)].DataFimManutencao.ToString("dd/MM/yyyy");
            }
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
            labelVeiculo.Text = "Veículo: " + Program.melresCar.ProcurarMatriculaVeiculo(_idVeiculo);
            labelPrecoDiario.Text = "Preço Diário: " + Program.melresCar.ProcuraPrecoVeiculo(_idVeiculo);

            atualizaManutencao();
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
            precoTotal.Text = "Preço Total: " + Program.melresCar.ProcuraPrecoVeiculo(_idVeiculo);
            dateTimePicker2.Value = dateTimePicker2.Value.AddHours(1);
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
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
            atualizaManutencao();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            calculaPrecoTotal();
            atualizaManutencao();
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

        private void PaintReservaVeiculo(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }


        private void buttonAdicionarReserva_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!");
                return;
            }
            _numCliente = Convert.ToInt32(dataGridViewClientes.Rows[dataGridViewClientes.CurrentRow.Index].Cells[0].Value);

            if (!_dataAtualCheckBox)
            {
                if (!Program.melresCar.ProcuraDataDisponibilidade(_idVeiculo, dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    MessageBox.Show("Veículo em manutenção/reservado nas datas/horas inseridas!");
                    return;
                }
                if (dateTimePicker1.Value < Program.DataHoraDoSistema())
                {
                    MessageBox.Show("Data/Hora Inicial não pode ser inferior à Data/Hora atual!");
                    return;
                }

                if (dateTimePicker2.Value <= dateTimePicker1.Value)
                {
                    MessageBox.Show("Data/Hora Final não pode ser inferior à Data/Hora Inicial!");
                    return;
                }

                Reserva novaReserva = new Reserva(dateTimePicker1.Value, dateTimePicker2.Value, _idVeiculo, _numCliente, _precoTotal);
                Program.melresCar.InserirReserva(novaReserva);

            }
            else
            {
                if (!Program.melresCar.ProcuraDataDisponibilidade(_idVeiculo, Program.DataHoraDoSistema(), dateTimePicker2.Value))
                {
                    MessageBox.Show("Veículo em manutenção/reservado nas datas/horas inseridas!");
                    return;
                }
                if (dateTimePicker2.Value <= Program.DataHoraDoSistema())
                {
                    MessageBox.Show("Data/Hora Final não pode ser inferior à Data/Hora atual!");
                    return;
                }

                Reserva novaReserva = new Reserva(Program.DataHoraDoSistema(), dateTimePicker2.Value, _idVeiculo, _numCliente, _precoTotal);
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
