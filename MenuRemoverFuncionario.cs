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
    public partial class MenuRemoverFuncionario : Form
    {
        private int _indexFuncionario;
        public MenuRemoverFuncionario()
        {
            InitializeComponent();
            groupBoxRemoverFuncionario.Enabled = false;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (textBoxLoginUsername.Text == "" || textBoxLoginPassword.Text == "")
            {
                MessageBox.Show("Preencha os dois campos.");
            }
            else
            {
                foreach (var funcionario in Program.melresCar.Funcionarios)
                {
                    if (funcionario.Username == textBoxLoginUsername.Text && funcionario.Password == textBoxLoginPassword.Text)
                    {
                        _indexFuncionario = Program.melresCar.Funcionarios.IndexOf(funcionario);
                        labelNomeCheck.Text = funcionario.Nome;
                        labelNifCheck.Text = funcionario.Nif;
                        labelMoradaCheck.Text = funcionario.Morada;                       
                        labelEmailCheck.Text = funcionario.Email;
                        labelNtelemovelCheck.Text = funcionario.Telemovel;
                        labelUsernameCheck.Text = funcionario.Username;
                        labelPasswordCheck.Text = funcionario.Password;
                        labelSalarioCheck.Text = Convert.ToString(funcionario.Salario);
                        groupBoxRemoverFuncionario.Enabled = true;
                        buttonRemover.Enabled = true;
                        return;
                        
                        
                    }
                }
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Program.melresCar.RemoverFuncionario(_indexFuncionario);
            Program.melresCar.EscreverFicheiroCSV("funcionarios");
            MessageBox.Show("Funcionario removido com sucesso");
            this.Close();
        }
    }
}
