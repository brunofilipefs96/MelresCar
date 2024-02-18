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

        private void buttonAdicionar_Click_2(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "")
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
                            Cliente cliente = new Cliente(textBoxName.Text, textBoxNif.Text, textBoxMorada.Text, textBoxEmail.Text, textBoxTelemovel.Text);
                            Program.melresCar.InserirCliente(cliente);
                            Program.melresCar.EscreverFicheiroCSV("clientes");
                            MessageBox.Show("Cliente adicionado com sucesso");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
                        }
                    }
                }
            }
        }
    }
}
