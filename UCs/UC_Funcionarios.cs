using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            dataGridViewFuncionario.BackgroundColor = Color.FromArgb(235, 241, 241);
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            dataGridViewFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Stencil", 12);
            dataGridViewFuncionario.RowHeadersVisible = false;
            dataGridViewFuncionario.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            dataGridViewFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            dataGridViewFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewFuncionario.GridColor = Color.FromArgb(96, 155, 173);
            dataGridViewFuncionario.BorderStyle = BorderStyle.None;
            dataGridViewFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            if (Program.melresCar.LoggedAccount == "admin")
            {
                buttonAddFuncionario.Visible = true;
                buttonEditFuncionario.Visible = true;
                buttonRemFuncionario.Visible = true;
                labelWarningFuncionarios.Visible = false;
            }
            else
            {
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
            if (dataGridViewFuncionario.CurrentCell == null)
            {
                MessageBox.Show("Selecione um funcionário para editar");
                return;
            }
            else
            {
                MenuEditarFuncionario menuEditarFuncionario = new MenuEditarFuncionario();
                menuEditarFuncionario.funcionarioSelecionado(dataGridViewFuncionario.CurrentCell.RowIndex);
                menuEditarFuncionario.Show();
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
            }

        }

        private void buttonRemFuncionario_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionario.CurrentCell == null)
            {
                MessageBox.Show("Selecione um funcionário para editar");
                return;
            }
            else
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
        }

        private void buttonAddFuncionario_Click(object sender, EventArgs e)
        {
            MenuAdicionarFuncionario adicionarFuncionario = new MenuAdicionarFuncionario();
            adicionarFuncionario.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

        private void PaintFuncionarios(object sender, PaintEventArgs e)
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
