﻿namespace Automobile
{
    partial class UC_Funcionarios
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
            this.buttonEditFuncionario = new System.Windows.Forms.Button();
            this.buttonRemFuncionario = new System.Windows.Forms.Button();
            this.buttonAddFuncionario = new System.Windows.Forms.Button();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditFuncionario
            // 
            this.buttonEditFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonEditFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFuncionario.ForeColor = System.Drawing.Color.White;
            this.buttonEditFuncionario.Location = new System.Drawing.Point(3, 161);
            this.buttonEditFuncionario.Name = "buttonEditFuncionario";
            this.buttonEditFuncionario.Size = new System.Drawing.Size(206, 95);
            this.buttonEditFuncionario.TabIndex = 9;
            this.buttonEditFuncionario.Text = "Editar Funcionário";
            this.buttonEditFuncionario.UseVisualStyleBackColor = false;
            this.buttonEditFuncionario.Click += new System.EventHandler(this.buttonEditFuncionario_Click);
            // 
            // buttonRemFuncionario
            // 
            this.buttonRemFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonRemFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemFuncionario.ForeColor = System.Drawing.Color.White;
            this.buttonRemFuncionario.Location = new System.Drawing.Point(3, 277);
            this.buttonRemFuncionario.Name = "buttonRemFuncionario";
            this.buttonRemFuncionario.Size = new System.Drawing.Size(206, 95);
            this.buttonRemFuncionario.TabIndex = 8;
            this.buttonRemFuncionario.Text = "Remover Funcionário";
            this.buttonRemFuncionario.UseVisualStyleBackColor = false;
            this.buttonRemFuncionario.Click += new System.EventHandler(this.buttonRemFuncionario_Click);
            // 
            // buttonAddFuncionario
            // 
            this.buttonAddFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonAddFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFuncionario.ForeColor = System.Drawing.Color.White;
            this.buttonAddFuncionario.Location = new System.Drawing.Point(3, 45);
            this.buttonAddFuncionario.Name = "buttonAddFuncionario";
            this.buttonAddFuncionario.Size = new System.Drawing.Size(206, 95);
            this.buttonAddFuncionario.TabIndex = 7;
            this.buttonAddFuncionario.Text = "Adicionar Funcionário";
            this.buttonAddFuncionario.UseVisualStyleBackColor = false;
            this.buttonAddFuncionario.Click += new System.EventHandler(this.buttonAddFuncionario_Click);
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFuncionario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(215, 45);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(668, 322);
            this.dataGridViewFuncionario.TabIndex = 10;
            // 
            // UC_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.buttonEditFuncionario);
            this.Controls.Add(this.buttonRemFuncionario);
            this.Controls.Add(this.buttonAddFuncionario);
            this.Name = "UC_Funcionarios";
            this.Size = new System.Drawing.Size(907, 478);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditFuncionario;
        private System.Windows.Forms.Button buttonRemFuncionario;
        private System.Windows.Forms.Button buttonAddFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
    }
}