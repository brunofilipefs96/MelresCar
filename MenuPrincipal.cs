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
        }

        

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }

            Form1 form1 = new Form1();
            form1.Show();

        }

        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MenuVeiculos>().Count() == 0)
            {
                MenuVeiculos menuVeiculos = new MenuVeiculos();
                menuVeiculos.Show();
            }
        }
    }
}
