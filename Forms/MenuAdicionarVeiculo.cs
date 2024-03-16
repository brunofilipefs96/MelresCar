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

        private void buttonAdicionarVeiculo_Click_1(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || textBoxMatricula.Text == "" || comboBoxCombustivel.Text == "" || numericAno.Text == "" || numericPrecoDia.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxMatricula.Text.Length != 8)
                {
                    MessageBox.Show("Matrícula inválida", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Program.melresCar.VerificaMatriculaExistente(textBoxMatricula.Text))
                {
                    MessageBox.Show("A Matrícula que inseriu já se encontra na base de dados!", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string classeVeic = "";
                    switch (comboBoxEscolherVeiculo.SelectedIndex)
                    {
                        case 0:
                            if (comboBoxNumPortas.Text == "" || comboBoxCaixa.Text == "")
                            {
                                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }  
                            else
                            {
                                if (comboBoxCombustivel.Text == "gasolina")
                                {
                                    if (comboBoxNumPortas.Text == "3")
                                    {
                                        classeVeic = "A";
                                    }
                                    else if (comboBoxNumPortas.Text == "5")
                                    {
                                        if (numericPrecoDia.Value <= 20)
                                        {
                                            classeVeic = "C";
                                        }
                                        else if (numericPrecoDia.Value > 20 && numericPrecoDia.Value <= 70)
                                        {
                                            classeVeic = "F";
                                        }
                                        else if (numericPrecoDia.Value > 70)
                                        {
                                            classeVeic = "L";
                                        }
                                    }
                                }
                                else if (comboBoxCombustivel.Text == "gasoleo")
                                {
                                    if (comboBoxNumPortas.Text == "3")
                                    {
                                        classeVeic = "D";
                                    }
                                    else if (comboBoxNumPortas.Text == "5")
                                    {
                                        if (numericPrecoDia.Value <= 40)
                                        {
                                            classeVeic = "G";
                                        }
                                        else if (numericPrecoDia.Value > 40 && numericPrecoDia.Value <= 60)
                                        {
                                            classeVeic = "H";
                                        }
                                        else if (numericPrecoDia.Value > 60)
                                        {
                                            classeVeic = "J";
                                        }
                                    }
                                }
                                else if (comboBoxCombustivel.Text == "hibrido")
                                {
                                    classeVeic = "B";
                                }
                                else if (comboBoxCombustivel.Text == "eletrico")
                                {
                                    classeVeic = "I";
                                }

                                Carro carro = new Carro("carro", classeVeic, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), Convert.ToDecimal(numericPrecoDia.Text), Convert.ToInt32(comboBoxNumPortas.Text), comboBoxCaixa.Text);
                                Program.melresCar.InserirVeiculo(carro);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Carro adicionado com sucesso.");
                                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                menuPrincipalObject.ucVeiculo.atualizaDataGridView(comboBoxEscolherVeiculo.SelectedIndex);
                                menuPrincipalObject.Enabled = true;
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
                                if (comboBoxCilindrada.SelectedIndex == 0)
                                {
                                    classeVeic = "A";
                                }
                                else if (comboBoxCilindrada.SelectedIndex == 1)
                                {
                                    classeVeic = "B";
                                }
                                else if (comboBoxCilindrada.SelectedIndex == 2)
                                {
                                    classeVeic = "C";
                                }
                                Mota mota = new Mota("mota", classeVeic, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), Convert.ToDecimal(numericPrecoDia.Text), Convert.ToInt32(comboBoxCilindrada.Text));
                                Program.melresCar.InserirVeiculo(mota);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Mota adicionada com sucesso.");
                                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                menuPrincipalObject.ucVeiculo.atualizaDataGridView(comboBoxEscolherVeiculo.SelectedIndex);
                                menuPrincipalObject.Enabled = true;
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
                                if (numericNumPassageiros.Value <= 8)
                                {
                                    classeVeic = "A";
                                }
                                else if (numericNumPassageiros.Value <= 16)
                                {
                                    classeVeic = "B";
                                }
                                else if (numericNumPassageiros.Value <= 64)
                                {
                                    classeVeic = "C";
                                }
                                Camioneta camioneta = new Camioneta("camioneta", classeVeic, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), Convert.ToDecimal(numericPrecoDia.Text), Convert.ToInt32(comboBoxEixos.Text), Convert.ToInt32(numericNumPassageiros.Text));
                                Program.melresCar.InserirVeiculo(camioneta);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Camioneta adicionada com sucesso.");
                                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                menuPrincipalObject.ucVeiculo.atualizaDataGridView(comboBoxEscolherVeiculo.SelectedIndex);
                                menuPrincipalObject.Enabled = true;
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
                                if (numericPesoMax.Value <= 3500)
                                {
                                    classeVeic = "A";
                                }
                                else if (numericPesoMax.Value <= 8000)
                                {
                                    classeVeic = "B";
                                }
                                else if (numericPesoMax.Value <= 24000)
                                {
                                    classeVeic = "C";
                                }
                                Camiao camiao = new Camiao("camiao", classeVeic, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text, comboBoxCombustivel.Text, Convert.ToInt32(numericAno.Text), Convert.ToDecimal(numericPrecoDia.Text), DateTime.Today, Convert.ToDouble(numericPesoMax.Text));
                                Program.melresCar.InserirVeiculo(camiao);
                                Program.melresCar.EscreverFicheiroCSV("veiculos");
                                MessageBox.Show("Camião adicionado com sucesso.");
                                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                                menuPrincipalObject.ucVeiculo.atualizaDataGridView(comboBoxEscolherVeiculo.SelectedIndex);
                                menuPrincipalObject.Enabled = true;
                                this.Close();
                            }
                            break;
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

        private void PaintAdicionarVeiculo(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void pintaAno(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void comboBoxCombustivel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCombustivel.Text == "eletrico")
            {
                comboBoxCaixa.SelectedIndex = 1;
                comboBoxCaixa.Enabled = false;
            }
            else if (comboBoxCombustivel.Text == "hibrido")
            {
                comboBoxCaixa.SelectedIndex = 1;
                comboBoxCaixa.Enabled = false;
            }
            else
            {
                comboBoxCaixa.Enabled = true;
            }

        }
    }
}