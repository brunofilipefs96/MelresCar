using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class UC_Funcionarios : UserControl
    {
        public UC_Funcionarios()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewFuncionario.AllowUserToAddRows = false;
            dataGridViewFuncionario.RowCount = 0;
            dataGridViewFuncionario.Columns.Add("IdFuncionario", "ID");
            dataGridViewFuncionario.Columns.Add("Nome", "Nome");
            dataGridViewFuncionario.Columns.Add("Nif", "NIF");
            dataGridViewFuncionario.Columns.Add("Morada", "Morada");
            dataGridViewFuncionario.Columns.Add("Email", "Email");
            dataGridViewFuncionario.Columns.Add("Telemovel", "Telemovel");
            atualizaDataGridView();

            dataGridViewFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuncionario.MultiSelect = false;
            dataGridViewFuncionario.EnableHeadersVisualStyles = false;
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewFuncionario.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewFuncionario.RowsDefaultCellStyle.ForeColor = Color.White;

            if (Program.melresCar.LoggedAccount == "admin")
            {
                buttonAddFuncionario.Visible = true;
                buttonEditFuncionario.Visible = true;
                buttonRemFuncionario.Visible = true;
                labelWarningFuncionarios.Visible = false;
            }
            else {                 
                buttonAddFuncionario.Visible = false;
                buttonEditFuncionario.Visible = false;
                buttonRemFuncionario.Visible = false;
                labelWarningFuncionarios.Visible = true;
            }


        }

        public void atualizaDataGridView()
        {
            dataGridViewFuncionario.Rows.Clear();
            foreach (var funcionario in Program.melresCar.Funcionarios)
            {
                dataGridViewFuncionario.Rows.Add(funcionario.IdFuncionario, funcionario.Nome, funcionario.Nif, funcionario.Morada, funcionario.Email, funcionario.Telemovel);
            }
        }

        private void buttonEditFuncionario_Click(object sender, EventArgs e)
        {
            MenuEditarFuncionario menuEditarFuncionario = new MenuEditarFuncionario();
            menuEditarFuncionario.funcionarioSelecionado(dataGridViewFuncionario.CurrentCell.RowIndex);
            menuEditarFuncionario.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

        private void buttonRemFuncionario_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover o Funcionário?", "Remover Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                menuPrincipalObject.Enabled = true;
                return;
            }
            Program.melresCar.RemoverFuncionario(dataGridViewFuncionario.CurrentCell.RowIndex);
            Program.melresCar.EscreverFicheiroCSV("funcionarios");
            atualizaDataGridView();
            MessageBox.Show("Funcionário removido com sucesso");
            menuPrincipalObject.Enabled = true;
        }

        private void buttonAddFuncionario_Click(object sender, EventArgs e)
        {
            MenuAdicionarFuncionario adicionarFuncionario = new MenuAdicionarFuncionario();
            adicionarFuncionario.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

      
    }
}
