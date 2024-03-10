﻿using Automobile.Forms;
using System;
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
    public partial class FormCCarro : Form
    {
        public FormCCarro()
        {
            InitializeComponent();
            gridCarroC.AllowUserToAddRows = false;
            gridCarroC.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroC.Columns.Add("ID", "ID");
            gridCarroC.Columns.Add("Matrícula", "Matrícula");
            gridCarroC.Columns.Add("Marca", "Marca");
            gridCarroC.Columns.Add("Modelo", "Modelo");
            gridCarroC.Columns.Add("Estado", "Estado");
            gridCarroC.Columns.Add("Combustível", "Combustível");
            gridCarroC.Columns.Add("NumPortas", "NumPortas");
            gridCarroC.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCarroC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCarroC.MultiSelect = false;
            gridCarroC.EnableHeadersVisualStyles = false;
            gridCarroC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCarroC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCarroC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCarroC.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "C")
                    {
                        gridCarroC.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click_1(object sender, EventArgs e)
        {
            if (gridCarroC.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroC.Rows[gridCarroC.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }

        private void PaintCarroC(object sender, PaintEventArgs e)
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
