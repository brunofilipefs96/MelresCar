﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
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
