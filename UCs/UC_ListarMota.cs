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
    public partial class UC_ListarMota : UserControl
    {
        public UC_ListarMota()
        {
            InitializeComponent();
        }
        public void showClass(string selectedButton)
        {
            switch(selectedButton)
            {
                case "AMota":
                    FormAMota formAMota = new FormAMota();
                    formAMota.Show();
                    break;
                case "BMota":
                    FormBMota formBMota = new FormBMota();
                    formBMota.Show();
                    break;
                case "CMota":
                    FormCMota formCMota = new FormCMota();
                    formCMota.Show();
                    break;
            }
        }

        private void AMota_Click(object sender, EventArgs e)
        {
            showClass("AMota");
        }

        private void BMota_Click(object sender, EventArgs e)
        {
            showClass("BMota");
        }

        private void CMota_Click(object sender, EventArgs e)
        {
            showClass("CMota");
        }

        private void buttonBackMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["ListaVeiculo"];
            form.Close();
        }
    }
}
