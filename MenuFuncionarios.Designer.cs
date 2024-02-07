namespace Automobile
{
    partial class MenuFuncionarios
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
            this.labelTitleFuncionarios = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleFuncionarios
            // 
            this.labelTitleFuncionarios.AutoSize = true;
            this.labelTitleFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFuncionarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitleFuncionarios.Location = new System.Drawing.Point(22, 24);
            this.labelTitleFuncionarios.Name = "labelTitleFuncionarios";
            this.labelTitleFuncionarios.Size = new System.Drawing.Size(299, 55);
            this.labelTitleFuncionarios.TabIndex = 5;
            this.labelTitleFuncionarios.Text = "Funcionarios";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(32, 387);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(114, 27);
            this.voltarButton.TabIndex = 10;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // MenuFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.labelTitleFuncionarios);
            this.Name = "MenuFuncionarios";
            this.Text = "MenuFuncionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleFuncionarios;
        private System.Windows.Forms.Button voltarButton;
    }
}