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
        public ListaVeiculo()
        {
            InitializeComponent();
            addUserControl(ucListarVeiculo, buttonCarros);
        }

        private void addUserControl(UserControl userControl, Button botaoSelecionado)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            buttonCarros.Size = new Size(216, 95);
            buttonMotas.Size = new Size(216, 95);
            buttonCamioes.Size = new Size(216, 95);
            buttonCamionetas.Size = new Size(216, 95);
            botaoSelecionado.Size = new Size(207, 95);
        }
        UC_ListarVeiculo ucListarVeiculo = new UC_ListarVeiculo();

        private void buttonCarros_Click(object sender, EventArgs e)
        {
            addUserControl(ucListarVeiculo, buttonCarros);
        }

        private void buttonMotas_Click(object sender, EventArgs e)
        {
            addUserControl(ucListarVeiculo, buttonMotas);
        }

        private void buttonCamioes_Click(object sender, EventArgs e)
        {
            addUserControl(ucListarVeiculo, buttonCamioes);
        }

        private void buttonCamionetas_Click(object sender, EventArgs e)
        {
            addUserControl(ucListarVeiculo, buttonCamionetas);
        }
    }
}
