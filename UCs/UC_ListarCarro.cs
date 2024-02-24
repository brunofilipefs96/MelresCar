using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    
    public partial class UC_ListarCarro : UserControl
    {
        public UC_ListarCarro()
        {
            InitializeComponent();
        }
        public void showClass(string selectedButton)
        {
            switch(selectedButton)
            {
                case "ACarros":
                    FormACarro formACarro = new FormACarro();
                    formACarro.Show();
                    break;
                case "BCarros":
                    FormBCarro formBCarro = new FormBCarro();
                    formBCarro.Show();
                    break;
                case "CCarros":
                    FormCCarro formCCarro = new FormCCarro();
                    formCCarro.Show();
                    break;
                case "DCarros":
                    FormDCarro formDCarro = new FormDCarro();
                    formDCarro.Show();
                    break;
                case "FCarros":
                    FormFCarro formFCarro = new FormFCarro();
                    formFCarro.Show();
                    break;
                case "GCarros":
                    FormGCarro formGCarro = new FormGCarro();
                    formGCarro.Show();
                    break;
                case "HCarros":
                    FormHCarro formHCarro = new FormHCarro();
                    formHCarro.Show();
                    break;
                case "ICarros":
                    FormICarro formICarro = new FormICarro();
                    formICarro.Show();
                    break;
                case "JCarros":
                    FormJCarro formJCarro = new FormJCarro();
                    formJCarro.Show();
                    break;
                case "LCarros":
                    FormLCarro formLCarro = new FormLCarro();
                    formLCarro.Show();
                    break;
            }

            
        }
        private void ACarros_Click(object sender, EventArgs e)
        {
            showClass("ACarros");
        }

        private void BCarros_Click(object sender, EventArgs e)
        {
            showClass("BCarros");
        }

        private void CCarros_Click(object sender, EventArgs e)
        {
            showClass("CCarros");
        }

        private void DCarros_Click(object sender, EventArgs e)
        {
            showClass("DCarros");
        }

        private void FCarros_Click(object sender, EventArgs e)
        {
            showClass("FCarros");
        }

        private void GCarros_Click(object sender, EventArgs e)
        {
            showClass("GCarros");
        }

        private void HCarros_Click(object sender, EventArgs e)
        {
            showClass("HCarros");
        }

        private void ICarros_Click(object sender, EventArgs e)
        {
            showClass("ICarros");
        }

        private void JCarros_Click(object sender, EventArgs e)
        {
            showClass("JCarros");
        }

        private void LCarros_Click(object sender, EventArgs e)
        {
            showClass("LCarros");
        }

    }
}
