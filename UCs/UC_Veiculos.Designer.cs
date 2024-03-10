namespace Automobile
{
    partial class UC_Veiculos
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
            this.buttonEditVeiculo = new System.Windows.Forms.Button();
            this.buttonRemVeiculo = new System.Windows.Forms.Button();
            this.buttonAddVeiculo = new System.Windows.Forms.Button();
            this.comboBoxTipoVeiculo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.buttonManutencaoVeiculo = new System.Windows.Forms.Button();
            this.dataGridViewVeiculos = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditVeiculo
            // 
            this.buttonEditVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonEditVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonEditVeiculo.Location = new System.Drawing.Point(565, 416);
            this.buttonEditVeiculo.Name = "buttonEditVeiculo";
            this.buttonEditVeiculo.Size = new System.Drawing.Size(144, 40);
            this.buttonEditVeiculo.TabIndex = 10;
            this.buttonEditVeiculo.Text = "Editar";
            this.buttonEditVeiculo.UseVisualStyleBackColor = false;
            this.buttonEditVeiculo.Click += new System.EventHandler(this.buttonEditVeiculo_Click);
            // 
            // buttonRemVeiculo
            // 
            this.buttonRemVeiculo.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonRemVeiculo.Location = new System.Drawing.Point(265, 416);
            this.buttonRemVeiculo.Name = "buttonRemVeiculo";
            this.buttonRemVeiculo.Size = new System.Drawing.Size(144, 40);
            this.buttonRemVeiculo.TabIndex = 9;
            this.buttonRemVeiculo.Text = "Remover";
            this.buttonRemVeiculo.UseVisualStyleBackColor = false;
            this.buttonRemVeiculo.Click += new System.EventHandler(this.buttonRemVeiculo_Click);
            // 
            // buttonAddVeiculo
            // 
            this.buttonAddVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonAddVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonAddVeiculo.Location = new System.Drawing.Point(715, 416);
            this.buttonAddVeiculo.Name = "buttonAddVeiculo";
            this.buttonAddVeiculo.Size = new System.Drawing.Size(144, 40);
            this.buttonAddVeiculo.TabIndex = 8;
            this.buttonAddVeiculo.Text = "Adicionar";
            this.buttonAddVeiculo.UseVisualStyleBackColor = false;
            this.buttonAddVeiculo.Click += new System.EventHandler(this.buttonAddVeiculo_Click);
            // 
            // comboBoxTipoVeiculo
            // 
            this.comboBoxTipoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBoxTipoVeiculo.ColorA = System.Drawing.Color.SkyBlue;
            this.comboBoxTipoVeiculo.ColorB = System.Drawing.Color.CornflowerBlue;
            this.comboBoxTipoVeiculo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.comboBoxTipoVeiculo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.comboBoxTipoVeiculo.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.comboBoxTipoVeiculo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.comboBoxTipoVeiculo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.comboBoxTipoVeiculo.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.comboBoxTipoVeiculo.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBoxTipoVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTipoVeiculo.DropDownHeight = 100;
            this.comboBoxTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTipoVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.comboBoxTipoVeiculo.FormattingEnabled = true;
            this.comboBoxTipoVeiculo.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBoxTipoVeiculo.IntegralHeight = false;
            this.comboBoxTipoVeiculo.ItemHeight = 20;
            this.comboBoxTipoVeiculo.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camião"});
            this.comboBoxTipoVeiculo.Location = new System.Drawing.Point(137, 15);
            this.comboBoxTipoVeiculo.Name = "comboBoxTipoVeiculo";
            this.comboBoxTipoVeiculo.Size = new System.Drawing.Size(153, 26);
            this.comboBoxTipoVeiculo.StartIndex = 0;
            this.comboBoxTipoVeiculo.TabIndex = 12;
            this.comboBoxTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.dungeonComboBox1_SelectedIndexChanged);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(12, 16);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(119, 20);
            this.dungeonHeaderLabel1.TabIndex = 13;
            this.dungeonHeaderLabel1.Text = "Tipo de Veículo:";
            // 
            // buttonManutencaoVeiculo
            // 
            this.buttonManutencaoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonManutencaoVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManutencaoVeiculo.ForeColor = System.Drawing.Color.White;
            this.buttonManutencaoVeiculo.Location = new System.Drawing.Point(415, 416);
            this.buttonManutencaoVeiculo.Name = "buttonManutencaoVeiculo";
            this.buttonManutencaoVeiculo.Size = new System.Drawing.Size(144, 40);
            this.buttonManutencaoVeiculo.TabIndex = 14;
            this.buttonManutencaoVeiculo.Text = "Manutenção";
            this.buttonManutencaoVeiculo.UseVisualStyleBackColor = false;
            this.buttonManutencaoVeiculo.Click += new System.EventHandler(this.buttonManutencaoVeiculo_Click);
            // 
            // dataGridViewVeiculos
            // 
            this.dataGridViewVeiculos.AllowUserToResizeRows = false;
            this.dataGridViewVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVeiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVeiculos.EnableHeadersVisualStyles = false;
            this.dataGridViewVeiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewVeiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewVeiculos.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            this.dataGridViewVeiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVeiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVeiculos.Size = new System.Drawing.Size(887, 358);
            this.dataGridViewVeiculos.TabIndex = 15;
            // 
            // UC_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.buttonManutencaoVeiculo);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.comboBoxTipoVeiculo);
            this.Controls.Add(this.buttonEditVeiculo);
            this.Controls.Add(this.buttonRemVeiculo);
            this.Controls.Add(this.buttonAddVeiculo);
            this.Name = "UC_Veiculos";
            this.Size = new System.Drawing.Size(907, 478);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintVeiculos);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEditVeiculo;
        private System.Windows.Forms.Button buttonRemVeiculo;
        private System.Windows.Forms.Button buttonAddVeiculo;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxTipoVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.Button buttonManutencaoVeiculo;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewVeiculos;
    }
}
