namespace Automobile
{
    partial class FormICarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormICarro));
            this.fotoCarroA = new System.Windows.Forms.PictureBox();
            this.gridCarroA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroA)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoCarroA
            // 
            this.fotoCarroA.Image = ((System.Drawing.Image)(resources.GetObject("fotoCarroA.Image")));
            this.fotoCarroA.Location = new System.Drawing.Point(8, 169);
            this.fotoCarroA.Name = "fotoCarroA";
            this.fotoCarroA.Size = new System.Drawing.Size(529, 386);
            this.fotoCarroA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotoCarroA.TabIndex = 7;
            this.fotoCarroA.TabStop = false;
            // 
            // gridCarroA
            // 
            this.gridCarroA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarroA.Location = new System.Drawing.Point(715, 116);
            this.gridCarroA.Name = "gridCarroA";
            this.gridCarroA.Size = new System.Drawing.Size(240, 150);
            this.gridCarroA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carro 3 portas a gasolina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(1180, 46);
            this.bigLabel1.TabIndex = 4;
            this.bigLabel1.Text = "Classe A";
            // 
            // FormICarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 646);
            this.Controls.Add(this.fotoCarroA);
            this.Controls.Add(this.gridCarroA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.Name = "FormICarro";
            this.Text = "FormICarro";
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarroA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoCarroA;
        private System.Windows.Forms.DataGridView gridCarroA;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}