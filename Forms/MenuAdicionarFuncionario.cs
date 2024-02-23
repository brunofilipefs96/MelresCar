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
    public partial class MenuAdicionarFuncionario : Form
    {
        public MenuAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "" || textBoxUsername.Text == "" || textBoxFirstPassword.Text == "" || textBoxConfirmPassword.Text == "" || numericSalario.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxNif.Text))
                {
                    MessageBox.Show("NIF inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
                    {
                        MessageBox.Show("Telemóvel inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                        {
                            if (textBoxFirstPassword.Text != textBoxConfirmPassword.Text)
                            {
                                MessageBox.Show("As passwords não coincidem", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (textBoxFirstPassword.Text.Length < 8)
                                {
                                    MessageBox.Show("A password tem de ter no mínimo 8 caracteres", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (!Program.melresCar.VerificaDecimal(numericSalario.Text))
                                    {
                                        MessageBox.Show("Salário inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        Funcionario funcionario = new Funcionario(textBoxNome.Text, textBoxNif.Text, textBoxMorada.Text, textBoxEmail.Text, textBoxTelemovel.Text, textBoxUsername.Text, textBoxFirstPassword.Text, Convert.ToDecimal(numericSalario.Text));
                                        Program.melresCar.InserirFuncionario(funcionario);
                                        Program.melresCar.EscreverFicheiroCSV("funcionarios");
                                        MessageBox.Show("Funcionário adicionado com sucesso");
                                        this.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email inválido", "Adicionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            } 
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
