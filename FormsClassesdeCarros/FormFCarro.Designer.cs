namespace Automobile
{
    partial class FormFCarro
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
            this.gridCarroF = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            this.fotoCarroF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroF)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carro Médio de 5 Portas a Gasolina";
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
            this.bigLabel1.Size = new System.Drawing.Size(1579, 57);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Classe F";
            // 
            // gridCarroF
            // 
            this.gridCarroF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarroF.Location = new System.Drawing.Point(724, 15);
            this.gridCarroF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridCarroF.Name = "gridCarroF";
            this.gridCarroF.ReadOnly = true;
            this.gridCarroF.RowHeadersWidth = 51;
            this.gridCarroF.Size = new System.Drawing.Size(1119, 439);
            this.gridCarroF.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(724, 462);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancelar.Size = new System.Drawing.Size(156, 64);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1687, 462);
            this.buttonReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonReservar.Size = new System.Drawing.Size(156, 64);
            this.buttonReservar.TabIndex = 62;
            this.buttonReservar.Text = "Reservar";
            // 
            // fotoCarroF
            // 
            this.fotoCarroF.Image = global::Automobile.Properties.Resources.F;
            this.fotoCarroF.Location = new System.Drawing.Point(11, 95);
            this.fotoCarroF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoCarroF.Name = "fotoCarroF";
            this.fotoCarroF.Size = new System.Drawing.Size(705, 475);
            this.fotoCarroF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroF.TabIndex = 7;
            this.fotoCarroF.TabStop = false;
            // 
            // FormFCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1579, 784);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.gridCarroF);
            this.Controls.Add(this.fotoCarroF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFCarro";
            this.Text = "MelresCar | Classe F";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoCarroF;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView gridCarroF;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}