namespace Automobile
{
    partial class FormBCamiao
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            this.fotoCamiaoB = new System.Windows.Forms.PictureBox();
            this.gridCamiaoB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.buttonReservar = new ReaLTaiizor.Controls.CrownButton();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamiaoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiaoB)).BeginInit();
            this.SuspendLayout();
            // 
            // crownButton1
            // 
            this.crownButton1.Location = new System.Drawing.Point(724, 462);
            this.crownButton1.Margin = new System.Windows.Forms.Padding(4);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.crownButton1.Size = new System.Drawing.Size(156, 64);
            this.crownButton1.TabIndex = 76;
            this.crownButton1.Text = "Cancelar";
            this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
            // 
            // fotoCamiaoB
            // 
            this.fotoCamiaoB.Image = global::Automobile.Properties.Resources.camiaoB;
            this.fotoCamiaoB.Location = new System.Drawing.Point(11, 81);
            this.fotoCamiaoB.Margin = new System.Windows.Forms.Padding(4);
            this.fotoCamiaoB.Name = "fotoCamiaoB";
            this.fotoCamiaoB.Size = new System.Drawing.Size(705, 475);
            this.fotoCamiaoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCamiaoB.TabIndex = 75;
            this.fotoCamiaoB.TabStop = false;
            // 
            // gridCamiaoB
            // 
            this.gridCamiaoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCamiaoB.Location = new System.Drawing.Point(724, 15);
            this.gridCamiaoB.Margin = new System.Windows.Forms.Padding(4);
            this.gridCamiaoB.Name = "gridCamiaoB";
            this.gridCamiaoB.RowHeadersWidth = 51;
            this.gridCamiaoB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCamiaoB.Size = new System.Drawing.Size(1119, 439);
            this.gridCamiaoB.TabIndex = 74;
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
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Camiao de Camiao com Peso Bruto Total de 8 Toneladas";
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
            this.bigLabel1.TabIndex = 72;
            this.bigLabel1.Text = "Classe B";
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(1687, 462);
            this.buttonReservar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonReservar.Size = new System.Drawing.Size(156, 64);
            this.buttonReservar.TabIndex = 77;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // FormBCamiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.crownButton1);
            this.Controls.Add(this.fotoCamiaoB);
            this.Controls.Add(this.gridCamiaoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBCamiao";
            this.Text = "MelresCar | Classe B";
            ((System.ComponentModel.ISupportInitialize)(this.fotoCamiaoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCamiaoB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private System.Windows.Forms.PictureBox fotoCamiaoB;
        private System.Windows.Forms.DataGridView gridCamiaoB;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.CrownButton buttonReservar;
    }
}