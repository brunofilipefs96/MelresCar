﻿using System;
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
    public partial class FormBCamiao : Form
    {
        public FormBCamiao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            Dock = DockStyle.Fill;
            gridCamiaoB.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoB.Columns.Add("Marca", "Marca");
            gridCamiaoB.Columns.Add("Modelo", "Modelo");
            gridCamiaoB.Columns.Add("Estado", "Estado");
            gridCamiaoB.Columns.Add("Combustível", "Combustível");
            gridCamiaoB.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCamiaoB.EnableHeadersVisualStyles = false;
            gridCamiaoB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamiaoB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoB.RowsDefaultCellStyle.ForeColor = Color.White;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCamiaoB.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Camiao)
                    {
                        Camiao camiao = (Camiao)veiculo;

                        if (camiao.ClasseVeiculo == "B")
                        {
                            gridCamiaoB.Rows.Add(camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                        }
                    }
                }
            }
        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
