using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class MenuLogin : Form
    {
        bool loggedIn = false;

        public MenuLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Program.AdicionarSegundos();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin") {
                loggedIn = true;
                Program.melresCar.LoggedAccount = "admin";
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                foreach (var fields in Program.melresCar.Funcionarios)
                {
                    if (textBoxUsername.Text == fields.Username && textBoxPassword.Text == fields.Password)
                    {
                        loggedIn = true;
                        Program.melresCar.LoggedAccount = fields.Username;
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                }
            }
            if (!loggedIn){
                MessageBox.Show("Username ou password incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
