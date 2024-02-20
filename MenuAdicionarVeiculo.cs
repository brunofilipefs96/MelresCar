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
            boxCilindrada.Hide();
            boxCaixa.Hide();
            boxNPortas.Hide();
            boxEixos.Hide();
            boxPassageiros.Hide();
            textBoxPesoMax.Hide();
        }

        private void comboBoxEscolherVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            desativarTextBox();
            if (comboBoxEscolherVeiculo.SelectedIndex == 0)
            {
                boxNPortas.Show();
                boxCaixa.Show();
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 1)
            {
                boxCilindrada.Show();
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 2)
            {

                boxEixos.Show();
                boxPassageiros.Show();
            } 
            else if (comboBoxEscolherVeiculo.SelectedIndex == 3)
            {               
                textBoxPesoMax.Show();
            }

        }

        private void buttonAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            switch(comboBoxEscolherVeiculo.SelectedIndex)
            {
                case 0:
                    if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || textBoxAno.Text == "" || textBoxPrecoDiario.Text == "" || boxNPortas.Text == "" || boxCaixa.Text == "")
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
                                    Carro carro = new Carro("Carro", boxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, boxCombustivel.Text, Convert.ToInt32(textBoxAno.Text), boxEstado.Text, Convert.ToDecimal(textBoxPrecoDiario.Text), DateTime.Today, Convert.ToInt32(boxNPortas.Text), boxCaixa.Text);
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
                    if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || textBoxAno.Text == "" || textBoxPrecoDiario.Text == "" || boxCilindrada.Text == "")
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
                                    Mota mota = new Mota("Mota", boxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, boxCombustivel.Text, Convert.ToInt32(textBoxAno.Text), boxEstado.Text, Convert.ToDecimal(textBoxPrecoDiario.Text), DateTime.Today, Convert.ToInt32(boxCilindrada.Text));
                                    Program.melresCar.InserirVeiculo(mota);
                                    Program.melresCar.EscreverFicheiroCSV("veiculos");
                                    MessageBox.Show("Veículo adicionado com sucesso");
                                    this.Close();
                                }
                            }
                        }
                    }
                    break;

                    case 2:
                    if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || textBoxAno.Text == "" || textBoxPrecoDiario.Text == "" || boxEixos.Text == "" || boxPassageiros.Text == "")
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
                                    Camioneta camioneta = new Camioneta("camioneta", boxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, boxCombustivel.Text, Convert.ToInt32(textBoxAno.Text), boxEstado.Text, Convert.ToDecimal(textBoxPrecoDiario.Text), DateTime.Today, Convert.ToInt32(boxEixos.Text), Convert.ToInt32(boxPassageiros.Text));
                                    Program.melresCar.InserirVeiculo(camioneta);
                                    Program.melresCar.EscreverFicheiroCSV("veiculos");
                                    MessageBox.Show("Veículo adicionado com sucesso");
                                    this.Close();
                                }
                            }
                        }
                    }   
                    break;

                    case 3:
                    if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || textBoxAno.Text == "" || textBoxPrecoDiario.Text == "" || textBoxPesoMax.Text == "")
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
                                    Camiao camiao = new Camiao("camiao", boxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, boxCombustivel.Text, Convert.ToInt32(textBoxAno.Text), boxEstado.Text, Convert.ToDecimal(textBoxPrecoDiario.Text), DateTime.Today, Convert.ToDouble(textBoxPesoMax.Text));
                                    Program.melresCar.InserirVeiculo(camiao);
                                    Program.melresCar.EscreverFicheiroCSV("veiculos");
                                    MessageBox.Show("Veículo adicionado com sucesso");
                                    this.Close();
                                }
                            }
                        }
                    }
                    break;
            }
        }
    }
}
