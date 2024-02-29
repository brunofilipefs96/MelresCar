namespace Automobile
{
    partial class UC_Reservas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVerReserva = new System.Windows.Forms.Button();
            this.buttonLucroDatas = new System.Windows.Forms.Button();
            this.buttonCriarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVerReserva
            // 
            this.buttonVerReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonVerReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerReserva.ForeColor = System.Drawing.Color.White;
            this.buttonVerReserva.Location = new System.Drawing.Point(62, 158);
            this.buttonVerReserva.Name = "buttonVerReserva";
            this.buttonVerReserva.Size = new System.Drawing.Size(206, 95);
            this.buttonVerReserva.TabIndex = 15;
            this.buttonVerReserva.Text = "Ver Reserva";
            this.buttonVerReserva.UseVisualStyleBackColor = false;
            this.buttonVerReserva.Click += new System.EventHandler(this.buttonVerReserva_Click);
            // 
            // buttonLucroDatas
            // 
            this.buttonLucroDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonLucroDatas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLucroDatas.ForeColor = System.Drawing.Color.White;
            this.buttonLucroDatas.Location = new System.Drawing.Point(62, 271);
            this.buttonLucroDatas.Name = "buttonLucroDatas";
            this.buttonLucroDatas.Size = new System.Drawing.Size(206, 95);
            this.buttonLucroDatas.TabIndex = 14;
            this.buttonLucroDatas.Text = "Calcular Lucro Entre Datas";
            this.buttonLucroDatas.UseVisualStyleBackColor = false;
            this.buttonLucroDatas.Click += new System.EventHandler(this.buttonLucroDatas_Click);
            // 
            // buttonCriarReserva
            // 
            this.buttonCriarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonCriarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCriarReserva.Location = new System.Drawing.Point(62, 45);
            this.buttonCriarReserva.Name = "buttonCriarReserva";
            this.buttonCriarReserva.Size = new System.Drawing.Size(206, 95);
            this.buttonCriarReserva.TabIndex = 13;
            this.buttonCriarReserva.Text = "Criar Reserva";
            this.buttonCriarReserva.UseVisualStyleBackColor = false;
            this.buttonCriarReserva.Click += new System.EventHandler(this.buttonCriarReserva_Click);
            // 
            // UC_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonVerReserva);
            this.Controls.Add(this.buttonLucroDatas);
            this.Controls.Add(this.buttonCriarReserva);
            this.Name = "UC_Reservas";
            this.Size = new System.Drawing.Size(802, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVerReserva;
        private System.Windows.Forms.Button buttonLucroDatas;
        private System.Windows.Forms.Button buttonCriarReserva;
    }
}
