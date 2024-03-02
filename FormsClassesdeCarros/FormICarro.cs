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
    public partial class FormICarro : Form
    {
        public FormICarro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroI.Columns.Add("Matrícula", "Matrícula");
            gridCarroI.Columns.Add("Marca", "Marca");
            gridCarroI.Columns.Add("Modelo", "Modelo");
            gridCarroI.Columns.Add("Estado", "Estado");
            gridCarroI.Columns.Add("Combustível", "Combustível");
            gridCarroI.Columns.Add("NumPortas", "NumPortas");
            gridCarroI.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroI.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCarroI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroI.MultiSelect = false;
            gridCarroI.EnableHeadersVisualStyles = false;
            gridCarroI.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroI.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroI.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroI.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroI.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroI.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroI.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroI.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroI.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "I")
                    {
                        gridCarroI.Rows.Add(carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
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
