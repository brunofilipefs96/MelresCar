using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class UC_Clientes : UserControl
    {
        private Timer timer;
        public UC_Clientes()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            Dock = DockStyle.Fill;
            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("Nif", "NIF");
            dataGridViewClientes.Columns.Add("Morada", "Morada");
            dataGridViewClientes.Columns.Add("Email", "Email");
            dataGridViewClientes.Columns.Add("Telemovel", "Telemovel");
            dataGridViewClientes.Columns.Add("NumCliente", "NumCliente");

            //configurações do datagridview
            dataGridViewClientes.EnableHeadersVisualStyles = false;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewClientes.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewClientes.RowsDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            MenuAdicionarCliente adicionarCliente = new MenuAdicionarCliente();
            adicionarCliente.Show();
        }

        private void buttonEditCliente_Click(object sender, EventArgs e)
        {
            MenuEditarCliente editarCliente = new MenuEditarCliente();
            editarCliente.Show();
        }

        private void buttonRemCliente_Click(object sender, EventArgs e)
        {
            MenuRemoverCliente removerCliente = new MenuRemoverCliente();
            removerCliente.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                dataGridViewClientes.Rows.Clear();
                foreach (var cliente in Program.melresCar.Clientes)
                {
                    dataGridViewClientes.Rows.Add(cliente.Nome, cliente.Nif, cliente.Morada, cliente.Email, cliente.Telemovel, cliente.NumCliente);
                }
            }
        }
    }
}
