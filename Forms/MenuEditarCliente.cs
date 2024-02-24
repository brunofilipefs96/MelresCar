﻿using System;
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
    public partial class MenuEditarCliente : Form
    {
        private int _indexCliente;
        public MenuEditarCliente()
        {
            InitializeComponent();
            groupBoxEditarCliente.Enabled = false;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (textBoxCheckNif.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo NIF");
            }else if (textBoxCheckNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxCheckNif.Text))
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
                        groupBoxEditarCliente.Enabled = true;
                        buttonAlterar.Enabled = true;
                        return;
                    }
                }
                MessageBox.Show("Cliente não encontrado");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxNif.Text == "" || textBoxMorada.Text == "" || textBoxEmail.Text == "" || textBoxTelemovel.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxNif.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxNif.Text))
                {
                    MessageBox.Show("NIF inválido", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
                    {
                        MessageBox.Show("Telemóvel inválido", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                        {
                            Program.melresCar.Clientes[_indexCliente].Nome = textBoxName.Text;
                            Program.melresCar.Clientes[_indexCliente].Nif = textBoxNif.Text;
                            Program.melresCar.Clientes[_indexCliente].Morada = textBoxMorada.Text;
                            Program.melresCar.Clientes[_indexCliente].Email = textBoxEmail.Text;
                            Program.melresCar.Clientes[_indexCliente].Telemovel = textBoxTelemovel.Text;
                            Program.melresCar.EscreverFicheiroCSV("clientes");
                            MessageBox.Show("Cliente alterado com sucesso.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email inválido", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}