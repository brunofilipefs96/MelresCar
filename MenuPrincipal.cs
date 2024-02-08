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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            UC_MenuPrincipal ucMenuPrincipal = new UC_MenuPrincipal();
            addUserControl(ucMenuPrincipal, buttonMenuPrincipal);
            labelDataHoje.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void addUserControl(UserControl userControl, Button botaoSelecionado)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
            buttonMenuPrincipal.Size = new Size(216, 95);
            buttonClientes.Size = new Size(216, 95);
            buttonFuncionarios.Size = new Size(216, 95);
            buttonVeiculos.Size = new Size(216, 95);
            buttonReservas.Size = new Size(216, 95);
            botaoSelecionado.Size = new Size(207, 95);
        }
        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            UC_MenuPrincipal ucMenuPrincipal = new UC_MenuPrincipal();
            addUserControl(ucMenuPrincipal, buttonMenuPrincipal);
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            UC_Clientes ucClientes = new UC_Clientes();
            addUserControl(ucClientes, buttonClientes);
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            UC_Funcionarios ucFuncionario = new UC_Funcionarios();
            addUserControl(ucFuncionario, buttonFuncionarios);
        }

        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            UC_Veiculos ucVeiculo = new UC_Veiculos();
            addUserControl(ucVeiculo, buttonVeiculos);
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            UC_Reservas ucReservas = new UC_Reservas();
            addUserControl(ucReservas, buttonReservas);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuLogin logginScreen = new MenuLogin();
            logginScreen.Show();
            this.Close();
        }

        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            labelDataHoje.Text = "Data: " + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy") + " (+1)";
            buttonAddDay.Visible = false;
            panelAddDay.Visible = false;

        }
    }
}
