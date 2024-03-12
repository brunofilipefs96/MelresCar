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
            this.comboBoxTipoVeiculo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dataGridViewVeiculos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.buttonAddVeiculo = new ReaLTaiizor.Controls.Button();
            this.buttonEditVeiculo = new ReaLTaiizor.Controls.Button();
            this.buttonManutencaoVeiculo = new ReaLTaiizor.Controls.Button();
            this.buttonRemVeiculo = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoVeiculo
            // 
            this.comboBoxTipoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxTipoVeiculo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxTipoVeiculo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxTipoVeiculo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxTipoVeiculo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxTipoVeiculo.ColorE = System.Drawing.Color.White;
            this.comboBoxTipoVeiculo.ColorF = System.Drawing.Color.White;
            this.comboBoxTipoVeiculo.ColorG = System.Drawing.Color.White;
            this.comboBoxTipoVeiculo.ColorH = System.Drawing.Color.White;
            this.comboBoxTipoVeiculo.ColorI = System.Drawing.Color.Gainsboro;
            this.comboBoxTipoVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTipoVeiculo.DropDownHeight = 100;
            this.comboBoxTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoVeiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxTipoVeiculo.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoVeiculo.FormattingEnabled = true;
            this.comboBoxTipoVeiculo.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(12, 16);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(117, 21);
            this.dungeonHeaderLabel1.TabIndex = 13;
            this.dungeonHeaderLabel1.Text = "Tipo de Veículo:";
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
            this.dataGridViewVeiculos.ReadOnly = true;
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
            // buttonAddVeiculo
            // 
            this.buttonAddVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVeiculo.Image = null;
            this.buttonAddVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.Location = new System.Drawing.Point(741, 416);
            this.buttonAddVeiculo.Name = "buttonAddVeiculo";
            this.buttonAddVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAddVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonAddVeiculo.TabIndex = 16;
            this.buttonAddVeiculo.Text = "Adicionar";
            this.buttonAddVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonAddVeiculo.Click += new System.EventHandler(this.buttonAddVeiculo_Click_1);
            // 
            // buttonEditVeiculo
            // 
            this.buttonEditVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditVeiculo.Image = null;
            this.buttonEditVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.Location = new System.Drawing.Point(615, 416);
            this.buttonEditVeiculo.Name = "buttonEditVeiculo";
            this.buttonEditVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonEditVeiculo.TabIndex = 17;
            this.buttonEditVeiculo.Text = "Editar";
            this.buttonEditVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonEditVeiculo.Click += new System.EventHandler(this.buttonEditVeiculo_Click_1);
            // 
            // buttonManutencaoVeiculo
            // 
            this.buttonManutencaoVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonManutencaoVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManutencaoVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManutencaoVeiculo.Image = null;
            this.buttonManutencaoVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManutencaoVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.Location = new System.Drawing.Point(489, 416);
            this.buttonManutencaoVeiculo.Name = "buttonManutencaoVeiculo";
            this.buttonManutencaoVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonManutencaoVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonManutencaoVeiculo.TabIndex = 18;
            this.buttonManutencaoVeiculo.Text = "Manutenção";
            this.buttonManutencaoVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonManutencaoVeiculo.Click += new System.EventHandler(this.buttonManutencaoVeiculo_Click_1);
            // 
            // buttonRemVeiculo
            // 
            this.buttonRemVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemVeiculo.Image = null;
            this.buttonRemVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.Location = new System.Drawing.Point(363, 416);
            this.buttonRemVeiculo.Name = "buttonRemVeiculo";
            this.buttonRemVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonRemVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonRemVeiculo.TabIndex = 19;
            this.buttonRemVeiculo.Text = "Remover";
            this.buttonRemVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonRemVeiculo.Click += new System.EventHandler(this.buttonRemVeiculo_Click_1);
            // 
            // UC_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonRemVeiculo);
            this.Controls.Add(this.buttonManutencaoVeiculo);
            this.Controls.Add(this.buttonEditVeiculo);
            this.Controls.Add(this.buttonAddVeiculo);
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.comboBoxTipoVeiculo);
            this.Name = "UC_Veiculos";
            this.Size = new System.Drawing.Size(907, 478);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintVeiculos);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxTipoVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewVeiculos;
        private ReaLTaiizor.Controls.Button buttonAddVeiculo;
        private ReaLTaiizor.Controls.Button buttonEditVeiculo;
        private ReaLTaiizor.Controls.Button buttonManutencaoVeiculo;
        private ReaLTaiizor.Controls.Button buttonRemVeiculo;
    }
}
