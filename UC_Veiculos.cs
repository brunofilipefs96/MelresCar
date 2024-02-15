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
    public partial class UC_Veiculos : UserControl
    {

        public UC_Veiculos()
        {
            InitializeComponent();
        }

        private void buttonListaVeiculo_Click(object sender, EventArgs e)
        {
            ListaVeiculo listaVeiculo = new ListaVeiculo();
            listaVeiculo.Show();
        }

        private void buttonAddVeiculo_Click(object sender, EventArgs e)
        {
            AdicionarVeiculo adicionarVeiculo = new AdicionarVeiculo();
            adicionarVeiculo.Show();
        }

        private void buttonRemVeiculo_Click(object sender, EventArgs e)
        {
            RemoverVeiculo removerVeiculo = new RemoverVeiculo();
            removerVeiculo.Show();
        }
    }
}
