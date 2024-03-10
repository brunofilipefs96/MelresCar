namespace Automobile
{
    partial class UC_ListarCamioneta
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelMotaC = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.LabelMotaB = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.LabelMotaA = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.CCamioneta = new System.Windows.Forms.Button();
            this.BCamioneta = new System.Windows.Forms.Button();
            this.ACamioneta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMotaC
            // 
            this.LabelMotaC.BackColor = System.Drawing.Color.Transparent;
            this.LabelMotaC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LabelMotaC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LabelMotaC.Location = new System.Drawing.Point(889, 203);
            this.LabelMotaC.Name = "LabelMotaC";
            this.LabelMotaC.Size = new System.Drawing.Size(118, 60);
            this.LabelMotaC.TabIndex = 94;
            this.LabelMotaC.Text = "Classe C Cap.Max 64 Passageiros";
            this.LabelMotaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMotaB
            // 
            this.LabelMotaB.BackColor = System.Drawing.Color.Transparent;
            this.LabelMotaB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LabelMotaB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LabelMotaB.Location = new System.Drawing.Point(627, 203);
            this.LabelMotaB.Name = "LabelMotaB";
            this.LabelMotaB.Size = new System.Drawing.Size(118, 60);
            this.LabelMotaB.TabIndex = 93;
            this.LabelMotaB.Text = "Classe B Cap.Max 16 Passageiros";
            this.LabelMotaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMotaA
            // 
            this.LabelMotaA.BackColor = System.Drawing.Color.Transparent;
            this.LabelMotaA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LabelMotaA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.LabelMotaA.Location = new System.Drawing.Point(364, 203);
            this.LabelMotaA.Name = "LabelMotaA";
            this.LabelMotaA.Size = new System.Drawing.Size(118, 60);
            this.LabelMotaA.TabIndex = 92;
            this.LabelMotaA.Text = "Classe A Cap.Max 8 Passageiros";
            this.LabelMotaA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CCamioneta
            // 
            this.CCamioneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CCamioneta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCamioneta.ForeColor = System.Drawing.Color.White;
            this.CCamioneta.Location = new System.Drawing.Point(889, 97);
            this.CCamioneta.Name = "CCamioneta";
            this.CCamioneta.Size = new System.Drawing.Size(118, 103);
            this.CCamioneta.TabIndex = 91;
            this.CCamioneta.Text = "C";
            this.CCamioneta.UseVisualStyleBackColor = false;
            this.CCamioneta.Click += new System.EventHandler(this.CCamioneta_Click);
            // 
            // BCamioneta
            // 
            this.BCamioneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BCamioneta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCamioneta.ForeColor = System.Drawing.Color.White;
            this.BCamioneta.Location = new System.Drawing.Point(627, 97);
            this.BCamioneta.Name = "BCamioneta";
            this.BCamioneta.Size = new System.Drawing.Size(118, 103);
            this.BCamioneta.TabIndex = 90;
            this.BCamioneta.Text = "B";
            this.BCamioneta.UseVisualStyleBackColor = false;
            this.BCamioneta.Click += new System.EventHandler(this.BCamioneta_Click);
            // 
            // ACamioneta
            // 
            this.ACamioneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ACamioneta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACamioneta.ForeColor = System.Drawing.Color.White;
            this.ACamioneta.Location = new System.Drawing.Point(364, 97);
            this.ACamioneta.Name = "ACamioneta";
            this.ACamioneta.Size = new System.Drawing.Size(118, 103);
            this.ACamioneta.TabIndex = 89;
            this.ACamioneta.Text = "A";
            this.ACamioneta.UseVisualStyleBackColor = false;
            this.ACamioneta.Click += new System.EventHandler(this.ACamioneta_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1395, 50);
            this.label1.TabIndex = 88;
            this.label1.Text = "Classe de Camionetas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_ListarCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelMotaC);
            this.Controls.Add(this.LabelMotaB);
            this.Controls.Add(this.LabelMotaA);
            this.Controls.Add(this.CCamioneta);
            this.Controls.Add(this.BCamioneta);
            this.Controls.Add(this.ACamioneta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_ListarCamioneta";
            this.Size = new System.Drawing.Size(1395, 670);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCamionetas);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel LabelMotaC;
        private ReaLTaiizor.Controls.DungeonHeaderLabel LabelMotaB;
        private ReaLTaiizor.Controls.DungeonHeaderLabel LabelMotaA;
        private System.Windows.Forms.Button CCamioneta;
        private System.Windows.Forms.Button BCamioneta;
        private System.Windows.Forms.Button ACamioneta;
        private System.Windows.Forms.Label label1;
    }
}
