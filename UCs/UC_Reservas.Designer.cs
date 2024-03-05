namespace Automobile
{
    partial class UC_Reservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCriarReserva = new System.Windows.Forms.Button();
            this.buttonLucroEntreDatas = new System.Windows.Forms.Button();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCriarReserva
            // 
            this.buttonCriarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonCriarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCriarReserva.Location = new System.Drawing.Point(714, 417);
            this.buttonCriarReserva.Name = "buttonCriarReserva";
            this.buttonCriarReserva.Size = new System.Drawing.Size(144, 40);
            this.buttonCriarReserva.TabIndex = 13;
            this.buttonCriarReserva.Text = "Criar Reserva";
            this.buttonCriarReserva.UseVisualStyleBackColor = false;
            this.buttonCriarReserva.Click += new System.EventHandler(this.buttonCriarReserva_Click);
            // 
            // buttonLucroEntreDatas
            // 
            this.buttonLucroEntreDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonLucroEntreDatas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLucroEntreDatas.ForeColor = System.Drawing.Color.White;
            this.buttonLucroEntreDatas.Location = new System.Drawing.Point(564, 417);
            this.buttonLucroEntreDatas.Name = "buttonLucroEntreDatas";
            this.buttonLucroEntreDatas.Size = new System.Drawing.Size(144, 40);
            this.buttonLucroEntreDatas.TabIndex = 15;
            this.buttonLucroEntreDatas.Text = "Lucro Entre Datas";
            this.buttonLucroEntreDatas.UseVisualStyleBackColor = false;
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReservas.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewReservas.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(875, 396);
            this.dataGridViewReservas.TabIndex = 16;
            // 
            // UC_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.buttonLucroEntreDatas);
            this.Controls.Add(this.buttonCriarReserva);
            this.Name = "UC_Reservas";
            this.Size = new System.Drawing.Size(907, 478);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCriarReserva;
        private System.Windows.Forms.Button buttonLucroEntreDatas;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
    }
}
