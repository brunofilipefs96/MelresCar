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
            this.labelTitleVeiculos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleVeiculos
            // 
            this.labelTitleVeiculos.AutoSize = true;
            this.labelTitleVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleVeiculos.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleVeiculos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitleVeiculos.Location = new System.Drawing.Point(12, 9);
            this.labelTitleVeiculos.Name = "labelTitleVeiculos";
            this.labelTitleVeiculos.Size = new System.Drawing.Size(333, 57);
            this.labelTitleVeiculos.TabIndex = 3;
            this.labelTitleVeiculos.Text = "Veiculos";
            // 
            // MenuVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitleVeiculos);
            this.Name = "MenuVeiculos";
            this.Text = "MenuVeiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleVeiculos;
    }
}