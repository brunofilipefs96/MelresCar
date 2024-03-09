namespace Automobile
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
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gridCarroC = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            this.fotoCarroC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroC)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carro Pequeno de 5 Portas a Gasolina";
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
            this.bigLabel1.Size = new System.Drawing.Size(1443, 46);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Classe C";
            // 
            // gridCarroC
            // 
            this.gridCarroC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarroC.Location = new System.Drawing.Point(543, 12);
            this.gridCarroC.Name = "gridCarroC";
            this.gridCarroC.ReadOnly = true;
            this.gridCarroC.RowHeadersWidth = 51;
            this.gridCarroC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarroC.Size = new System.Drawing.Size(839, 357);
            this.gridCarroC.TabIndex = 9;
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
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click_1);
            // 
            // fotoCarroC
            // 
            this.fotoCarroC.Image = global::Automobile.Properties.Resources.C;
            this.fotoCarroC.Location = new System.Drawing.Point(8, 77);
            this.fotoCarroC.Name = "fotoCarroC";
            this.fotoCarroC.Size = new System.Drawing.Size(529, 386);
            this.fotoCarroC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroC.TabIndex = 7;
            this.fotoCarroC.TabStop = false;
            // 
            // FormCCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1443, 798);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.gridCarroC);
            this.Controls.Add(this.fotoCarroC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCCarro";
            this.Text = "MelresCar | Classe C";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoCarroC;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView gridCarroC;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}