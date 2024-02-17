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
        public UC_Clientes()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "NIF";
            dataGridView1.Columns[2].Name = "Morada";
            dataGridView1.Columns[3].Name = "Email";
            dataGridView1.Columns[4].Name = "Telemovel";
            dataGridView1.Columns[5].Name = "NumCliente";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UC_Clientes_Load(this, new EventArgs());
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            AdicionarCliente adicionarCliente = new AdicionarCliente();
            adicionarCliente.Show();
        }

        private void buttonEditCliente_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.Show();
        }

        private void buttonRemCliente_Click(object sender, EventArgs e)
        {
            RemoverCliente removerCliente = new RemoverCliente();
            removerCliente.Show();
        }

        private void UC_Clientes_Load(object sender, EventArgs e)
        {
            foreach (var cliente in Program.melresCar.Clientes)
            {
                dataGridView1.Rows.Add(cliente.Nome, cliente.Nif, cliente.Morada, cliente.Email, cliente.Telemovel, cliente.NumCliente);
            }
        }
    }
}
