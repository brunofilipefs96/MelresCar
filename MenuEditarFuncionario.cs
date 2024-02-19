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
    
    public partial class MenuEditarFuncionario : Form
    {
        private int _indexFuncionario;
        public MenuEditarFuncionario()
        {
            InitializeComponent();
            groupBoxEditarFuncionario.Enabled = false;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if(textBoxLoginUsername.Text == "" || textBoxLoginPassword.Text == "")
            {
                MessageBox.Show("Preencha os dois campos.");
            } else
            {
                foreach(var funcionario in Program.melresCar.Funcionarios)
                {
                    if(funcionario.Username == textBoxLoginUsername.Text && funcionario.Password == textBoxLoginPassword.Text)
                    {
                        _indexFuncionario = Program.melresCar.Funcionarios.IndexOf(funcionario);
                        textBoxName.Text = funcionario.Nome;
                        textBoxNif.Text = funcionario.Nif;
                        textBoxMorada.Text = funcionario.Morada;
                        textBoxEmail.Text = funcionario.Email;
                        textBoxTelemovel.Text = funcionario.Telemovel;
                        textBoxUsername.Text = funcionario.Username;
                        textBoxFirstPassword.Text = funcionario.Password;
                        textBoxConfirmPassword.Text = funcionario.Password;
                        textBoxSalario.Text = funcionario.Salario.ToString();
                        groupBoxEditarFuncionario.Enabled = true;
                        buttonAlterar.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "" || textBoxUsername.Text == "" || textBoxFirstPassword.Text == "" || textBoxConfirmPassword.Text == "" || textBoxSalario.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos");
            }
            else
            {
                if (textBoxNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxNif.Text))
                {
                    MessageBox.Show("NIF inválido");
                }
                else
                {
                    if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
                    {
                        MessageBox.Show("Telemóvel inválido");
                    }
                    else
                    {
                        if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                        {
                            if (textBoxFirstPassword.Text != textBoxConfirmPassword.Text)
                            {
                                MessageBox.Show("As passwords não coincidem");
                            }
                            else
                            {
                                if (textBoxFirstPassword.Text.Length < 8)
                                {
                                    MessageBox.Show("A password tem de ter no mínimo 8 caracteres");
                                }
                                else
                                {
                                    if (!Program.melresCar.VerificaDecimal(textBoxSalario.Text))
                                    {
                                        MessageBox.Show("Salário inválido");
                                    }
                                    else
                                    {
                                        Program.melresCar.Funcionarios[_indexFuncionario].Nome = textBoxName.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Nif = textBoxNif.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Morada = textBoxMorada.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Email = textBoxEmail.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Telemovel = textBoxTelemovel.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Username = textBoxUsername.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Password = textBoxFirstPassword.Text;
                                        Program.melresCar.Funcionarios[_indexFuncionario].Salario = Convert.ToDecimal(textBoxSalario.Text);
                                        Program.melresCar.EscreverFicheiroCSV("funcionarios");
                                        MessageBox.Show("Funcionário atualizado com sucesso");
                                        this.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
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
