﻿namespace Automobile
{
    partial class FormCCarro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fotoCarroC = new System.Windows.Forms.PictureBox();
            this.gridCarroC = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.buttonCancelar = new ReaLTaiizor.Controls.Button();
            this.buttonReservar = new ReaLTaiizor.Controls.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroC)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Stencil", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(1408, 46);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Classe C";
            // 
            // fotoCarroC
            // 
            this.fotoCarroC.BackColor = System.Drawing.Color.Transparent;
            this.fotoCarroC.Image = global::Automobile.Properties.Resources.C;
            this.fotoCarroC.Location = new System.Drawing.Point(8, 77);
            this.fotoCarroC.Name = "fotoCarroC";
            this.fotoCarroC.Size = new System.Drawing.Size(529, 386);
            this.fotoCarroC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroC.TabIndex = 7;
            this.fotoCarroC.TabStop = false;
            // 
            // gridCarroC
            // 
            this.gridCarroC.AllowUserToResizeRows = false;
            this.gridCarroC.BackgroundColor = System.Drawing.Color.White;
            this.gridCarroC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCarroC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCarroC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCarroC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridCarroC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCarroC.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridCarroC.EnableHeadersVisualStyles = false;
            this.gridCarroC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCarroC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCarroC.Location = new System.Drawing.Point(543, 11);
            this.gridCarroC.Name = "gridCarroC";
            this.gridCarroC.ReadOnly = true;
            this.gridCarroC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCarroC.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridCarroC.RowHeadersWidth = 51;
            this.gridCarroC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCarroC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarroC.Size = new System.Drawing.Size(839, 358);
            this.gridCarroC.TabIndex = 64;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = null;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Location = new System.Drawing.Point(543, 393);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelar.TabIndex = 65;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // buttonReservar
            // 
            this.buttonReservar.BackColor = System.Drawing.Color.Transparent;
            this.buttonReservar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonReservar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonReservar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservar.Image = null;
            this.buttonReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonReservar.Location = new System.Drawing.Point(1262, 393);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonReservar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonReservar.Size = new System.Drawing.Size(120, 40);
            this.buttonReservar.TabIndex = 66;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gasolina 5 Portas até 20€";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1408, 445);
            this.ControlBox = false;
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.gridCarroC);
            this.Controls.Add(this.fotoCarroC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCCarro";
            this.Text = "MelresCar | Classe C";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCarroC);
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoCarroC;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.PoisonDataGridView gridCarroC;
        private ReaLTaiizor.Controls.Button buttonCancelar;
        private ReaLTaiizor.Controls.Button buttonReservar;
        private System.Windows.Forms.Label label1;
    }
}