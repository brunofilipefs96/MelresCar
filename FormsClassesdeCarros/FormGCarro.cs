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
    public partial class FormGCarro : Form
    {
        public FormGCarro()
        {
            InitializeComponent();
            gridCarroG.AllowUserToAddRows = false;
            gridCarroG.RowCount = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCarroG.Columns.Add("ID", "ID");
            gridCarroG.Columns.Add("Matrícula", "Matrícula");
            gridCarroG.Columns.Add("Marca", "Marca");
            gridCarroG.Columns.Add("Modelo", "Modelo");
            gridCarroG.Columns.Add("Estado", "Estado");
            gridCarroG.Columns.Add("Combustível", "Combustível");
            gridCarroG.Columns.Add("NumPortas", "NumPortas");
            gridCarroG.Columns.Add("TipoCaixa", "TipoCaixa");
            gridCarroG.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview

            gridCarroG.BackgroundColor = Color.FromArgb(235, 241, 241);
            gridCarroG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCarroG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 92, 186);
            gridCarroG.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin Gothic Medium", 10);
            gridCarroG.RowHeadersVisible = false;
            gridCarroG.DefaultCellStyle.Font = new Font("Franklin Gothic Medium", 8);
            gridCarroG.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 251, 251);
            gridCarroG.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridCarroG.GridColor = Color.FromArgb(96, 155, 173);
            gridCarroG.BorderStyle = BorderStyle.None;
            gridCarroG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCarroG.ScrollBars = ScrollBars.Both;
            gridCarroG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroG.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridCarroG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridCarroG.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Carro)
                {
                    Carro carro = (Carro)veiculo;

                    if (carro.ClasseVeiculo == "G")
                    {
                        gridCarroG.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
            }
        }

        private void PaintCarroG(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Form formListaVeiculo = Application.OpenForms["ListaVeiculo"];
            formListaVeiculo.Enabled = true;
            this.Close();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (gridCarroG.CurrentRow == null)
            {
                MessageBox.Show("Selecione um veículo para reservar");
                return;
            }
            else
            {
                if (Convert.ToDecimal(gridCarroG.Rows[gridCarroG.CurrentRow.Index].Cells[8].Value) == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("O preço diário deste veículo é 0€, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                MenuAdicionarReserva menuAdicionarReserva = new MenuAdicionarReserva();

                menuAdicionarReserva.veiculoSelecionado(Convert.ToInt32(gridCarroG.Rows[gridCarroG.CurrentRow.Index].Cells[0].Value));

                menuAdicionarReserva.Show();
                ListaVeiculo listaVeiculoObject = (ListaVeiculo)Application.OpenForms["listaVeiculo"];
                listaVeiculoObject.Close();
                this.Close();
            }
        }
    }
}
