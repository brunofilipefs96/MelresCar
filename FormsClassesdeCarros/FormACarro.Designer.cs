﻿namespace Automobile
{
    partial class FormACarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormACarro));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCarroA = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.fotoCarroA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroA)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(1532, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Classe A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro 3 Portas a Gasolina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCarroA
            // 
            this.gridCarroA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarroA.Location = new System.Drawing.Point(543, 12);
            this.gridCarroA.Name = "gridCarroA";
            this.gridCarroA.Size = new System.Drawing.Size(846, 329);
            this.gridCarroA.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(8, 565);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Size = new System.Drawing.Size(117, 52);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // fotoCarroA
            // 
            this.fotoCarroA.Image = ((System.Drawing.Image)(resources.GetObject("fotoCarroA.Image")));
            this.fotoCarroA.Location = new System.Drawing.Point(8, 77);
            this.fotoCarroA.Name = "fotoCarroA";
            this.fotoCarroA.Size = new System.Drawing.Size(529, 386);
            this.fotoCarroA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroA.TabIndex = 3;
            this.fotoCarroA.TabStop = false;
            // 
            // FormACarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1532, 629);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.fotoCarroA);
            this.Controls.Add(this.gridCarroA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "FormACarro";
            this.Text = "FormACarro";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCarroA;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox fotoCarroA;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
    }
}