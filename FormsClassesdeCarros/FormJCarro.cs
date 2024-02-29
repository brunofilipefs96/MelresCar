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
    public partial class FormJCarro : Form
    {
        public FormJCarro()
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
            gridCarroJ.Columns.Add("Matrícula", "Matrícula");
            gridCarroJ.Columns.Add("Marca", "Marca");
            gridCarroJ.Columns.Add("Modelo", "Modelo");
            gridCarroJ.Columns.Add("Estado", "Estado");
            gridCarroJ.Columns.Add("Combustível", "Combustível");
            gridCarroJ.Columns.Add("NumPortas", "NumPortas");
            gridCarroJ.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroJ.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroJ.EnableHeadersVisualStyles = false;
            gridCarroJ.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroJ.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroJ.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroJ.RowsDefaultCellStyle.ForeColor = Color.White;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCarroJ.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;

                        if (carro.ClasseVeiculo == "J")
                        {
                            gridCarroJ.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                        }
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
