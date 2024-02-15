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
    public partial class ListaVeiculo : Form
    {
        ListarCarro ucListarCarro = new ListarCarro();
        ListarMota ucListarMota = new ListarMota();
        public ListaVeiculo()
        {
            InitializeComponent();
            ucListarCarro.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucListarCarro);
            ucListarCarro.BringToFront();
            atualizarBotao(buttonCarros);
        }

        private void atualizarBotao(Button botaoSelecionado)
        {  
            buttonCarros.Size = new Size(216, 95);
            buttonMotas.Size = new Size(216, 95);
            buttonCamioes.Size = new Size(216, 95);
            buttonCamionetas.Size = new Size(216, 95);
            botaoSelecionado.Size = new Size(207, 95);
        }

        private void buttonCarros_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCarros);
            UC_Clientes ucClientes = new UC_Clientes();

        }

        private void buttonMotas_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonMotas);
        }

        private void buttonCamioes_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCamioes);
        }

        private void buttonCamionetas_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCamionetas);
        }
    }
}
