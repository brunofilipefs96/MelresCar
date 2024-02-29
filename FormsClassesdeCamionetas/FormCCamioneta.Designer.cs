namespace Automobile
{
    partial class FormCCamioneta
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
            this.gridCamionetaC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fotoCamionetaC = new System.Windows.Forms.PictureBox();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamionetaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamionetaC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(543, 375);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Size = new System.Drawing.Size(117, 52);
            this.buttonCancelar.TabIndex = 65;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // gridCamionetaC
            // 
            this.gridCamionetaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCamionetaC.Location = new System.Drawing.Point(543, 12);
            this.gridCamionetaC.Name = "gridCamionetaC";
            this.gridCamionetaC.Size = new System.Drawing.Size(839, 357);
            this.gridCamionetaC.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Camioneta Capacidade Máxima de 64 Passageiros";
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
            this.bigLabel1.Size = new System.Drawing.Size(1473, 46);
            this.bigLabel1.TabIndex = 61;
            this.bigLabel1.Text = "Classe C";
            // 
            // fotoCamionetaC
            // 
            this.fotoCamionetaC.Image = global::Automobile.Properties.Resources.cCamioneta;
            this.fotoCamionetaC.Location = new System.Drawing.Point(8, 77);
            this.fotoCamionetaC.Name = "fotoCamionetaC";
            this.fotoCamionetaC.Size = new System.Drawing.Size(529, 386);
            this.fotoCamionetaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCamionetaC.TabIndex = 64;
            this.fotoCamionetaC.TabStop = false;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1265, 375);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonReservar.Size = new System.Drawing.Size(117, 52);
            this.buttonReservar.TabIndex = 66;
            this.buttonReservar.Text = "Reservar";
            // 
            // FormCCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1473, 818);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.fotoCamionetaC);
            this.Controls.Add(this.gridCamionetaC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCCamioneta";
            this.Text = "MelresCar | Classe C";
            ((System.ComponentModel.ISupportInitialize)(this.gridCamionetaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamionetaC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private System.Windows.Forms.PictureBox fotoCamionetaC;
        private System.Windows.Forms.DataGridView gridCamionetaC;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}