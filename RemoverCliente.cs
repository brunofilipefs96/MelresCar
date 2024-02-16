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
    public partial class RemoverCliente : Form
    {
        private int _indexCliente;
        public RemoverCliente()
        {
            InitializeComponent();
            groupBoxRemoverCliente.Enabled = false;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (textBoxCheckNif.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo NIF");
            }
            else if (textBoxCheckNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxCheckNif.Text))
            {
                MessageBox.Show("NIF inválido");
                return;
            }
            else
            {
                foreach (var cliente in Program.melresCar.Clientes)
                {
                    if (cliente.Nif == textBoxCheckNif.Text)
                    {
                        _indexCliente = Program.melresCar.Clientes.IndexOf(cliente);
                        textBoxName.Text = cliente.Nome;
                        textBoxNif.Text = cliente.Nif;
                        textBoxMorada.Text = cliente.Morada;
                        textBoxEmail.Text = cliente.Email;
                        textBoxTelemovel.Text = cliente.Telemovel;
                        groupBoxRemoverCliente.Enabled = true;
                        buttonRemover.Enabled = true;
                        textBoxName.Enabled = false;
                        textBoxNif.Enabled = false;
                        textBoxMorada.Enabled = false;
                        textBoxEmail.Enabled = false;
                        textBoxTelemovel.Enabled = false;
                        return;
                    }
                }
                MessageBox.Show("Cliente não encontrado");
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Program.melresCar.RemoverCliente(_indexCliente);
            Program.melresCar.EscreverFicheiroCSV("clientes");
            MessageBox.Show("Cliente removido com sucesso");
            this.Close();
        }
    }
}
