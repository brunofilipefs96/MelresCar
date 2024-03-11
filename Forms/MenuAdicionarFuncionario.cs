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
    public partial class MenuAdicionarFuncionario : Form
    {
        public MenuAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click_1(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "" || textBoxUsername.Text == "" || textBoxFirstPassword.Text == "" || textBoxConfirmPassword.Text == "" || numericSalario.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxNif.Text))
            {
                MessageBox.Show("NIF inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Program.melresCar.VerificaNifExistente(textBoxNif.Text))
            {
                MessageBox.Show("NIF já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
            {
                MessageBox.Show("Telemóvel inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                {
                    if (Program.melresCar.VerificaEmailExistente(textBoxEmail.Text))
                    {
                        MessageBox.Show("Email já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Program.melresCar.VerificaUsernameExistente(textBoxUsername.Text))
                    {
                        MessageBox.Show("Username já existente", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (textBoxFirstPassword.Text.Length < 8)
                    {
                        MessageBox.Show("A password tem de ter no mínimo 8 caracteres", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (textBoxFirstPassword.Text != textBoxConfirmPassword.Text)
                    {
                        MessageBox.Show("As passwords não coincidem", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Program.melresCar.VerificaDecimal(numericSalario.Text))
                    {
                        MessageBox.Show("Salário inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Funcionario funcionario = new Funcionario(textBoxNome.Text, textBoxNif.Text, textBoxMorada.Text, textBoxEmail.Text, textBoxTelemovel.Text, textBoxUsername.Text, textBoxFirstPassword.Text, Convert.ToDecimal(numericSalario.Text));
                        Program.melresCar.InserirFuncionario(funcionario);
                        Program.melresCar.EscreverFicheiroCSV("funcionarios");
                        MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                        menuPrincipalObject.ucFuncionario.atualizaDataGridView();
                        menuPrincipalObject.Enabled = true;
                        MessageBox.Show("Funcionário adicionado com sucesso");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Email inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void PaintAdicionarFuncionario(object sender, PaintEventArgs e)
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
