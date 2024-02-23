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
    public partial class MenuEditarVeiculo : Form
    {
        public MenuEditarVeiculo()
        {
            InitializeComponent();
            desativarBoxes();
            groupBoxEditarVeiculo.Enabled = false;
            buttonEditarVeiculo.Enabled = false;
            numericPrecoDia.ThousandsSeparator = false;
            numericPesoMax.ThousandsSeparator = false;
        }
        private int _indexVeiculo;
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
        private void buttonEditarVeiculo_Click(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || comboBoxCombustivel.Text == "" || numericAno.Text == "" || numericPrecoDia.Text == "" || comboBoxClasse.Text == "" || comboBoxEstado.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.melresCar.Veiculos[_indexVeiculo].Marca = textBoxMarca.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Modelo = textBoxModelo.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Combustivel = comboBoxCombustivel.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Ano = Convert.ToInt32(numericAno.Text);
                Program.melresCar.Veiculos[_indexVeiculo].PrecoDiario = Convert.ToDecimal(numericPrecoDia.Text);
                Program.melresCar.Veiculos[_indexVeiculo].ClasseVeiculo = comboBoxClasse.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Estado = comboBoxEstado.Text;
                switch (comboBoxEscolherVeiculo.SelectedIndex)
                {
                    case 0:
                        if (comboBoxNumPortas.Text == "" || comboBoxCaixa.Text == "")
                        {
                            MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Carro carro = (Carro)Program.melresCar.Veiculos[_indexVeiculo];
                            carro.NumPortas = Convert.ToInt32(comboBoxNumPortas.Text);
                            carro.TipoCaixa = comboBoxCaixa.Text;
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
                            Mota mota = (Mota)Program.melresCar.Veiculos[_indexVeiculo];
                            mota.Cilindrada = Convert.ToInt32(comboBoxCilindrada.Text);
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
                            Camioneta camioneta = (Camioneta)Program.melresCar.Veiculos[_indexVeiculo];
                            camioneta.NumEixos = Convert.ToInt32(comboBoxEixos.Text);
                            camioneta.NumPassageiros = Convert.ToInt32(numericNumPassageiros.Text);
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
                            Camiao camiao = (Camiao)Program.melresCar.Veiculos[_indexVeiculo];
                            camiao.PesoMaximo = Convert.ToDouble(numericPesoMax.Text);
                            Program.melresCar.EscreverFicheiroCSV("veiculos");
                            MessageBox.Show("Veículo adicionado com sucesso.");
                            this.Close();
                        }
                        break;
                }
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            desativarBoxes();
            if (textBoxProcurarMatricula.Text == "")
            {
                MessageBox.Show("Introduza a matrícula do veículo que pretende editar", "Editar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxProcurarMatricula.Text.Length != 8)
            {
                MessageBox.Show("A matrícula tem de ter 8 caracteres", "Editar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo.Matricula == textBoxProcurarMatricula.Text)
                    {
                        groupBoxEditarVeiculo.Enabled = true;
                        buttonEditarVeiculo.Enabled = true;
                        _indexVeiculo = Program.melresCar.Veiculos.IndexOf(veiculo);
                        textBoxMarca.Text = veiculo.Marca;
                        textBoxModelo.Text = veiculo.Modelo;
                        numericAno.Text = Convert.ToString(veiculo.Ano);
                        numericPrecoDia.Text = Convert.ToString(veiculo.PrecoDiario);
                        comboBoxEstado.Text = veiculo.Estado;
                        comboBoxCombustivel.Text = veiculo.Combustivel;
                        comboBoxClasse.Text = veiculo.ClasseVeiculo;
                        if (veiculo is Carro)
                        {
                            labelNumPortas.Show();
                            comboBoxNumPortas.Show();
                            labelCaixa.Show();
                            comboBoxCaixa.Show();
                            Carro carro = (Carro)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 0;
                            comboBoxNumPortas.Text = Convert.ToString(carro.NumPortas);
                            comboBoxCaixa.Text = carro.TipoCaixa;
                        }
                        else if (veiculo is Mota)
                        {
                            labelCilindrada.Show();
                            comboBoxCilindrada.Show();
                            Mota mota = (Mota)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 1;
                            comboBoxCilindrada.Text = Convert.ToString(mota.Cilindrada);
                        }
                        else if (veiculo is Camioneta)
                        {
                            labelEixos.Show();
                            comboBoxEixos.Show();
                            labelPassageiros.Show();
                            numericNumPassageiros.Show();
                            Camioneta camioneta = (Camioneta)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 2;
                            comboBoxEixos.Text = Convert.ToString(camioneta.NumEixos);
                            numericNumPassageiros.Text = Convert.ToString(camioneta.NumPassageiros);
                        }
                        else if (veiculo is Camiao)
                        {
                            labelPesoMax.Show();
                            numericPesoMax.Show();
                            Camiao camiao = (Camiao)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 3;
                            numericPesoMax.Text = Convert.ToString(camiao.PesoMaximo);
                        }
                        return;
                    }
                }
                MessageBox.Show("Veiculo não encontrado");
                groupBoxEditarVeiculo.Enabled = false;
                buttonEditarVeiculo.Enabled = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxProcurarMatricula_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxProcurarMatricula.Text.Replace("-", "");

            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z0-9]*$"))
            {
                text = System.Text.RegularExpressions.Regex.Replace(text, @"[^a-zA-Z0-9]", "");
            }

            if (text.Length > 2)
                text = text.Insert(2, "-");
            if (text.Length > 5)
                text = text.Insert(5, "-");

            textBoxProcurarMatricula.Text = text;

            textBoxProcurarMatricula.SelectionStart = textBoxProcurarMatricula.Text.Length;
            textBoxProcurarMatricula.SelectionLength = 0;
        }
    }
}