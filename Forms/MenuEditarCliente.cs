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
    public partial class MenuEditarCliente : Form
    {
        private int _indexCliente;

        public MenuEditarCliente()
        {
            InitializeComponent();
        }

        public void clienteSelecionado(int posicao)
        {
            _indexCliente = posicao;
            textBoxNome.Text = Program.melresCar.Clientes[_indexCliente].Nome;
            textBoxNif.Text = Program.melresCar.Clientes[_indexCliente].Nif;
            textBoxMorada.Text = Program.melresCar.Clientes[_indexCliente].Morada;
            textBoxEmail.Text = Program.melresCar.Clientes[_indexCliente].Email;
            textBoxTelemovel.Text = Program.melresCar.Clientes[_indexCliente].Telemovel;
        }

        private void buttonAlterar_Click_1(object sender, EventArgs e)
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
                    if (Program.melresCar.Clientes[_indexCliente].Nif != textBoxNif.Text)
                    {
                        MessageBox.Show("NIF já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (textBoxTelemovel.Text.Length != 9 || !Program.melresCar.VerificaInteiro(textBoxTelemovel.Text))
                        {
                            MessageBox.Show("Telemóvel inválido", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Program.melresCar.VerificaEmail(textBoxEmail.Text))
                            {
                                if (Program.melresCar.VerificaEmailExistente(textBoxEmail.Text))
                                {
                                    if (Program.melresCar.Clientes[_indexCliente].Email != textBoxEmail.Text)
                                    {
                                        MessageBox.Show("Email já existente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        Program.melresCar.Clientes[_indexCliente].Nome = textBoxNome.Text;
                                        Program.melresCar.Clientes[_indexCliente].Nif = textBoxNif.Text;
                                        Program.melresCar.Clientes[_indexCliente].Morada = textBoxMorada.Text;
                                        Program.melresCar.Clientes[_indexCliente].Email = textBoxEmail.Text;
                                        Program.melresCar.Clientes[_indexCliente].Telemovel = textBoxTelemovel.Text;
                                        Program.melresCar.EscreverFicheiroCSV("clientes");
                                        MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                        menuPrincipalObject.ucClientes.atualizaDataGridView();
                                        MessageBox.Show("Cliente alterado com sucesso.");
                                        menuPrincipalObject.Enabled = true;
                                        this.Close();
                                    }
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

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void PaintEditarCliente(object sender, PaintEventArgs e)
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
