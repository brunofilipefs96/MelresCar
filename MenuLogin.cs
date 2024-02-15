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
    public partial class MenuLogin : Form
    {
        MenuPrincipal menuPrincipal = new MenuPrincipal();

        public MenuLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            foreach (var fields in Program.melresCar.Funcionarios)
            {
                if (textBoxUsername.Text == fields.Username && textBoxPassword.Text == fields.Password)
                {
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username ou Password incorretos!");
                }
            }


            
        }
    }
}
