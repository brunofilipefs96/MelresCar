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
    public partial class MenuRemoverVeiculo : Form
    {
        public MenuRemoverVeiculo()
        {
            InitializeComponent();
            desativarBoxes();
            comboBoxEscolherVeiculo.Enabled = false;
            buttonRemoverVeiculo.Enabled = false;
        }

        private void desativarBoxes()
        {
            labelCilindrada.Hide();
            labelCilindradaCheck.Hide();
            labelCaixa.Hide();
            labelCaixaCheck.Hide();
            labelNumPortas.Hide();
            labelNumPortasCheck.Hide();
            labelEixos.Hide();
            labelEixosCheck.Hide();
            labelNumPassageiros.Hide();
            labelNumPassageirosCheck.Hide();
            labelPesoMax.Hide();
            labelPesoMaxCheck.Hide();
        }

        private void buttonRemoverVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                        buttonRemoverVeiculo.Enabled = true;
                        labelMarcaCheck.Text = veiculo.Marca;
                        labelModeloCheck.Text = veiculo.Modelo;
                        labelCombustivelCheck.Text = veiculo.Combustivel;
                        labelAnoCheck.Text = Convert.ToString(veiculo.Ano);
                        labelPrecoCheck.Text = Convert.ToString(veiculo.PrecoDiario);
                        if (veiculo is Carro)
                        {
                            comboBoxEscolherVeiculo.SelectedIndex = 0;
                            labelNumPortas.Show();
                            labelNumPortasCheck.Show();
                            labelCaixa.Show();
                            labelCaixaCheck.Show();
                            labelNumPortasCheck.Text = Convert.ToString(((Carro)veiculo).NumPortas);
                            labelCaixaCheck.Text = ((Carro)veiculo).TipoCaixa;
                        }
                        else if(veiculo is Mota)
                        {
                            comboBoxEscolherVeiculo.SelectedIndex = 1;
                            labelCilindrada.Show();
                            labelCilindradaCheck.Show();
                            labelCilindradaCheck.Text = Convert.ToString(((Mota)veiculo).Cilindrada);
                        }
                        else if(veiculo is Camioneta)
                        {
                            comboBoxEscolherVeiculo.SelectedIndex = 2;
                            labelEixos.Show();
                            labelEixosCheck.Show();
                            labelNumPassageiros.Show();
                            labelNumPassageirosCheck.Show();
                            labelEixosCheck.Text = Convert.ToString(((Camioneta)veiculo).NumEixos);
                            labelNumPassageirosCheck.Text = Convert.ToString(((Camioneta)veiculo).NumPassageiros);
                        }
                        else if(veiculo is Camiao)
                        {
                            comboBoxEscolherVeiculo.SelectedIndex = 3;
                            labelPesoMax.Show();
                            labelPesoMaxCheck.Show();
                            labelPesoMaxCheck.Text = Convert.ToString(((Camiao)veiculo).PesoMaximo);
                        }
                        return;
                    }
                }
                buttonRemoverVeiculo.Enabled = false;
                MessageBox.Show("Veiculo não encontrado");
            }
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
