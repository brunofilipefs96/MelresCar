﻿namespace Automobile
{
    partial class UC_Clientes
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
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.buttonRemCliente = new System.Windows.Forms.Button();
            this.buttonEditCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonAddCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAddCliente.Location = new System.Drawing.Point(62, 45);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(206, 95);
            this.buttonAddCliente.TabIndex = 4;
            this.buttonAddCliente.Text = "Adicionar Cliente";
            this.buttonAddCliente.UseVisualStyleBackColor = false;
            // 
            // buttonRemCliente
            // 
            this.buttonRemCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonRemCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemCliente.ForeColor = System.Drawing.Color.White;
            this.buttonRemCliente.Location = new System.Drawing.Point(62, 271);
            this.buttonRemCliente.Name = "buttonRemCliente";
            this.buttonRemCliente.Size = new System.Drawing.Size(206, 95);
            this.buttonRemCliente.TabIndex = 5;
            this.buttonRemCliente.Text = "Remover Cliente";
            this.buttonRemCliente.UseVisualStyleBackColor = false;
            // 
            // buttonEditCliente
            // 
            this.buttonEditCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonEditCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCliente.ForeColor = System.Drawing.Color.White;
            this.buttonEditCliente.Location = new System.Drawing.Point(62, 158);
            this.buttonEditCliente.Name = "buttonEditCliente";
            this.buttonEditCliente.Size = new System.Drawing.Size(206, 95);
            this.buttonEditCliente.TabIndex = 6;
            this.buttonEditCliente.Text = "Editar Cliente";
            this.buttonEditCliente.UseVisualStyleBackColor = false;
            // 
            // UC_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonEditCliente);
            this.Controls.Add(this.buttonRemCliente);
            this.Controls.Add(this.buttonAddCliente);
            this.Name = "UC_Clientes";
            this.Size = new System.Drawing.Size(802, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.Button buttonRemCliente;
        private System.Windows.Forms.Button buttonEditCliente;
    }
}
