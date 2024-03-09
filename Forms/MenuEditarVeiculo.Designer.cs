namespace Automobile
{
    partial class MenuEditarVeiculo
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
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.buttonEditarVeiculo = new ReaLTaiizor.Controls.CrownButton();
            this.numericPesoMax = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericNumPassageiros = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericAno = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericPrecoDia = new ReaLTaiizor.Controls.CrownNumeric();
            this.comboBoxCaixa = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxCombustivel = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxEstado = new ReaLTaiizor.Controls.CrownComboBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxModelo = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelPesoMax = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMarca = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelModelo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelEixos = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxMarca = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelNumPortas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCaixa = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCombustivel = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCilindrada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelAno = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPassageiros = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPrecoDiario = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.comboBoxEixos = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxNumPortas = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxCilindrada = new ReaLTaiizor.Controls.CrownComboBox();
            this.labelEditarCliente = new ReaLTaiizor.Controls.BigLabel();
            this.labelVeiculo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(539, 386);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Size = new System.Drawing.Size(117, 52);
            this.buttonCancelar.TabIndex = 52;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditarVeiculo
            // 
            this.buttonEditarVeiculo.Location = new System.Drawing.Point(671, 386);
            this.buttonEditarVeiculo.Name = "buttonEditarVeiculo";
            this.buttonEditarVeiculo.Padding = new System.Windows.Forms.Padding(5);
            this.buttonEditarVeiculo.Size = new System.Drawing.Size(117, 52);
            this.buttonEditarVeiculo.TabIndex = 51;
            this.buttonEditarVeiculo.Text = "Editar";
            this.buttonEditarVeiculo.Click += new System.EventHandler(this.buttonEditarVeiculo_Click);
            // 
            // numericPesoMax
            // 
            this.numericPesoMax.DecimalPlaces = 2;
            this.numericPesoMax.Location = new System.Drawing.Point(544, 123);
            this.numericPesoMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericPesoMax.Name = "numericPesoMax";
            this.numericPesoMax.Size = new System.Drawing.Size(73, 20);
            this.numericPesoMax.TabIndex = 115;
            // 
            // numericNumPassageiros
            // 
            this.numericNumPassageiros.Location = new System.Drawing.Point(543, 151);
            this.numericNumPassageiros.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericNumPassageiros.Name = "numericNumPassageiros";
            this.numericNumPassageiros.Size = new System.Drawing.Size(62, 20);
            this.numericNumPassageiros.TabIndex = 114;
            // 
            // numericAno
            // 
            this.numericAno.Location = new System.Drawing.Point(193, 204);
            this.numericAno.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.numericAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericAno.Name = "numericAno";
            this.numericAno.Size = new System.Drawing.Size(73, 20);
            this.numericAno.TabIndex = 93;
            this.numericAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericPrecoDia
            // 
            this.numericPrecoDia.DecimalPlaces = 2;
            this.numericPrecoDia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericPrecoDia.Location = new System.Drawing.Point(193, 230);
            this.numericPrecoDia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPrecoDia.Name = "numericPrecoDia";
            this.numericPrecoDia.Size = new System.Drawing.Size(73, 20);
            this.numericPrecoDia.TabIndex = 94;
            // 
            // comboBoxCaixa
            // 
            this.comboBoxCaixa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCaixa.FormattingEnabled = true;
            this.comboBoxCaixa.Items.AddRange(new object[] {
            "manual",
            "automatica"});
            this.comboBoxCaixa.Location = new System.Drawing.Point(543, 151);
            this.comboBoxCaixa.Name = "comboBoxCaixa";
            this.comboBoxCaixa.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCaixa.TabIndex = 111;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "gasolina",
            "diesel",
            "hibrido",
            "eletrico"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(193, 177);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCombustivel.TabIndex = 92;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "disponivel",
            "manutencao",
            "reservado",
            "alugado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(193, 256);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(99, 21);
            this.comboBoxEstado.TabIndex = 96;
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(127, 254);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(60, 20);
            this.dungeonHeaderLabel1.TabIndex = 109;
            this.dungeonHeaderLabel1.Text = "Estado:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxModelo.Location = new System.Drawing.Point(193, 151);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(129, 20);
            this.textBoxModelo.TabIndex = 91;
            // 
            // labelPesoMax
            // 
            this.labelPesoMax.AutoSize = true;
            this.labelPesoMax.BackColor = System.Drawing.Color.Transparent;
            this.labelPesoMax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPesoMax.Location = new System.Drawing.Point(451, 120);
            this.labelPesoMax.Name = "labelPesoMax";
            this.labelPesoMax.Size = new System.Drawing.Size(83, 20);
            this.labelPesoMax.TabIndex = 107;
            this.labelPesoMax.Text = "Peso/Max:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelMarca.Location = new System.Drawing.Point(131, 125);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(60, 20);
            this.labelMarca.TabIndex = 97;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.BackColor = System.Drawing.Color.Transparent;
            this.labelModelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelModelo.Location = new System.Drawing.Point(125, 151);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(66, 20);
            this.labelModelo.TabIndex = 98;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelEixos
            // 
            this.labelEixos.AutoSize = true;
            this.labelEixos.BackColor = System.Drawing.Color.Transparent;
            this.labelEixos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelEixos.Location = new System.Drawing.Point(462, 123);
            this.labelEixos.Name = "labelEixos";
            this.labelEixos.Size = new System.Drawing.Size(72, 20);
            this.labelEixos.TabIndex = 106;
            this.labelEixos.Text = "Nº Eixos:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMarca.Location = new System.Drawing.Point(193, 125);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(129, 20);
            this.textBoxMarca.TabIndex = 90;
            // 
            // labelNumPortas
            // 
            this.labelNumPortas.AutoSize = true;
            this.labelNumPortas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPortas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNumPortas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNumPortas.Location = new System.Drawing.Point(456, 124);
            this.labelNumPortas.Name = "labelNumPortas";
            this.labelNumPortas.Size = new System.Drawing.Size(81, 20);
            this.labelNumPortas.TabIndex = 105;
            this.labelNumPortas.Text = "Nº Portas:";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.BackColor = System.Drawing.Color.Transparent;
            this.labelCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCaixa.Location = new System.Drawing.Point(485, 151);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(50, 20);
            this.labelCaixa.TabIndex = 104;
            this.labelCaixa.Text = "Caixa:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.labelCombustivel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCombustivel.Location = new System.Drawing.Point(91, 178);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(100, 20);
            this.labelCombustivel.TabIndex = 99;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.BackColor = System.Drawing.Color.Transparent;
            this.labelCilindrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCilindrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCilindrada.Location = new System.Drawing.Point(455, 125);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(83, 20);
            this.labelCilindrada.TabIndex = 103;
            this.labelCilindrada.Text = "Cilindrada:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.Color.Transparent;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelAno.Location = new System.Drawing.Point(145, 204);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(42, 20);
            this.labelAno.TabIndex = 100;
            this.labelAno.Text = "Ano:";
            // 
            // labelPassageiros
            // 
            this.labelPassageiros.AutoSize = true;
            this.labelPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.labelPassageiros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPassageiros.Location = new System.Drawing.Point(420, 149);
            this.labelPassageiros.Name = "labelPassageiros";
            this.labelPassageiros.Size = new System.Drawing.Size(118, 20);
            this.labelPassageiros.TabIndex = 102;
            this.labelPassageiros.Text = "Nº Passageiros:";
            // 
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(105, 230);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(82, 20);
            this.labelPrecoDiario.TabIndex = 101;
            this.labelPrecoDiario.Text = "Preço/Dia:";
            // 
            // comboBoxEixos
            // 
            this.comboBoxEixos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEixos.FormattingEnabled = true;
            this.comboBoxEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxEixos.Location = new System.Drawing.Point(543, 123);
            this.comboBoxEixos.Name = "comboBoxEixos";
            this.comboBoxEixos.Size = new System.Drawing.Size(163, 21);
            this.comboBoxEixos.TabIndex = 113;
            // 
            // comboBoxNumPortas
            // 
            this.comboBoxNumPortas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxNumPortas.FormattingEnabled = true;
            this.comboBoxNumPortas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.comboBoxNumPortas.Location = new System.Drawing.Point(543, 124);
            this.comboBoxNumPortas.Name = "comboBoxNumPortas";
            this.comboBoxNumPortas.Size = new System.Drawing.Size(163, 21);
            this.comboBoxNumPortas.TabIndex = 112;
            // 
            // comboBoxCilindrada
            // 
            this.comboBoxCilindrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCilindrada.FormattingEnabled = true;
            this.comboBoxCilindrada.Items.AddRange(new object[] {
            "50",
            "125",
            "300"});
            this.comboBoxCilindrada.Location = new System.Drawing.Point(543, 124);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCilindrada.TabIndex = 110;
            // 
            // labelEditarCliente
            // 
            this.labelEditarCliente.AutoSize = true;
            this.labelEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelEditarCliente.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelEditarCliente.Location = new System.Drawing.Point(12, 9);
            this.labelEditarCliente.Name = "labelEditarCliente";
            this.labelEditarCliente.Size = new System.Drawing.Size(223, 46);
            this.labelEditarCliente.TabIndex = 116;
            this.labelEditarCliente.Text = "Editar Veículo";
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelVeiculo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelVeiculo.Location = new System.Drawing.Point(63, 71);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(67, 20);
            this.labelVeiculo.TabIndex = 117;
            this.labelVeiculo.Text = "Veículo: ";
            // 
            // MenuEditarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelVeiculo);
            this.Controls.Add(this.labelEditarCliente);
            this.Controls.Add(this.numericPesoMax);
            this.Controls.Add(this.numericNumPassageiros);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.numericPrecoDia);
            this.Controls.Add(this.comboBoxCaixa);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelPesoMax);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelEixos);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelNumPortas);
            this.Controls.Add(this.labelCaixa);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelCilindrada);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelPassageiros);
            this.Controls.Add(this.labelPrecoDiario);
            this.Controls.Add(this.comboBoxEixos);
            this.Controls.Add(this.comboBoxNumPortas);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditarVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuEditarVeiculo";
            this.Text = "MenuEditarVeiculo";
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonEditarVeiculo;
        private ReaLTaiizor.Controls.CrownNumeric numericPesoMax;
        private ReaLTaiizor.Controls.CrownNumeric numericNumPassageiros;
        private ReaLTaiizor.Controls.CrownNumeric numericAno;
        private ReaLTaiizor.Controls.CrownNumeric numericPrecoDia;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCaixa;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCombustivel;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxEstado;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.CrownTextBox textBoxModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPesoMax;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEixos;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNumPortas;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCaixa;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCombustivel;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCilindrada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelAno;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPassageiros;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPrecoDiario;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxEixos;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxNumPortas;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCilindrada;
        private ReaLTaiizor.Controls.BigLabel labelEditarCliente;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelVeiculo;
    }
}