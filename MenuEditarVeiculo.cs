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
            desativarTextBox();
            groupBoxEditarVeiculo.Enabled = false;
            buttonEditarVeiculo.Enabled = false;
        }
        private int _indexVeiculo;
        private void desativarTextBox()
        {
            boxCilindrada.Hide();
            boxCaixa.Hide();
            boxNPortas.Hide();
            boxEixos.Hide();
            boxPassageiros.Hide();
            textBoxPesoMax.Hide();
        }
        private void buttonEditarVeiculo_Click(object sender, EventArgs e)
        {
            Program.melresCar.Veiculos[_indexVeiculo].Marca = textBoxMarca.Text;
            Program.melresCar.Veiculos[_indexVeiculo].Modelo = textBoxModelo.Text;
            Program.melresCar.Veiculos[_indexVeiculo].Matricula = textBoxMatricula.Text;
            Program.melresCar.Veiculos[_indexVeiculo].Ano = Convert.ToInt32(textBoxAno.Text);
            Program.melresCar.Veiculos[_indexVeiculo].PrecoDiario = Convert.ToDecimal(textBoxPrecoDiario.Text);
            Program.melresCar.Veiculos[_indexVeiculo].Estado = boxEstado.Text;
            Program.melresCar.Veiculos[_indexVeiculo].Combustivel = boxCombustivel.Text;
            Program.melresCar.Veiculos[_indexVeiculo].ClasseVeiculo = boxClasse.Text;
            if (comboBoxEscolherVeiculo.SelectedIndex == 0)
            {
                Carro carro = (Carro)Program.melresCar.Veiculos[_indexVeiculo];
                carro.NumPortas = Convert.ToInt32(boxNPortas.Text);
                carro.TipoCaixa = boxCaixa.Text;
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 1)
            {
                Mota mota = (Mota)Program.melresCar.Veiculos[_indexVeiculo];
                mota.Cilindrada = Convert.ToInt32(boxCilindrada.Text);
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 2)
            {
                Camioneta camioneta = (Camioneta)Program.melresCar.Veiculos[_indexVeiculo];
                camioneta.NumEixos = Convert.ToInt32(boxEixos.Text);
                camioneta.NumPassageiros = Convert.ToInt32(boxPassageiros.Text);
            }
            else if (comboBoxEscolherVeiculo.SelectedIndex == 3)
            {
                Camiao camiao = (Camiao)Program.melresCar.Veiculos[_indexVeiculo];
                camiao.PesoMaximo = Convert.ToDouble(textBoxPesoMax.Text);
            }
            Program.melresCar.EscreverFicheiroCSV("veiculos");
            MessageBox.Show("Veiculo alterado com sucesso");
            this.Close();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (boxMatricula.Text == "")
            {
                MessageBox.Show("Introduza a matrícula do veículo que pretende editar");
            }
            else if (boxMatricula.Text.Length != 8)
            {
                MessageBox.Show("A matrícula tem de ter 8 caracteres");
            }
            else
            {
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo.Matricula == boxMatricula.Text)
                    {
                        groupBoxEditarVeiculo.Enabled = true;
                        buttonEditarVeiculo.Enabled = true;
                        _indexVeiculo = Program.melresCar.Veiculos.IndexOf(veiculo);
                        textBoxMarca.Text = veiculo.Marca;
                        textBoxModelo.Text = veiculo.Modelo;
                        textBoxMatricula.Text = veiculo.Matricula;
                        textBoxAno.Text = Convert.ToString(veiculo.Ano);
                        textBoxPrecoDiario.Text = Convert.ToString(veiculo.PrecoDiario);
                        boxEstado.Text = veiculo.Estado;
                        boxCombustivel.Text = veiculo.Combustivel;
                        boxClasse.Text = veiculo.ClasseVeiculo;
                        if (veiculo is Carro)
                        {
                            Carro carro = (Carro)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 0;
                            boxNPortas.Text = Convert.ToString(carro.NumPortas);
                            boxCaixa.Text = carro.TipoCaixa;
                        }
                        else if (veiculo is Mota)
                        {
                            Mota mota = (Mota)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 1;
                            boxCilindrada.Text = Convert.ToString(mota.Cilindrada);
                        }
                        else if (veiculo is Camioneta)
                        {
                            Camioneta camioneta = (Camioneta)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 2;
                            boxEixos.Text = Convert.ToString(camioneta.NumEixos);
                            boxPassageiros.Text = Convert.ToString(camioneta.NumPassageiros);
                        }
                        else if (veiculo is Camiao)
                        {
                            Camiao camiao = (Camiao)veiculo;
                            comboBoxEscolherVeiculo.SelectedIndex = 3;
                            textBoxPesoMax.Text = Convert.ToString(camiao.PesoMaximo);
                        }
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
                        return;
                    }
                }
                MessageBox.Show("Veiculo não encontrado");
                groupBoxEditarVeiculo.Enabled = false;
                buttonEditarVeiculo.Enabled = false;
            }
        }
    }
}