namespace Automobile
{
    partial class MenuVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVeiculos));
            this.labelTitleVeiculos = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleVeiculos
            // 
            this.labelTitleVeiculos.AutoSize = true;
            this.labelTitleVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleVeiculos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitleVeiculos.Location = new System.Drawing.Point(12, 9);
            this.labelTitleVeiculos.Name = "labelTitleVeiculos";
            this.labelTitleVeiculos.Size = new System.Drawing.Size(205, 55);
            this.labelTitleVeiculos.TabIndex = 3;
            this.labelTitleVeiculos.Text = "Veiculos";
            // 
            // voltarButton
            // 
            this.voltarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarButton.BackgroundImage")));
            this.voltarButton.Location = new System.Drawing.Point(569, 240);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(191, 187);
            this.voltarButton.TabIndex = 9;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // MenuVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.labelTitleVeiculos);
            this.Name = "MenuVeiculos";
            this.Text = "MenuVeiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleVeiculos;
        private System.Windows.Forms.Button voltarButton;
    }
}