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
    public partial class MenuAdicionarCliente : Form
    {
        public MenuAdicionarCliente()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxNif.Text))
                {
                    MessageBox.Show("NIF inválido", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Program.melresCar.VerificaNifExistente(textBoxNif.Text))
                {
                    MessageBox.Show("NIF já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
                {
                    MessageBox.Show("Telemóvel inválido", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Program.melresCar.VerificaTelemovelExistente(textBoxTelemovel.Text))
                    {
                        MessageBox.Show("Telemóvel já existente!", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                        {
                            if (Program.melresCar.VerificaEmailExistente(textBoxEmail.Text))
                            {
                                MessageBox.Show("Email já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Cliente cliente = new Cliente(textBoxNome.Text, textBoxNif.Text, textBoxMorada.Text, textBoxEmail.Text, textBoxTelemovel.Text);
                                Program.melresCar.InserirCliente(cliente);
                                Program.melresCar.EscreverFicheiroCSV("clientes");
                                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                menuPrincipalObject.ucClientes.atualizaDataGridView();
                                menuPrincipalObject.Enabled = true;
                                MessageBox.Show("Cliente adicionado com sucesso");
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Email inválido", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
