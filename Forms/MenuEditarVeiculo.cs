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
    public partial class MenuEditarVeiculo : Form
    {
        private int _indexVeiculo;
        public MenuEditarVeiculo()
        {
            InitializeComponent();
            desativarBoxes();
            numericPrecoDia.ThousandsSeparator = false;
            numericPesoMax.ThousandsSeparator = false;
        }

        public void veiculoSelecionado(int posicao)
        {
            labelVeiculo.Text = "Veiculo: " + Program.melresCar.Veiculos[posicao].Matricula;
            _indexVeiculo = posicao;
            textBoxMarca.Text = Program.melresCar.Veiculos[_indexVeiculo].Marca;
            textBoxModelo.Text = Program.melresCar.Veiculos[_indexVeiculo].Modelo;
            numericAno.Text = Convert.ToString(Program.melresCar.Veiculos[_indexVeiculo].Ano);
            numericPrecoDia.Text = Convert.ToString(Program.melresCar.Veiculos[_indexVeiculo].PrecoDiario);
            comboBoxEstado.Text = Program.melresCar.Veiculos[_indexVeiculo].Estado;
            comboBoxCombustivel.Text = Program.melresCar.Veiculos[_indexVeiculo].Combustivel;
            if (Program.melresCar.Veiculos[_indexVeiculo] is Carro)
            {
                labelNumPortas.Show();
                comboBoxNumPortas.Show();
                labelCaixa.Show();
                comboBoxCaixa.Show();
                Carro carro = (Carro)Program.melresCar.Veiculos[_indexVeiculo];
                comboBoxNumPortas.Text = Convert.ToString(carro.NumPortas);
                comboBoxCaixa.Text = carro.TipoCaixa;
            }
            else if (Program.melresCar.Veiculos[_indexVeiculo] is Mota)
            {
                labelCilindrada.Show();
                comboBoxCilindrada.Show();
                Mota mota = (Mota)Program.melresCar.Veiculos[_indexVeiculo];
                comboBoxCilindrada.Text = Convert.ToString(mota.Cilindrada);
            }
            else if (Program.melresCar.Veiculos[_indexVeiculo] is Camioneta)
            {
                labelEixos.Show();
                comboBoxEixos.Show();
                labelPassageiros.Show();
                numericNumPassageiros.Show();
                Camioneta camioneta = (Camioneta)Program.melresCar.Veiculos[_indexVeiculo];
                comboBoxEixos.Text = Convert.ToString(camioneta.NumEixos);
                numericNumPassageiros.Text = Convert.ToString(camioneta.NumPassageiros);
            }
            else if (Program.melresCar.Veiculos[_indexVeiculo] is Camiao)
            {
                labelPesoMax.Show();
                numericPesoMax.Show();
                Camiao camiao = (Camiao)Program.melresCar.Veiculos[_indexVeiculo];
                numericPesoMax.Text = Convert.ToString(camiao.PesoMaximo);
            }
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
        private void buttonEditarVeiculo_Click_1(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == "" || textBoxModelo.Text == "" || comboBoxCombustivel.Text == "" || numericAno.Text == "" || numericPrecoDia.Text == "" || comboBoxEstado.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string classeVeic = "";
                Program.melresCar.Veiculos[_indexVeiculo].Marca = textBoxMarca.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Modelo = textBoxModelo.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Combustivel = comboBoxCombustivel.Text;
                Program.melresCar.Veiculos[_indexVeiculo].Ano = Convert.ToInt32(numericAno.Text);
                Program.melresCar.Veiculos[_indexVeiculo].PrecoDiario = Convert.ToDecimal(numericPrecoDia.Text);
                Program.melresCar.Veiculos[_indexVeiculo].Estado = comboBoxEstado.Text;
                switch (Program.melresCar.Veiculos[_indexVeiculo].TipoVeiculo)
                {
                    case "carro":
                        if (comboBoxNumPortas.Text == "" || comboBoxCaixa.Text == "")
                        {
                            MessageBox.Show("Por favor preencha todos os campos", "Adicionar Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (comboBoxNumPortas.Text == "3" && comboBoxCombustivel.Text == "gasolina" && comboBoxCaixa.Text == "manual")
                            {
                                classeVeic = "A";    //3 Portas Manual a Gasolina
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "hibrido" && comboBoxCaixa.Text == "automatico")
                            {
                                classeVeic = "B";    //5 Portas automático e Hibrido
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasolina")
                            {
                                classeVeic = "C";    //Pequeno 5 Portas a Gasolina
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasoleo")
                            {
                                classeVeic = "D";    //Pequeno 5 Portas a Gasoleo   
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasolina")
                            {
                                classeVeic = "F";    //Médio 5 Portas a Gasolina
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasoleo")
                            {
                                classeVeic = "G";    //Médio 5 Portas a Gasoleo
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasoleo")
                            {
                                classeVeic = "H";    //Station Wagon 5 Portas a Diesel
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "eletrico")
                            {
                                classeVeic = "I";    //Médio Elétrico 5 Portas
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasolina" || comboBoxCombustivel.Text == "gasoleo")
                            {
                                classeVeic = "J";    //SUV 5 Portas a Diesel/Gasolina
                            }
                            else if (comboBoxNumPortas.Text == "5" && comboBoxCombustivel.Text == "gasoleo" || comboBoxCombustivel.Text == "gasolina")
                            {
                                classeVeic = "L";   //Executivo/Desportivo Premium 5 Portas
                            }
                            Carro carro = (Carro)Program.melresCar.Veiculos[_indexVeiculo];
                            carro.ClasseVeiculo = classeVeic;
                            carro.NumPortas = Convert.ToInt32(comboBoxNumPortas.Text);
                            carro.TipoCaixa = comboBoxCaixa.Text;
                            Program.melresCar.EscreverFicheiroCSV("veiculos");
                            MessageBox.Show("Carro adicionado com sucesso.");
                            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                            menuPrincipalObject.ucVeiculo.atualizaDataGridView(0);
                            menuPrincipalObject.Enabled = true;
                            this.Close();
                        }
                        break;
                    case "mota":
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
                            Mota mota = (Mota)Program.melresCar.Veiculos[_indexVeiculo];
                            mota.ClasseVeiculo = classeVeic;
                            mota.Cilindrada = Convert.ToInt32(comboBoxCilindrada.Text);
                            Program.melresCar.EscreverFicheiroCSV("veiculos");
                            MessageBox.Show("Mota adicionada com sucesso.");
                            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                            menuPrincipalObject.ucVeiculo.atualizaDataGridView(1);
                            menuPrincipalObject.Enabled = true;
                            this.Close();
                        }
                        break;
                    case "camioneta":
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
                            Camioneta camioneta = (Camioneta)Program.melresCar.Veiculos[_indexVeiculo];
                            camioneta.ClasseVeiculo = classeVeic;
                            camioneta.NumEixos = Convert.ToInt32(comboBoxEixos.Text);
                            camioneta.NumPassageiros = Convert.ToInt32(numericNumPassageiros.Text);
                            Program.melresCar.EscreverFicheiroCSV("veiculos");
                            MessageBox.Show("Camioneta adicionada com sucesso.");
                            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                            menuPrincipalObject.ucVeiculo.atualizaDataGridView(2);
                            menuPrincipalObject.Enabled = true;
                            this.Close();
                        }
                        break;
                    case "camiao":
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
                            Camiao camiao = (Camiao)Program.melresCar.Veiculos[_indexVeiculo];
                            camiao.ClasseVeiculo = classeVeic;
                            camiao.PesoMaximo = Convert.ToDouble(numericPesoMax.Text);
                            Program.melresCar.EscreverFicheiroCSV("veiculos");
                            MessageBox.Show("Camião adicionado com sucesso.");
                            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                            menuPrincipalObject.ucVeiculo.atualizaDataGridView(3);
                            menuPrincipalObject.Enabled = true;
                            this.Close();
                        }
                        break;
                }
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void PaintEditarVeiculo(object sender, PaintEventArgs e)
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