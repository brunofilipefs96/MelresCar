﻿namespace Automobile
{
    partial class FormLCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gridCarroL = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            this.fotoCarroL = new System.Windows.Forms.PictureBox();
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carro Executivo/Desportivo Premium de 5 Portas a Diesel/Gasolina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(1150, 46);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Classe L";
            // 
            // gridCarroL
            // 
            this.gridCarroL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarroL.Location = new System.Drawing.Point(543, 12);
            this.gridCarroL.Name = "gridCarroL";
            this.gridCarroL.ReadOnly = true;
            this.gridCarroL.Size = new System.Drawing.Size(839, 357);
            this.gridCarroL.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(543, 375);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Size = new System.Drawing.Size(117, 52);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1265, 375);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonReservar.Size = new System.Drawing.Size(117, 52);
            this.buttonReservar.TabIndex = 62;
            this.buttonReservar.Text = "Reservar";
            // 
            // fotoCarroL
            // 
            this.fotoCarroL.Image = global::Automobile.Properties.Resources.L;
            this.fotoCarroL.Location = new System.Drawing.Point(8, 77);
            this.fotoCarroL.Name = "fotoCarroL";
            this.fotoCarroL.Size = new System.Drawing.Size(529, 386);
            this.fotoCarroL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroL.TabIndex = 7;
            this.fotoCarroL.TabStop = false;
            // 
            // crownButton1
            // 
            this.crownButton1.Location = new System.Drawing.Point(1094, 375);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton1.Size = new System.Drawing.Size(117, 52);
            this.crownButton1.TabIndex = 63;
            this.crownButton1.Text = "Reservar";
            // 
            // FormLCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1150, 657);
            this.Controls.Add(this.crownButton1);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.gridCarroL);
            this.Controls.Add(this.fotoCarroL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLCarro";
            this.Text = "MelresCar | Classe L";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoCarroL;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView gridCarroL;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
    }
}