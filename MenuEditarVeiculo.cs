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
            
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (textBoxMatricula.Text == "")
            {
                MessageBox.Show("Introduza a matrícula do veículo que pretende editar");
            } else if (textBoxMatricula.Text.Length != 8)
            {
                MessageBox.Show("A matrícula tem de ter 8 caracteres");
            }
            else
            {
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo.Matricula == boxMatricula.Text)
                    {
                        _indexVeiculo = Program.melresCar.Veiculos.IndexOf(veiculo);
                        textBoxMarca.Text = veiculo.Marca;
                        textBoxModelo.Text = veiculo.Modelo;
                        textBoxMatricula.Text = veiculo.Matricula;
                        textBoxAno.Text = Convert.ToString(veiculo.Ano);
                        textBoxPrecoDiario.Text = Convert.ToString(veiculo.PrecoDiario);
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
                    }
                }
                MessageBox.Show("Cliente não encontrado");
     
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
            
        }
    }
}