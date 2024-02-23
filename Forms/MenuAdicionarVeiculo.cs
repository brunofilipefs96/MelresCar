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
            numericPrecoDia.ThousandsSeparator = false;
            numericPesoMax.ThousandsSeparator = false;
        }

        private void desativarBoxes()
        {
            labelCilindrada.Hide();
            comboBoxCilindrada.Hide();
            labelCaixa.Hide();
            comboBoxCaixa.Hide();
            labelNumPortas.Hide();
            comboBoxNumPortas.Hide();
            labelEixos.Hide();
            comboBoxEixos.Hide();
            labelPassageiros.Hide();
            numericNumPassageiros.Hide();
            labelPesoMax.Hide();
            numericPesoMax.Hide();
        }

        private void comboBoxEscolherVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            desativarBoxes();
            if (comboBoxEscolherVeiculo.SelectedIndex == 0)
            {
                labelNumPortas.Show();
                comboBoxNumPortas.Show();
                labelCaixa.Show();
                comboBoxCaixa.Show();
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 1)
            {
                labelCilindrada.Show();
                comboBoxCilindrada.Show();
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 2)
            {
                labelEixos.Show();
                comboBoxEixos.Show();
                labelPassageiros.Show();
                numericNumPassageiros.Show();
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 3)
            {
                labelPesoMax.Show();
                numericPesoMax.Show();
            }
        }

        private void buttonAdicionarVeiculo_Click(object sender, EventArgs e)
        {

            if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || comboBoxCombustivel.Text == "" || numericAno.Text == "" || numericPrecoDia.Text == "" || comboBoxClasse.Text == "" || comboBoxEstado.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxMatricula.Text.Length != 8)
                {
                    MessageBox.Show("Matrícula inválida", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    switch (comboBoxEscolherVeiculo.SelectedIndex)
                    {
                        case 0:
                            if (comboBoxNumPortas.Text == "" || comboBoxCaixa.Text == "")
                            {
                                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Carro carro = new Carro("carro", comboBoxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), comboBoxEstado.Text, Convert.ToDecimal(numericPrecoDia.Text), DateTime.Today, Convert.ToInt32(comboBoxNumPortas.Text), comboBoxCaixa.Text);
                                Program.melresCar.InserirVeiculo(carro);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Veículo adicionado com sucesso.");
                                this.Close();
                            }
                            break;
                        case 1:
                            if (comboBoxCilindrada.Text == "")
                            {
                                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Mota mota = new Mota("mota", comboBoxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), comboBoxEstado.Text, Convert.ToDecimal(numericPrecoDia.Text), DateTime.Today, Convert.ToInt32(comboBoxCilindrada.Text));
                                Program.melresCar.InserirVeiculo(mota);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Veículo adicionado com sucesso.");
                                this.Close();
                            }
                            break;
                        case 2:
                            if (comboBoxEixos.Text == "" || numericNumPassageiros.Text == "")
                            {
                                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Camioneta camioneta = new Camioneta("camioneta", comboBoxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), comboBoxEstado.Text, Convert.ToDecimal(numericPrecoDia.Text), DateTime.Today, Convert.ToInt32(comboBoxEixos.Text), Convert.ToInt32(numericNumPassageiros.Text));
                                Program.melresCar.InserirVeiculo(camioneta);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Veículo adicionado com sucesso.");
                                this.Close();
                            }
                            break;
                        case 3:
                            if (numericPesoMax.Text == "")
                            {
                                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Camiao camiao = new Camiao("camiao", comboBoxClasse.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), comboBoxEstado.Text, Convert.ToDecimal(numericPrecoDia.Text), DateTime.Today, Convert.ToDouble(numericPesoMax.Text));
                                Program.melresCar.InserirVeiculo(camiao);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Veículo adicionado com sucesso.");
                                this.Close();
                            }
                            break;
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCombustivel.Text == "eletrico")
            {
                comboBoxCaixa.SelectedIndex = 1;
                comboBoxCaixa.Enabled = false;
            }
            else
            {
                comboBoxCaixa.Enabled = true;
            }
        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxMatricula.Text.Replace("-", "");

            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z0-9]*$"))
            {
                text = System.Text.RegularExpressions.Regex.Replace(text, @"[^a-zA-Z0-9]", "");
            }

            if (text.Length > 2)
                text = text.Insert(2, "-");
            if (text.Length > 5)
                text = text.Insert(5, "-");

            textBoxMatricula.Text = text;

            textBoxMatricula.SelectionStart = textBoxMatricula.Text.Length;
            textBoxMatricula.SelectionLength = 0;
        }

    }
}