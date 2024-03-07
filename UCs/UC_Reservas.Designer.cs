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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonCriarReserva.Location = new System.Drawing.Point(952, 513);
            this.buttonCriarReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCriarReserva.Name = "buttonCriarReserva";
            this.buttonCriarReserva.Size = new System.Drawing.Size(192, 49);
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
            this.buttonLucroEntreDatas.Location = new System.Drawing.Point(752, 513);
            this.buttonLucroEntreDatas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLucroEntreDatas.Name = "buttonLucroEntreDatas";
            this.buttonLucroEntreDatas.Size = new System.Drawing.Size(192, 49);
            this.buttonLucroEntreDatas.TabIndex = 15;
            this.buttonLucroEntreDatas.Text = "Lucro Entre Datas";
            this.buttonLucroEntreDatas.UseVisualStyleBackColor = false;
            this.buttonLucroEntreDatas.Click += new System.EventHandler(this.buttonLucroEntreDatas_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReservas.Location = new System.Drawing.Point(19, 20);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(1167, 487);
            this.dataGridViewReservas.TabIndex = 16;
            // 
            // UC_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.buttonLucroEntreDatas);
            this.Controls.Add(this.buttonCriarReserva);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Reservas";
            this.Size = new System.Drawing.Size(1209, 588);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCriarReserva;
        private System.Windows.Forms.Button buttonLucroEntreDatas;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
    }
}
