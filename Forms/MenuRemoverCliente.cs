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
    public partial class MenuRemoverCliente : Form
    {
        private int _indexCliente;
        public MenuRemoverCliente()
        {
            InitializeComponent();
            groupBoxRemoverCliente.Enabled = false;
            buttonRemover.Enabled = false;
        }

        private void buttonRemover_Click_1(object sender, EventArgs e)
        {
            Program.melresCar.RemoverCliente(_indexCliente);
            Program.melresCar.EscreverFicheiroCSV("clientes");
            MessageBox.Show("Cliente removido com sucesso");
            this.Close();
        }

        private void buttonProcurar_Click_1(object sender, EventArgs e)
        {
            if (textBoxCheckNif.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo NIF", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxCheckNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxCheckNif.Text))
            {
                MessageBox.Show("NIF inválido", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                foreach (var cliente in Program.melresCar.Clientes)
                {
                    if (cliente.Nif == textBoxCheckNif.Text)
                    {
                        buttonRemover.Enabled = true;
                        _indexCliente = Program.melresCar.Clientes.IndexOf(cliente);
                        labelNomeCheck.Text = cliente.Nome;
                        labelNifCheck.Text = cliente.Nif;
                        labelMoradaCheck.Text = cliente.Morada;
                        labelEmailCheck.Text = cliente.Email;
                        labelNtelemovelCheck.Text = cliente.Telemovel;
                        return;
                    }
                }
                MessageBox.Show("Cliente não encontrado", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
