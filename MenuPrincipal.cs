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

        MenuVeiculos menuVeiculos = new MenuVeiculos();
        MenuClientes menuClientes = new MenuClientes();
        MenuFuncionarios menuFuncionarios = new MenuFuncionarios();
        MenuReservas menuReservas = new MenuReservas();
        public MenuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        

        private void buttonLogout_Click(object sender, EventArgs e)
        {           
            foreach (Form form in Application.OpenForms)
            {
                if (form.Visible)
                {
                    form.Hide();
                }
            }
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            if (!menuVeiculos.Visible)
            {               
                menuVeiculos.Show();
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if (!menuClientes.Visible)
            {               
                menuClientes.Show();
            }
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            if (!menuFuncionarios.Visible)
            {               
                menuFuncionarios.Show();
            }
        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            if (!menuReservas.Visible)
            {   
                menuReservas.Show();
            }
        }
    }
}
