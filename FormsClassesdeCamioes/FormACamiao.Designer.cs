﻿namespace Automobile
{
    partial class FormACamiao
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
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            this.gridCamiaoA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fotoMotaA = new System.Windows.Forms.PictureBox();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiaoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMotaA)).BeginInit();
            this.SuspendLayout();
            // 
            // crownButton1
            // 
            this.crownButton1.Location = new System.Drawing.Point(724, 462);
            this.crownButton1.Margin = new System.Windows.Forms.Padding(4);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.crownButton1.Size = new System.Drawing.Size(156, 64);
            this.crownButton1.TabIndex = 71;
            this.crownButton1.Text = "Cancelar";
            this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click_1);
            // 
            // gridCamiaoA
            // 
            this.gridCamiaoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCamiaoA.Location = new System.Drawing.Point(724, 15);
            this.gridCamiaoA.Margin = new System.Windows.Forms.Padding(4);
            this.gridCamiaoA.Name = "gridCamiaoA";
            this.gridCamiaoA.RowHeadersWidth = 51;
            this.gridCamiaoA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCamiaoA.Size = new System.Drawing.Size(1119, 439);
            this.gridCamiaoA.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Camiao com Peso Bruto Total de 3.5 Toneladas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(1863, 57);
            this.bigLabel1.TabIndex = 67;
            this.bigLabel1.Text = "Classe A";
            // 
            // fotoMotaA
            // 
            this.fotoMotaA.Image = global::Automobile.Properties.Resources.camiaoA;
            this.fotoMotaA.Location = new System.Drawing.Point(11, 81);
            this.fotoMotaA.Margin = new System.Windows.Forms.Padding(4);
            this.fotoMotaA.Name = "fotoMotaA";
            this.fotoMotaA.Size = new System.Drawing.Size(705, 475);
            this.fotoMotaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoMotaA.TabIndex = 70;
            this.fotoMotaA.TabStop = false;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1687, 462);
            this.buttonReservar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonReservar.Size = new System.Drawing.Size(156, 64);
            this.buttonReservar.TabIndex = 72;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click_1);
            // 
            // FormACamiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1863, 1038);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.crownButton1);
            this.Controls.Add(this.fotoMotaA);
            this.Controls.Add(this.gridCamiaoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormACamiao";
            this.Text = "MelresCar | Classe A";
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiaoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMotaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private System.Windows.Forms.PictureBox fotoMotaA;
        private System.Windows.Forms.DataGridView gridCamiaoA;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}