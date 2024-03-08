namespace Automobile.Forms
{
    partial class MenuAdicionarReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDataInicio = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelDataFim = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.buttonAdicionarReserva = new ReaLTaiizor.Controls.CrownButton();
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.textBoxNif = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelNif = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.precoTotal = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.airCheckBox1 = new ReaLTaiizor.Controls.AirCheckBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.labelVeiculo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPrecoDiario = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelDataInicio.Location = new System.Drawing.Point(64, 122);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(88, 20);
            this.labelDataInicio.TabIndex = 31;
            this.labelDataInicio.Text = "Data Inicio:";
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDataFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelDataFim.Location = new System.Drawing.Point(76, 328);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(76, 20);
            this.labelDataFim.TabIndex = 33;
            this.labelDataFim.Text = "Data Fim:";
            // 
            // buttonAdicionarReserva
            // 
            this.buttonAdicionarReserva.Location = new System.Drawing.Point(352, 516);
            this.buttonAdicionarReserva.Name = "buttonAdicionarReserva";
            this.buttonAdicionarReserva.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAdicionarReserva.Size = new System.Drawing.Size(89, 38);
            this.buttonAdicionarReserva.TabIndex = 34;
            this.buttonAdicionarReserva.Text = "Adicionar";
            this.buttonAdicionarReserva.Click += new System.EventHandler(this.buttonAdicionarReserva_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(257, 516);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCancelar.Size = new System.Drawing.Size(89, 38);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNif
            // 
            this.textBoxNif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxNif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxNif.Location = new System.Drawing.Point(663, 74);
            this.textBoxNif.MaxLength = 9;
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(153, 20);
            this.textBoxNif.TabIndex = 61;
            this.textBoxNif.TextChanged += new System.EventHandler(this.textBoxNif_TextChanged);
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.BackColor = System.Drawing.Color.Transparent;
            this.labelNif.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNif.Location = new System.Drawing.Point(547, 74);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(110, 20);
            this.labelNif.TabIndex = 62;
            this.labelNif.Text = "Filtrar por Nif:";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.Location = new System.Drawing.Point(471, 115);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(415, 439);
            this.dataGridViewClientes.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 121);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // precoTotal
            // 
            this.precoTotal.AutoSize = true;
            this.precoTotal.BackColor = System.Drawing.Color.Transparent;
            this.precoTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.precoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.precoTotal.Location = new System.Drawing.Point(61, 445);
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.Size = new System.Drawing.Size(91, 20);
            this.precoTotal.TabIndex = 67;
            this.precoTotal.Text = "Preço Total:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 327);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 68;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(1124, 30);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(130, 20);
            this.dungeonHeaderLabel1.TabIndex = 69;
            this.dungeonHeaderLabel1.Text = "Lista de Reservas";
            // 
            // dungeonHeaderLabel2
            // 
            this.dungeonHeaderLabel2.AutoSize = true;
            this.dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel2.Location = new System.Drawing.Point(617, 30);
            this.dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            this.dungeonHeaderLabel2.Size = new System.Drawing.Size(122, 20);
            this.dungeonHeaderLabel2.TabIndex = 70;
            this.dungeonHeaderLabel2.Text = "Lista de Clientes";
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReservas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReservas.Location = new System.Drawing.Point(905, 71);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(565, 483);
            this.dataGridViewReservas.TabIndex = 71;
            // 
            // airCheckBox1
            // 
            this.airCheckBox1.Checked = false;
            this.airCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airCheckBox1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.airCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airCheckBox1.Image = null;
            this.airCheckBox1.Location = new System.Drawing.Point(153, 154);
            this.airCheckBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.airCheckBox1.Name = "airCheckBox1";
            this.airCheckBox1.NoRounding = false;
            this.airCheckBox1.Size = new System.Drawing.Size(206, 17);
            this.airCheckBox1.TabIndex = 73;
            this.airCheckBox1.Text = "Selecionar Data e Hora Atual";
            this.airCheckBox1.Transparent = false;
            this.airCheckBox1.CheckedChanged += new ReaLTaiizor.Controls.AirCheckBox.CheckedChangedEventHandler(this.airCheckBox1_CheckedChanged);
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(12, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(224, 46);
            this.bigLabel1.TabIndex = 74;
            this.bigLabel1.Text = "Criar Reserva";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelVeiculo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelVeiculo.Location = new System.Drawing.Point(85, 71);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(67, 20);
            this.labelVeiculo.TabIndex = 75;
            this.labelVeiculo.Text = "Veículo: ";
            // 
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(54, 424);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(102, 20);
            this.labelPrecoDiario.TabIndex = 76;
            this.labelPrecoDiario.Text = "Preço Diário: ";
            // 
            // MenuAdicionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1484, 566);
            this.ControlBox = false;
            this.Controls.Add(this.labelPrecoDiario);
            this.Controls.Add(this.labelVeiculo);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.airCheckBox1);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.dungeonHeaderLabel2);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.precoTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.labelNif);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarReserva);
            this.Controls.Add(this.labelDataFim);
            this.Controls.Add(this.labelDataInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuAdicionarReserva";
            this.Text = "MelresCar | MenuAdicionarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelDataInicio;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelDataFim;
        private ReaLTaiizor.Controls.CrownButton buttonAdicionarReserva;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownTextBox textBoxNif;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNif;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel precoTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private ReaLTaiizor.Controls.AirCheckBox airCheckBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPrecoDiario;
    }
}