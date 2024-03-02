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
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.RowCount = 0;
            dataGridViewClientes.Columns.Add("NumCliente", "NumCliente");
            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("Nif", "NIF");
            dataGridViewClientes.Columns.Add("Morada", "Morada");
            dataGridViewClientes.Columns.Add("Email", "Email");
            dataGridViewClientes.Columns.Add("Telemovel", "Telemovel");
            

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

            atualizaDataGridView();
        }

        public void atualizaDataGridView()
        {
            dataGridViewClientes.Rows.Clear();
            foreach (var cliente in Program.melresCar.Clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.NumCliente, cliente.Nome, cliente.Nif, cliente.Morada, cliente.Email, cliente.Telemovel);
            }
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            MenuAdicionarCliente adicionarCliente = new MenuAdicionarCliente();
            adicionarCliente.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

        private void buttonEditCliente_Click(object sender, EventArgs e)
        {
            MenuEditarCliente editarCliente = new MenuEditarCliente();
            editarCliente.clienteSelecionado(dataGridViewClientes.CurrentCell.RowIndex);
            editarCliente.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

        private void buttonRemCliente_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover o cliente?", "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                menuPrincipalObject.Enabled = true;
                return;
            }
            Program.melresCar.RemoverCliente(dataGridViewClientes.CurrentCell.RowIndex);
            Program.melresCar.EscreverFicheiroCSV("clientes");
            atualizaDataGridView();
            MessageBox.Show("Cliente removido com sucesso");
            menuPrincipalObject.Enabled = true;
        }

      

    }
}
