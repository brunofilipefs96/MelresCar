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
    public partial class UC_ListarCamioneta : UserControl
    {
        public UC_ListarCamioneta()
        {
            InitializeComponent();
        }

        public void showClass(string selectedButton)
        {
            switch (selectedButton)
            {
                case "ACamioneta":
                    FormACamioneta formACamioneta = new FormACamioneta();
                    formACamioneta.Show();
                    break;
                case "BCamioneta":
                    FormBCamioneta formBCamioneta = new FormBCamioneta();
                    formBCamioneta.Show();
                    break;
                case "CCamioneta":
                    FormCCamioneta formCCamioneta = new FormCCamioneta();
                    formCCamioneta.Show();
                    break;
            }
        }

        private void ACamioneta_Click(object sender, EventArgs e)
        {
            showClass("ACamioneta");
        }

        private void BCamioneta_Click(object sender, EventArgs e)
        {
            showClass("BCamioneta");
        }

        private void CCamioneta_Click(object sender, EventArgs e)
        {
            showClass("CCamioneta");
        }

        private void buttonBackMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["ListaVeiculo"];
            form.Close();
        }
    }
}
