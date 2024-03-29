﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class ListaVeiculo : Form
    {
        UC_ListarCarro ucListarCarro = new UC_ListarCarro();
        UC_ListarMota ucListarMota = new UC_ListarMota();
        UC_ListarCamiao ucListarCamiao = new UC_ListarCamiao();
        UC_ListarCamioneta ucListarCamioneta = new UC_ListarCamioneta();
        public ListaVeiculo()
        {
            InitializeComponent();
            ucListarCarro.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucListarCarro);
            ucListarCarro.BringToFront();
            atualizarBotao(buttonCarros);
        }

        private void atualizarBotao(Button botaoSelecionado)
        {  
            buttonCarros.Size = new Size(216, 95);
            buttonMotas.Size = new Size(216, 95);
            buttonCamioes.Size = new Size(216, 95);
            buttonCamionetas.Size = new Size(216, 95);
            botaoSelecionado.Size = new Size(210, 95);
            if (botaoSelecionado == buttonCarros)
            {
                ucListarMota.Hide();
                ucListarCamioneta.Hide();
                ucListarCamiao.Hide();
                ucListarCarro.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucListarCarro);
                ucListarCarro.BringToFront();
                ucListarCarro.Show();
            }
            else if (botaoSelecionado == buttonMotas)
            {
                ucListarCarro.Hide();
                ucListarCamioneta.Hide();
                ucListarCamiao.Hide();
                ucListarMota.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucListarMota);
                ucListarMota.BringToFront();
                ucListarMota.Show();
            }
            else if (botaoSelecionado == buttonCamioes)
            {
                ucListarMota.Hide();
                ucListarCarro.Hide();
                ucListarCamioneta.Hide();
                ucListarCamiao.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucListarCamiao);
                ucListarCamiao.BringToFront();
                ucListarCamiao.Show();
            }
            else if (botaoSelecionado == buttonCamionetas)
            {
                ucListarMota.Hide();
                ucListarCarro.Hide();
                ucListarCamiao.Hide();
                ucListarCamioneta.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucListarCamioneta);
                ucListarCamioneta.BringToFront();
                ucListarCamioneta.Show();
            }
        }

        private void buttonCarros_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCarros);
        }

        private void buttonMotas_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonMotas);
        }

        private void buttonCamioes_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCamioes);
        }

        private void buttonCamionetas_Click(object sender, EventArgs e)
        {
            atualizarBotao(buttonCamionetas);
        }

        private void buttonBackMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = true;
            this.Close();
        }

        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.ucReservas.atualizaDataGridView();
            menuPrincipalObject.Enabled = true;
            Form form = Application.OpenForms["ListaVeiculo"];
            form.Close();
            
        }

        private void PaintListVeiculo(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
