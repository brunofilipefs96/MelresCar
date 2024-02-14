namespace Automobile
{
    partial class UC_ListarVeiculo
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
            this.ACarros = new System.Windows.Forms.Button();
            this.BCarros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ACarros
            // 
            this.ACarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ACarros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACarros.ForeColor = System.Drawing.Color.White;
            this.ACarros.Location = new System.Drawing.Point(52, 152);
            this.ACarros.Margin = new System.Windows.Forms.Padding(4);
            this.ACarros.Name = "ACarros";
            this.ACarros.Size = new System.Drawing.Size(158, 127);
            this.ACarros.TabIndex = 5;
            this.ACarros.Text = "A";
            this.ACarros.UseVisualStyleBackColor = false;
            // 
            // BCarros
            // 
            this.BCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BCarros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCarros.ForeColor = System.Drawing.Color.White;
            this.BCarros.Location = new System.Drawing.Point(254, 152);
            this.BCarros.Margin = new System.Windows.Forms.Padding(4);
            this.BCarros.Name = "BCarros";
            this.BCarros.Size = new System.Drawing.Size(158, 127);
            this.BCarros.TabIndex = 6;
            this.BCarros.Text = "B";
            this.BCarros.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "Classe de Veículo";
            // 
            // UC_ListarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCarros);
            this.Controls.Add(this.ACarros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ListarVeiculo";
            this.Size = new System.Drawing.Size(1479, 731);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ACarros;
        private System.Windows.Forms.Button BCarros;
        private System.Windows.Forms.Label label1;
    }
}
