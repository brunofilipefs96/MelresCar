using ReaLTaiizor.Controls;
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
    public partial class MenuManutencao : Form
    {
        private int _indexVeiculo;
        public MenuManutencao()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = Program.DataHoraDoSistema();
            dateTimePicker2.MinDate = Program.DataHoraDoSistema();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            Dock = DockStyle.Fill;
            dataGridViewManutencoes.AllowUserToAddRows = false;
            dataGridViewManutencoes.RowCount = 0;
            dataGridViewManutencoes.Columns.Add("ID", "ID");
            dataGridViewManutencoes.Columns.Add("Matrícula", "Matrícula");
            dataGridViewManutencoes.Columns.Add("Data Inicio", "Data Inicio");
            dataGridViewManutencoes.Columns.Add("Data Fim", "Data Fim");

            dataGridViewManutencoes.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            dataGridViewManutencoes.RowHeadersVisible = false;
            dataGridViewManutencoes.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            dataGridViewManutencoes.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewManutencoes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewManutencoes.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewManutencoes.BorderStyle = BorderStyle.None;
            dataGridViewManutencoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewManutencoes.ScrollBars = ScrollBars.Both;
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewManutencoes.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewManutencoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);
            //dateTimePicker1.Value = dateTimePicker1.Value.Date + new TimeSpan(0, 0, 0);
            //dateTimePicker2.Value = dateTimePicker2.Value.Date + new TimeSpan(23, 59, 59);

        }


        public void atualizaDataGridView()
        {
            dataGridViewManutencoes.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo.DataInicioManutencao.Date >= Program.DataHoraDoSistema().Date || veiculo.DataFimManutencao.Date >= Program.DataHoraDoSistema().Date)
                {
                    dataGridViewManutencoes.Rows.Add(veiculo.IdVeiculo, veiculo.Matricula, veiculo.DataInicioManutencao.Date, veiculo.DataFimManutencao.Date);
                }

            }
            
        }

        public void veiculoSelecionado(int posicao)
        {
            _indexVeiculo = posicao;
            labelVeiculo.Text = "Veiculo: " + Program.melresCar.Veiculos[_indexVeiculo].Matricula;
            atualizaDataGridView();
        }



        private void PaintAgendarManutencao(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void buttonAgendarManutencao_Click(object sender, EventArgs e)
        {


            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Data de início não pode ser superior à data de fim", "Agendar Manutenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dateTimePicker1.Value.Date < Program.DataHoraDoSistema().Date)
                {
                    MessageBox.Show("Data/Hora Inicial não pode ser inferior à Data/Hora atual!");
                    return;
                }

                if (Program.melresCar.VerificaReservasExistentesPorData(Program.melresCar.Veiculos[_indexVeiculo].IdVeiculo, dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    MessageBox.Show("Já existem Reservas para esse Veículo nas Datas/Horas Inseridas!");
                    return;
                } 
                else
                {
                    Program.melresCar.Veiculos[_indexVeiculo].DataInicioManutencao = dateTimePicker1.Value;
                    Program.melresCar.Veiculos[_indexVeiculo].DataFimManutencao = dateTimePicker2.Value;
                    Program.melresCar.EscreverFicheiroCSV("veiculos");
                    atualizaDataGridView();
                    MessageBox.Show("Manutenção agendada com sucesso.", "Agendar Manutenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                    menuPrincipalObject.Enabled = true;
                    this.Close();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }
    }
}
