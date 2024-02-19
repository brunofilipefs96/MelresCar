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
                                        Funcionario funcionario = new Funcionario(textBoxName.Text, textBoxNif.Text, textBoxMorada.Text, textBoxEmail.Text, textBoxTelemovel.Text, textBoxUsername.Text, textBoxFirstPassword.Text, Convert.ToDecimal(textBoxSalario.Text));
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
