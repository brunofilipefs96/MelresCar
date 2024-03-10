namespace Automobile
{
    partial class MenuAdicionarVeiculo
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
            this.buttonAdicionarVeiculo = new ReaLTaiizor.Controls.CrownButton();
            this.labelEscolheTipo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.comboBoxEscolherVeiculo = new ReaLTaiizor.Controls.ForeverComboBox();
            this.comboBoxCilindrada = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxNumPortas = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxEixos = new ReaLTaiizor.Controls.CrownComboBox();
            this.labelPrecoDiario = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPassageiros = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelAno = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCilindrada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCombustivel = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCaixa = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMatricula = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelNumPortas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxMatricula = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxMarca = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelEixos = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelModelo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMarca = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPesoMax = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxModelo = new ReaLTaiizor.Controls.CrownTextBox();
            this.comboBoxCombustivel = new ReaLTaiizor.Controls.CrownComboBox();
            this.comboBoxCaixa = new ReaLTaiizor.Controls.CrownComboBox();
            this.numericPrecoDia = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericAno = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericNumPassageiros = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericPesoMax = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(538, 386);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCancelar.Size = new System.Drawing.Size(117, 52);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(671, 386);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(117, 52);
            this.buttonAdicionarVeiculo.TabIndex = 46;
            this.buttonAdicionarVeiculo.Text = "Adicionar";
            this.buttonAdicionarVeiculo.Click += new System.EventHandler(this.buttonAdicionarVeiculo_Click);
            // 
            // labelEscolheTipo
            // 
            this.labelEscolheTipo.AutoSize = true;
            this.labelEscolheTipo.BackColor = System.Drawing.Color.Transparent;
            this.labelEscolheTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEscolheTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelEscolheTipo.Location = new System.Drawing.Point(50, 92);
            this.labelEscolheTipo.Name = "labelEscolheTipo";
            this.labelEscolheTipo.Size = new System.Drawing.Size(119, 20);
            this.labelEscolheTipo.TabIndex = 44;
            this.labelEscolheTipo.Text = "Tipo de Veiculo:";
            // 
            // comboBoxEscolherVeiculo
            // 
            this.comboBoxEscolherVeiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.comboBoxEscolherVeiculo.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comboBoxEscolherVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEscolherVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEscolherVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEscolherVeiculo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboBoxEscolherVeiculo.ForeColor = System.Drawing.Color.White;
            this.comboBoxEscolherVeiculo.FormattingEnabled = true;
            this.comboBoxEscolherVeiculo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboBoxEscolherVeiculo.HoverFontColor = System.Drawing.Color.White;
            this.comboBoxEscolherVeiculo.ItemHeight = 18;
            this.comboBoxEscolherVeiculo.Items.AddRange(new object[] {
            "carro",
            "mota",
            "camioneta",
            "camiao"});
            this.comboBoxEscolherVeiculo.Location = new System.Drawing.Point(175, 92);
            this.comboBoxEscolherVeiculo.Name = "comboBoxEscolherVeiculo";
            this.comboBoxEscolherVeiculo.Size = new System.Drawing.Size(173, 24);
            this.comboBoxEscolherVeiculo.TabIndex = 1;
            this.comboBoxEscolherVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboBoxEscolherVeiculo_SelectedIndexChanged);
            // 
            // comboBoxCilindrada
            // 
            this.comboBoxCilindrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCilindrada.FormattingEnabled = true;
            this.comboBoxCilindrada.Items.AddRange(new object[] {
            "50",
            "125",
            "300"});
            this.comboBoxCilindrada.Location = new System.Drawing.Point(525, 134);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCilindrada.TabIndex = 53;
            // 
            // comboBoxNumPortas
            // 
            this.comboBoxNumPortas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxNumPortas.FormattingEnabled = true;
            this.comboBoxNumPortas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.comboBoxNumPortas.Location = new System.Drawing.Point(525, 134);
            this.comboBoxNumPortas.Name = "comboBoxNumPortas";
            this.comboBoxNumPortas.Size = new System.Drawing.Size(163, 21);
            this.comboBoxNumPortas.TabIndex = 55;
            // 
            // comboBoxEixos
            // 
            this.comboBoxEixos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEixos.FormattingEnabled = true;
            this.comboBoxEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxEixos.Location = new System.Drawing.Point(525, 133);
            this.comboBoxEixos.Name = "comboBoxEixos";
            this.comboBoxEixos.Size = new System.Drawing.Size(163, 21);
            this.comboBoxEixos.TabIndex = 56;
            // 
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(87, 265);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(82, 20);
            this.labelPrecoDiario.TabIndex = 14;
            this.labelPrecoDiario.Text = "Preço/Dia:";
            // 
            // labelPassageiros
            // 
            this.labelPassageiros.AutoSize = true;
            this.labelPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.labelPassageiros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPassageiros.Location = new System.Drawing.Point(402, 159);
            this.labelPassageiros.Name = "labelPassageiros";
            this.labelPassageiros.Size = new System.Drawing.Size(118, 20);
            this.labelPassageiros.TabIndex = 16;
            this.labelPassageiros.Text = "Nº Passageiros:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.Color.Transparent;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelAno.Location = new System.Drawing.Point(127, 239);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(42, 20);
            this.labelAno.TabIndex = 11;
            this.labelAno.Text = "Ano:";
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.BackColor = System.Drawing.Color.Transparent;
            this.labelCilindrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCilindrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCilindrada.Location = new System.Drawing.Point(437, 135);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(83, 20);
            this.labelCilindrada.TabIndex = 17;
            this.labelCilindrada.Text = "Cilindrada:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.labelCombustivel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCombustivel.Location = new System.Drawing.Point(73, 213);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(100, 20);
            this.labelCombustivel.TabIndex = 10;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.BackColor = System.Drawing.Color.Transparent;
            this.labelCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCaixa.Location = new System.Drawing.Point(467, 161);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(50, 20);
            this.labelCaixa.TabIndex = 19;
            this.labelCaixa.Text = "Caixa:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.BackColor = System.Drawing.Color.Transparent;
            this.labelMatricula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelMatricula.Location = new System.Drawing.Point(94, 187);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(79, 20);
            this.labelMatricula.TabIndex = 8;
            this.labelMatricula.Text = "Matricula:";
            // 
            // labelNumPortas
            // 
            this.labelNumPortas.AutoSize = true;
            this.labelNumPortas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPortas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNumPortas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNumPortas.Location = new System.Drawing.Point(438, 134);
            this.labelNumPortas.Name = "labelNumPortas";
            this.labelNumPortas.Size = new System.Drawing.Size(81, 20);
            this.labelNumPortas.TabIndex = 21;
            this.labelNumPortas.Text = "Nº Portas:";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMatricula.Location = new System.Drawing.Point(175, 187);
            this.textBoxMatricula.MaxLength = 8;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(85, 20);
            this.textBoxMatricula.TabIndex = 4;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textBoxMatricula_TextChanged);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMarca.Location = new System.Drawing.Point(175, 135);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(129, 20);
            this.textBoxMarca.TabIndex = 2;
            // 
            // labelEixos
            // 
            this.labelEixos.AutoSize = true;
            this.labelEixos.BackColor = System.Drawing.Color.Transparent;
            this.labelEixos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelEixos.Location = new System.Drawing.Point(444, 133);
            this.labelEixos.Name = "labelEixos";
            this.labelEixos.Size = new System.Drawing.Size(72, 20);
            this.labelEixos.TabIndex = 23;
            this.labelEixos.Text = "Nº Eixos:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.BackColor = System.Drawing.Color.Transparent;
            this.labelModelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelModelo.Location = new System.Drawing.Point(107, 161);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(66, 20);
            this.labelModelo.TabIndex = 4;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelMarca.Location = new System.Drawing.Point(113, 135);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(60, 20);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelPesoMax
            // 
            this.labelPesoMax.AutoSize = true;
            this.labelPesoMax.BackColor = System.Drawing.Color.Transparent;
            this.labelPesoMax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPesoMax.Location = new System.Drawing.Point(402, 131);
            this.labelPesoMax.Name = "labelPesoMax";
            this.labelPesoMax.Size = new System.Drawing.Size(118, 20);
            this.labelPesoMax.TabIndex = 25;
            this.labelPesoMax.Text = "Peso/Max (Kg):";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxModelo.Location = new System.Drawing.Point(175, 161);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(129, 20);
            this.textBoxModelo.TabIndex = 3;
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
            this.comboBoxCombustivel.Location = new System.Drawing.Point(175, 212);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCombustivel.TabIndex = 5;
            this.comboBoxCombustivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombustivel_SelectedIndexChanged);
            // 
            // comboBoxCaixa
            // 
            this.comboBoxCaixa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCaixa.FormattingEnabled = true;
            this.comboBoxCaixa.Items.AddRange(new object[] {
            "manual",
            "automatica"});
            this.comboBoxCaixa.Location = new System.Drawing.Point(525, 161);
            this.comboBoxCaixa.Name = "comboBoxCaixa";
            this.comboBoxCaixa.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCaixa.TabIndex = 54;
            // 
            // numericPrecoDia
            // 
            this.numericPrecoDia.DecimalPlaces = 2;
            this.numericPrecoDia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericPrecoDia.Location = new System.Drawing.Point(175, 265);
            this.numericPrecoDia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPrecoDia.Name = "numericPrecoDia";
            this.numericPrecoDia.Size = new System.Drawing.Size(73, 20);
            this.numericPrecoDia.TabIndex = 7;
            // 
            // numericAno
            // 
            this.numericAno.Location = new System.Drawing.Point(175, 239);
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
            this.numericAno.TabIndex = 6;
            this.numericAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericNumPassageiros
            // 
            this.numericNumPassageiros.Location = new System.Drawing.Point(525, 161);
            this.numericNumPassageiros.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericNumPassageiros.Name = "numericNumPassageiros";
            this.numericNumPassageiros.Size = new System.Drawing.Size(62, 20);
            this.numericNumPassageiros.TabIndex = 60;
            // 
            // numericPesoMax
            // 
            this.numericPesoMax.DecimalPlaces = 2;
            this.numericPesoMax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPesoMax.Location = new System.Drawing.Point(526, 133);
            this.numericPesoMax.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.numericPesoMax.Name = "numericPesoMax";
            this.numericPesoMax.Size = new System.Drawing.Size(73, 20);
            this.numericPesoMax.TabIndex = 61;
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(800, 46);
            this.bigLabel1.TabIndex = 62;
            this.bigLabel1.Text = "Adicionar Veículo";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuAdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.numericPesoMax);
            this.Controls.Add(this.numericNumPassageiros);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.numericPrecoDia);
            this.Controls.Add(this.labelEscolheTipo);
            this.Controls.Add(this.comboBoxCaixa);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.comboBoxEscolherVeiculo);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.comboBoxNumPortas);
            this.Controls.Add(this.comboBoxEixos);
            this.Controls.Add(this.labelPrecoDiario);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelPassageiros);
            this.Controls.Add(this.labelPesoMax);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCilindrada);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelEixos);
            this.Controls.Add(this.labelCaixa);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.labelNumPortas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuAdicionarVeiculo";
            this.Text = "MenuAdicionarVeiculo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintAdicionarVeiculo);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonAdicionarVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEscolheTipo;
        private ReaLTaiizor.Controls.ForeverComboBox comboBoxEscolherVeiculo;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCilindrada;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxNumPortas;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxEixos;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPrecoDiario;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPassageiros;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelAno;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCilindrada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCombustivel;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCaixa;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMatricula;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNumPortas;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMatricula;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEixos;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPesoMax;
        private ReaLTaiizor.Controls.CrownTextBox textBoxModelo;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCombustivel;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxCaixa;
        private ReaLTaiizor.Controls.CrownNumeric numericPrecoDia;
        private ReaLTaiizor.Controls.CrownNumeric numericAno;
        private ReaLTaiizor.Controls.CrownNumeric numericNumPassageiros;
        private ReaLTaiizor.Controls.CrownNumeric numericPesoMax;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}