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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            UC_MenuPrincipal ucMenuPrincipal = new UC_MenuPrincipal();
            addUserControl(ucMenuPrincipal, buttonMenuPrincipal);
            labelDataHoje.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
            labelLoggedInAs.Text = "Conta: " + Program.melresCar.LoggedAccount;
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
        public UC_MenuPrincipal ucMenuPrincipal = new UC_MenuPrincipal();
        public UC_Clientes ucClientes = new UC_Clientes();
        public UC_Funcionarios ucFuncionario = new UC_Funcionarios();
        public UC_Veiculos ucVeiculo = new UC_Veiculos();
        public UC_Reservas ucReservas = new UC_Reservas();

        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            addUserControl(ucMenuPrincipal, buttonMenuPrincipal);
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            addUserControl(ucClientes, buttonClientes);
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            addUserControl(ucFuncionario, buttonFuncionarios);
        }

        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            addUserControl(ucVeiculo, buttonVeiculos);
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
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
            Program.melresCar.adicionarDia();
            labelDataHoje.Text = "Data: " + Program.DataHoraDoSistema().ToString("dd/MM/yyyy") + " (+" + Program.DiasAdicionados() + ")";
        }

        private void PaintMenu(object sender, PaintEventArgs e)
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
