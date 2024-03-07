﻿namespace Automobile
{
    partial class FormAMota
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
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.gridMotaA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            this.fotoMotaA = new System.Windows.Forms.PictureBox();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridMotaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMotaA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(-381, 593);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancelar.Size = new System.Drawing.Size(156, 64);
            this.buttonCancelar.TabIndex = 65;
            this.buttonCancelar.Text = "Cancelar";
            // 
            // gridMotaA
            // 
            this.gridMotaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMotaA.Location = new System.Drawing.Point(724, 15);
            this.gridMotaA.Margin = new System.Windows.Forms.Padding(4);
            this.gridMotaA.Name = "gridMotaA";
            this.gridMotaA.RowHeadersWidth = 51;
            this.gridMotaA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMotaA.Size = new System.Drawing.Size(1119, 439);
            this.gridMotaA.TabIndex = 63;
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
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mota 50 CC";
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
            this.bigLabel1.Size = new System.Drawing.Size(1924, 57);
            this.bigLabel1.TabIndex = 61;
            this.bigLabel1.Text = "Classe A";
            // 
            // crownButton1
            // 
            this.crownButton1.Location = new System.Drawing.Point(724, 462);
            this.crownButton1.Margin = new System.Windows.Forms.Padding(4);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.crownButton1.Size = new System.Drawing.Size(156, 64);
            this.crownButton1.TabIndex = 66;
            this.crownButton1.Text = "Cancelar";
            this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
            // 
            // fotoMotaA
            // 
            this.fotoMotaA.Image = global::Automobile.Properties.Resources.MotaA;
            this.fotoMotaA.Location = new System.Drawing.Point(11, 81);
            this.fotoMotaA.Margin = new System.Windows.Forms.Padding(4);
            this.fotoMotaA.Name = "fotoMotaA";
            this.fotoMotaA.Size = new System.Drawing.Size(705, 475);
            this.fotoMotaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoMotaA.TabIndex = 64;
            this.fotoMotaA.TabStop = false;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1687, 462);
            this.buttonReservar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonReservar.Size = new System.Drawing.Size(156, 64);
            this.buttonReservar.TabIndex = 67;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click_1);
            // 
            // FormAMota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 988);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.crownButton1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.fotoMotaA);
            this.Controls.Add(this.gridMotaA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAMota";
            this.Text = "MelresCar | Classe A";
            ((System.ComponentModel.ISupportInitialize)(this.gridMotaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMotaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private System.Windows.Forms.PictureBox fotoMotaA;
        private System.Windows.Forms.DataGridView gridMotaA;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}