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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelDataInicio.Location = new System.Drawing.Point(83, 34);
            this.labelDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(107, 25);
            this.labelDataInicio.TabIndex = 31;
            this.labelDataInicio.Text = "Data Inicio";
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelDataFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelDataFim.Location = new System.Drawing.Point(385, 34);
            this.labelDataFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(90, 25);
            this.labelDataFim.TabIndex = 33;
            this.labelDataFim.Text = "Data Fim";
            // 
            // buttonAdicionarReserva
            // 
            this.buttonAdicionarReserva.Location = new System.Drawing.Point(846, 587);
            this.buttonAdicionarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarReserva.Name = "buttonAdicionarReserva";
            this.buttonAdicionarReserva.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonAdicionarReserva.Size = new System.Drawing.Size(156, 64);
            this.buttonAdicionarReserva.TabIndex = 34;
            this.buttonAdicionarReserva.Text = "Adicionar";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(115, 587);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancelar.Size = new System.Drawing.Size(156, 64);
            this.buttonCancelar.TabIndex = 60;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNif
            // 
            this.textBoxNif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxNif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxNif.Location = new System.Drawing.Point(1523, 609);
            this.textBoxNif.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNif.MaxLength = 9;
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(203, 22);
            this.textBoxNif.TabIndex = 61;
            this.textBoxNif.TextChanged += new System.EventHandler(this.textBoxNif_TextChanged);
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.BackColor = System.Drawing.Color.Transparent;
            this.labelNif.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNif.Location = new System.Drawing.Point(1470, 609);
            this.labelNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(45, 25);
            this.labelNif.TabIndex = 62;
            this.labelNif.Text = "Nif:";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewClientes.Location = new System.Drawing.Point(1346, 74);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(553, 487);
            this.dataGridViewClientes.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // precoTotal
            // 
            this.precoTotal.AutoSize = true;
            this.precoTotal.BackColor = System.Drawing.Color.Transparent;
            this.precoTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.precoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.precoTotal.Location = new System.Drawing.Point(238, 254);
            this.precoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.Size = new System.Drawing.Size(116, 25);
            this.precoTotal.TabIndex = 67;
            this.precoTotal.Text = "Preço Total:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2.Location = new System.Drawing.Point(334, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 68;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(841, 25);
            this.dungeonHeaderLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(161, 25);
            this.dungeonHeaderLabel1.TabIndex = 69;
            this.dungeonHeaderLabel1.Text = "Lista de Reservas";
            // 
            // dungeonHeaderLabel2
            // 
            this.dungeonHeaderLabel2.AutoSize = true;
            this.dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel2.Location = new System.Drawing.Point(1541, 25);
            this.dungeonHeaderLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            this.dungeonHeaderLabel2.Size = new System.Drawing.Size(153, 25);
            this.dungeonHeaderLabel2.TabIndex = 70;
            this.dungeonHeaderLabel2.Text = "Lista de Clientes";
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReservas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewReservas.Location = new System.Drawing.Point(550, 74);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewReservas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReservas.RowTemplate.Height = 24;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(753, 487);
            this.dataGridViewReservas.TabIndex = 71;
            // 
            // MenuAdicionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 807);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}