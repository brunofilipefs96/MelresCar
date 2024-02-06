namespace Automobile
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonVeiculos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(532, 57);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Menu Principal";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUsername.Location = new System.Drawing.Point(592, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(96, 19);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "logged in as:";
            // 
            // buttonVeiculos
            // 
            this.buttonVeiculos.Location = new System.Drawing.Point(247, 111);
            this.buttonVeiculos.Name = "buttonVeiculos";
            this.buttonVeiculos.Size = new System.Drawing.Size(147, 38);
            this.buttonVeiculos.TabIndex = 4;
            this.buttonVeiculos.Text = "Veículos";
            this.buttonVeiculos.UseVisualStyleBackColor = true;
            this.buttonVeiculos.Click += new System.EventHandler(this.buttonVeiculos_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(73, 111);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(147, 38);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.Location = new System.Drawing.Point(73, 169);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(147, 38);
            this.buttonFuncionarios.TabIndex = 6;
            this.buttonFuncionarios.Text = "Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(776, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(76, 29);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonReservas
            // 
            this.buttonReservas.Location = new System.Drawing.Point(247, 169);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Size = new System.Drawing.Size(147, 38);
            this.buttonReservas.TabIndex = 8;
            this.buttonReservas.Text = "Reservas";
            this.buttonReservas.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 393);
            this.Controls.Add(this.buttonReservas);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonFuncionarios);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonVeiculos);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "MelresCar - Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonVeiculos;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonFuncionarios;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonReservas;
    }
}