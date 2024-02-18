using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class UC_Funcionarios : UserControl
    {
        private Timer timer;
        public UC_Funcionarios()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            Dock = DockStyle.Fill;
            dataGridViewFuncionario.Columns.Add("Nome", "Nome");
            dataGridViewFuncionario.Columns.Add("Nif", "NIF");
            dataGridViewFuncionario.Columns.Add("Morada", "Morada");
            dataGridViewFuncionario.Columns.Add("Email", "Email");
            dataGridViewFuncionario.Columns.Add("Telemovel", "Telemovel");

            //configurações do datagridview
            dataGridViewFuncionario.EnableHeadersVisualStyles = false;
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //header font size 10 bold and font family arial
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewFuncionario.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.RowsDefaultCellStyle.ForeColor = Color.White;


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing) //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                dataGridViewFuncionario.Rows.Clear();
                foreach (var funcionario in Program.melresCar.Funcionarios)
                {
                    dataGridViewFuncionario.Rows.Add(funcionario.Nome, funcionario.Nif, funcionario.Morada, funcionario.Email, funcionario.Telemovel);
                }
            }
        }


        private void buttonEditFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddFuncionario_Click(object sender, EventArgs e)
        {
            MenuAdicionarFuncionario adicionarFuncionario = new MenuAdicionarFuncionario();
            adicionarFuncionario.Show();
        }
    }
}
