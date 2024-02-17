namespace Automobile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonAddCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAddCliente.Location = new System.Drawing.Point(26, 55);
            this.buttonAddCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(275, 117);
            this.buttonAddCliente.TabIndex = 4;
            this.buttonAddCliente.Text = "Adicionar Cliente";
            this.buttonAddCliente.UseVisualStyleBackColor = false;
            this.buttonAddCliente.Click += new System.EventHandler(this.buttonAddCliente_Click);
            // 
            // buttonRemCliente
            // 
            this.buttonRemCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonRemCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemCliente.ForeColor = System.Drawing.Color.White;
            this.buttonRemCliente.Location = new System.Drawing.Point(26, 334);
            this.buttonRemCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemCliente.Name = "buttonRemCliente";
            this.buttonRemCliente.Size = new System.Drawing.Size(275, 117);
            this.buttonRemCliente.TabIndex = 5;
            this.buttonRemCliente.Text = "Remover Cliente";
            this.buttonRemCliente.UseVisualStyleBackColor = false;
            this.buttonRemCliente.Click += new System.EventHandler(this.buttonRemCliente_Click);
            // 
            // buttonEditCliente
            // 
            this.buttonEditCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonEditCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCliente.ForeColor = System.Drawing.Color.White;
            this.buttonEditCliente.Location = new System.Drawing.Point(26, 194);
            this.buttonEditCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditCliente.Name = "buttonEditCliente";
            this.buttonEditCliente.Size = new System.Drawing.Size(275, 117);
            this.buttonEditCliente.TabIndex = 6;
            this.buttonEditCliente.Text = "Editar Cliente";
            this.buttonEditCliente.UseVisualStyleBackColor = false;
            this.buttonEditCliente.Click += new System.EventHandler(this.buttonEditCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 396);
            this.dataGridView1.TabIndex = 7;
            // 
            // UC_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditCliente);
            this.Controls.Add(this.buttonRemCliente);
            this.Controls.Add(this.buttonAddCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Clientes";
            this.Size = new System.Drawing.Size(1069, 588);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.Button buttonRemCliente;
        private System.Windows.Forms.Button buttonEditCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
