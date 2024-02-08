namespace Automobile
{
    partial class UC_Veiculos
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
            this.buttonEditVeiculo = new System.Windows.Forms.Button();
            this.buttonRemVeiculo = new System.Windows.Forms.Button();
            this.buttonAddVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditVeiculo
            // 
            this.buttonEditVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonEditVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonEditVeiculo.Location = new System.Drawing.Point(62, 158);
            this.buttonEditVeiculo.Name = "buttonEditVeiculo";
            this.buttonEditVeiculo.Size = new System.Drawing.Size(206, 95);
            this.buttonEditVeiculo.TabIndex = 12;
            this.buttonEditVeiculo.Text = "Editar Veículo";
            this.buttonEditVeiculo.UseVisualStyleBackColor = false;
            // 
            // buttonRemVeiculo
            // 
            this.buttonRemVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonRemVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonRemVeiculo.Location = new System.Drawing.Point(62, 271);
            this.buttonRemVeiculo.Name = "buttonRemVeiculo";
            this.buttonRemVeiculo.Size = new System.Drawing.Size(206, 95);
            this.buttonRemVeiculo.TabIndex = 11;
            this.buttonRemVeiculo.Text = "Remover Veículo";
            this.buttonRemVeiculo.UseVisualStyleBackColor = false;
            // 
            // buttonAddVeiculo
            // 
            this.buttonAddVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonAddVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonAddVeiculo.Location = new System.Drawing.Point(62, 45);
            this.buttonAddVeiculo.Name = "buttonAddVeiculo";
            this.buttonAddVeiculo.Size = new System.Drawing.Size(206, 95);
            this.buttonAddVeiculo.TabIndex = 10;
            this.buttonAddVeiculo.Text = "Adicionar Veículo";
            this.buttonAddVeiculo.UseVisualStyleBackColor = false;
            // 
            // UC_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonEditVeiculo);
            this.Controls.Add(this.buttonRemVeiculo);
            this.Controls.Add(this.buttonAddVeiculo);
            this.Name = "UC_Veiculos";
            this.Size = new System.Drawing.Size(802, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditVeiculo;
        private System.Windows.Forms.Button buttonRemVeiculo;
        private System.Windows.Forms.Button buttonAddVeiculo;
    }
}
