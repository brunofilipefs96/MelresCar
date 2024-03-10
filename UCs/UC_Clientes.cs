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
            dataGridViewClientes.Columns.Add("NumCliente", "Nº Cliente");
            dataGridViewClientes.Columns.Add("Nome", "Nome");
            dataGridViewClientes.Columns.Add("Nif", "NIF");
            dataGridViewClientes.Columns.Add("Morada", "Morada");
            dataGridViewClientes.Columns.Add("Email", "Email");
            dataGridViewClientes.Columns.Add("Telemovel", "Telemovel");


            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.MultiSelect = false;


            dataGridViewClientes.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Stencil", 12);
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            dataGridViewClientes.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewClientes.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewClientes.BorderStyle = BorderStyle.None;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;


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
            if (dataGridViewClientes.CurrentCell == null)
            {
                MessageBox.Show("Selecione um cliente para editar");
                return;
            }
            else
            {
                MenuEditarCliente editarCliente = new MenuEditarCliente();
                editarCliente.clienteSelecionado(dataGridViewClientes.CurrentCell.RowIndex);
                editarCliente.Show();
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
            }
        }

        private void buttonRemCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentCell == null)
            {
                MessageBox.Show("Selecione um cliente para remover");
                return;
            }
            else
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


        private void PaintClientes(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
