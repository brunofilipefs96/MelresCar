namespace Automobile
{
    partial class MenuClientes
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
            this.labelTitleClientes = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleClientes
            // 
            this.labelTitleClientes.AutoSize = true;
            this.labelTitleClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitleClientes.Location = new System.Drawing.Point(12, 9);
            this.labelTitleClientes.Name = "labelTitleClientes";
            this.labelTitleClientes.Size = new System.Drawing.Size(197, 55);
            this.labelTitleClientes.TabIndex = 6;
            this.labelTitleClientes.Text = "Clientes";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(50, 383);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(114, 27);
            this.voltarButton.TabIndex = 10;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.labelTitleClientes);
            this.Name = "MenuClientes";
            this.Text = "MenuClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleClientes;
        private System.Windows.Forms.Button voltarButton;
    }
}