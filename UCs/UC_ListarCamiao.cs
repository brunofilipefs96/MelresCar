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
    public partial class UC_ListarCamiao : UserControl
    {
        public UC_ListarCamiao()
        {
            InitializeComponent();
        }

        public void showClass(string selectedButton)
        {
            switch(selectedButton)
            {
                case "ACamiao":
                    FormACamiao formACamiao = new FormACamiao();
                    formACamiao.Show();
                    break;
                case "BCamiao":
                    FormBCamiao formBCamiao = new FormBCamiao();
                    formBCamiao.Show();
                    break;
                case "CCamiao":
                    FormCCamiao formCCamiao = new FormCCamiao();
                    formCCamiao.Show();
                    break;
            }
        }

        private void ACamiao_Click(object sender, EventArgs e)
        {
            showClass("ACamiao");
        }

        private void BCamiao_Click(object sender, EventArgs e)
        {
            showClass("BCamiao");
        }

        private void CCamiao_Click(object sender, EventArgs e)
        {
            showClass("CCamiao");
        }
    }
}
