using ReaLTaiizor.Controls;
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
    public partial class MenuManutencao : Form
    {
        private int _idVeiculo;
        public MenuManutencao()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = Program.DataHoraDoSistema();
            dateTimePicker2.MinDate = Program.DataHoraDoSistema();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            dataGridViewManutencoes.AllowUserToAddRows = false;
            dataGridViewManutencoes.RowCount = 0;
            dataGridViewManutencoes.Columns.Add("ID", "ID");
            dataGridViewManutencoes.Columns.Add("Matrícula", "Matrícula");
            dataGridViewManutencoes.Columns.Add("Data Inicio", "Data Inicio");
            dataGridViewManutencoes.Columns.Add("Data Fim", "Data Fim");

            dataGridViewManutencoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewManutencoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManutencoes.MultiSelect = false;

            dataGridViewManutencoes.EnableHeadersVisualStyles = false;
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewManutencoes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewManutencoes.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewManutencoes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewManutencoes.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewManutencoes.RowsDefaultCellStyle.ForeColor = Color.White;

            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);
            dateTimePicker1.Value = dateTimePicker1.Value.Date + new TimeSpan(0, 0, 0);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + new TimeSpan(23, 59, 59);

            atualizaDataGridView();
        }


        public void atualizaDataGridView()
        {
            labelVeiculo.Text = "Veículo: " + Program.melresCar.ProcurarMatriculaVeiculo(_idVeiculo);
            dataGridViewManutencoes.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo.DataInicioManutencao >= Program.DataHoraDoSistema() || veiculo.DataFimManutencao >= Program.DataHoraDoSistema())
                {
                    dataGridViewManutencoes.Rows.Add(veiculo.IdVeiculo, veiculo.Matricula, veiculo.DataInicioManutencao, veiculo.DataFimManutencao);
                }
            }
            
        }

        public void veiculoSelecionado(int posicao)
        {
            _idVeiculo = posicao + 1;
            atualizaDataGridView();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void buttonAgendarManutencao_Click(object sender, EventArgs e)
        {
            

        }
    }
}
