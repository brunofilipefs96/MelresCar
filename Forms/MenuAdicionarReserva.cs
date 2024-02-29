using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile.Forms
{
    public partial class MenuAdicionarReserva : Form
    {
        public MenuAdicionarReserva()
        {
            InitializeComponent();
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in Program.melresCar.Clientes)
            {
                if (cliente.Nif == textBoxNif.Text)
                { 
                    return;
                }
            }
            MessageBox.Show("Este cliente não existe!");
            MenuAdicionarCliente adicionarCliente = new MenuAdicionarCliente();
            adicionarCliente.Show();
        }
    }
}
