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
    public partial class MenuAdicionarVeiculo : Form
    {

        public MenuAdicionarVeiculo()
        {
            InitializeComponent();
            comboBoxEscolherVeiculo.SelectedIndex = 0;
        }

        private void desativarTextBox()
        {
            textBoxCilindrada.Enabled = false;
            textBoxCaixa.Enabled = false;
            textBoxNportas.Enabled = false;
            textBoxNeixos.Enabled = false;
            textBoxNpassageiros.Enabled = false;
            textBoxPesoMax.Enabled = false;

        }

        private void comboBoxEscolherVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            desativarTextBox();
            if (comboBoxEscolherVeiculo.SelectedIndex == 0)
            {
                textBoxNportas.Enabled = true;
                textBoxCaixa.Enabled = true;
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 1)
            {
                textBoxCilindrada.Enabled = true;
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 2)
            {
                textBoxNeixos.Enabled = true;
                textBoxNpassageiros.Enabled = true;
            } 
            else if (comboBoxEscolherVeiculo.SelectedIndex == 3)
            {               
                textBoxPesoMax.Enabled = true;
            }

        }

        private void buttonAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            switch(comboBoxEscolherVeiculo.SelectedIndex)
            {
                case 0:
                    if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || textBoxAno.Text == "" || textBoxPrecoDiario.Text == "" || textBoxNportas.Text == "" || textBoxCaixa.Text == "")
                    {
                        MessageBox.Show("Por favor preencha todos os campos");
                    }
                    else
                    {
                        if (textBoxMatricula.Text.Length != 8)
                        {
                            MessageBox.Show("Matrícula inválida");
                        }
                        else
                        {
                            if (!Program.melresCar.VerificaInteiro(textBoxAno.Text))
                            {
                                MessageBox.Show("Ano inválido");
                            }
                            else
                            {
                                if (!Program.melresCar.VerificaDecimal(textBoxPrecoDiario.Text))
                                {
                                    MessageBox.Show("Preço inválido");
                                }
                                else
                                {
                                    Carro carro = new Carro(textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, textBoxAno.Text, textBoxPrecoDiario.Text, textBoxNportas.Text, textBoxCaixa.Text);
                                    Program.melresCar.InserirVeiculo(carro);
                                    Program.melresCar.EscreverFicheiroCSV("veiculos");
                                    MessageBox.Show("Veículo adicionado com sucesso");
                                    this.Close();
                                }
                            }
                        }
                    }
                    break;
                    case 1:
                    break;
                    case 2:
                    break;
                    case 3:
                    break;
            }
        }
    }
}
