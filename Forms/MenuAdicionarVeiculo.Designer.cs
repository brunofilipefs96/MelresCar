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
            this.labelEscolheTipo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.comboBoxEscolherVeiculo = new ReaLTaiizor.Controls.ForeverComboBox();
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
            this.numericPrecoDia = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericAno = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericNumPassageiros = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericPesoMax = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.buttonAdicionarVeiculo = new ReaLTaiizor.Controls.Button();
            this.buttonCancelar = new ReaLTaiizor.Controls.Button();
            this.comboBoxCombustivel = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxCilindrada = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxNumPortas = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxEixos = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxCaixa = new ReaLTaiizor.Controls.DungeonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEscolheTipo
            // 
            this.labelEscolheTipo.AutoSize = true;
            this.labelEscolheTipo.BackColor = System.Drawing.Color.Transparent;
            this.labelEscolheTipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelEscolheTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelEscolheTipo.Location = new System.Drawing.Point(50, 92);
            this.labelEscolheTipo.Name = "labelEscolheTipo";
            this.labelEscolheTipo.Size = new System.Drawing.Size(117, 21);
            this.labelEscolheTipo.TabIndex = 44;
            this.labelEscolheTipo.Text = "Tipo de Veiculo:";
            // 
            // comboBoxEscolherVeiculo
            // 
            this.comboBoxEscolherVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEscolherVeiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.comboBoxEscolherVeiculo.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comboBoxEscolherVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEscolherVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEscolherVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEscolherVeiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
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
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(84, 281);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(83, 21);
            this.labelPrecoDiario.TabIndex = 14;
            this.labelPrecoDiario.Text = "Preço/Dia:";
            // 
            // labelPassageiros
            // 
            this.labelPassageiros.AutoSize = true;
            this.labelPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.labelPassageiros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
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
            this.labelAno.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelAno.Location = new System.Drawing.Point(126, 251);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(41, 21);
            this.labelAno.TabIndex = 11;
            this.labelAno.Text = "Ano:";
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.BackColor = System.Drawing.Color.Transparent;
            this.labelCilindrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCilindrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
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
            this.labelCombustivel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelCombustivel.Location = new System.Drawing.Point(73, 218);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(98, 21);
            this.labelCombustivel.TabIndex = 10;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.BackColor = System.Drawing.Color.Transparent;
            this.labelCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
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
            this.labelMatricula.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelMatricula.Location = new System.Drawing.Point(94, 187);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(79, 21);
            this.labelMatricula.TabIndex = 8;
            this.labelMatricula.Text = "Matricula:";
            // 
            // labelNumPortas
            // 
            this.labelNumPortas.AutoSize = true;
            this.labelNumPortas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPortas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNumPortas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelNumPortas.Location = new System.Drawing.Point(438, 134);
            this.labelNumPortas.Name = "labelNumPortas";
            this.labelNumPortas.Size = new System.Drawing.Size(81, 20);
            this.labelNumPortas.TabIndex = 21;
            this.labelNumPortas.Text = "Nº Portas:";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBoxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatricula.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.textBoxMatricula.ForeColor = System.Drawing.Color.White;
            this.textBoxMatricula.Location = new System.Drawing.Point(175, 187);
            this.textBoxMatricula.MaxLength = 8;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(85, 23);
            this.textBoxMatricula.TabIndex = 4;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textBoxMatricula_TextChanged);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.textBoxMarca.ForeColor = System.Drawing.Color.White;
            this.textBoxMarca.Location = new System.Drawing.Point(175, 135);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(129, 23);
            this.textBoxMarca.TabIndex = 2;
            // 
            // labelEixos
            // 
            this.labelEixos.AutoSize = true;
            this.labelEixos.BackColor = System.Drawing.Color.Transparent;
            this.labelEixos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
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
            this.labelModelo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelModelo.Location = new System.Drawing.Point(107, 161);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(64, 21);
            this.labelModelo.TabIndex = 4;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelMarca.Location = new System.Drawing.Point(113, 135);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(61, 21);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelPesoMax
            // 
            this.labelPesoMax.AutoSize = true;
            this.labelPesoMax.BackColor = System.Drawing.Color.Transparent;
            this.labelPesoMax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelPesoMax.Location = new System.Drawing.Point(402, 131);
            this.labelPesoMax.Name = "labelPesoMax";
            this.labelPesoMax.Size = new System.Drawing.Size(118, 20);
            this.labelPesoMax.TabIndex = 25;
            this.labelPesoMax.Text = "Peso/Max (Kg):";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.textBoxModelo.ForeColor = System.Drawing.Color.White;
            this.textBoxModelo.Location = new System.Drawing.Point(175, 161);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(129, 23);
            this.textBoxModelo.TabIndex = 3;
            // 
            // numericPrecoDia
            // 
            this.numericPrecoDia.DecimalPlaces = 2;
            this.numericPrecoDia.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.numericPrecoDia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericPrecoDia.Location = new System.Drawing.Point(175, 284);
            this.numericPrecoDia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPrecoDia.Name = "numericPrecoDia";
            this.numericPrecoDia.Size = new System.Drawing.Size(73, 23);
            this.numericPrecoDia.TabIndex = 7;
            // 
            // numericAno
            // 
            this.numericAno.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.numericAno.Location = new System.Drawing.Point(175, 254);
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
            this.numericAno.Size = new System.Drawing.Size(73, 23);
            this.numericAno.TabIndex = 6;
            this.numericAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericAno.Paint += new System.Windows.Forms.PaintEventHandler(this.pintaAno);
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
            this.bigLabel1.Font = new System.Drawing.Font("Stencil", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bigLabel1.Location = new System.Drawing.Point(0, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(800, 46);
            this.bigLabel1.TabIndex = 62;
            this.bigLabel1.Text = "Adicionar Veículo";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionarVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionarVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarVeiculo.Image = null;
            this.buttonAdicionarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(642, 398);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonAdicionarVeiculo.TabIndex = 97;
            this.buttonAdicionarVeiculo.Text = "Adicionar";
            this.buttonAdicionarVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonAdicionarVeiculo.Click += new System.EventHandler(this.buttonAdicionarVeiculo_Click_1);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = null;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Location = new System.Drawing.Point(516, 398);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelar.TabIndex = 98;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxCombustivel.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCombustivel.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCombustivel.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCombustivel.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCombustivel.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCombustivel.ColorF = System.Drawing.Color.White;
            this.comboBoxCombustivel.ColorG = System.Drawing.Color.White;
            this.comboBoxCombustivel.ColorH = System.Drawing.Color.White;
            this.comboBoxCombustivel.ColorI = System.Drawing.Color.White;
            this.comboBoxCombustivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCombustivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCombustivel.DropDownHeight = 100;
            this.comboBoxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCombustivel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxCombustivel.ForeColor = System.Drawing.Color.White;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCombustivel.IntegralHeight = false;
            this.comboBoxCombustivel.ItemHeight = 20;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "gasolina",
            "diesel",
            "hibrido",
            "eletrico"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(174, 213);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCombustivel.StartIndex = 0;
            this.comboBoxCombustivel.TabIndex = 99;
            // 
            // comboBoxCilindrada
            // 
            this.comboBoxCilindrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxCilindrada.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCilindrada.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCilindrada.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCilindrada.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCilindrada.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCilindrada.ColorF = System.Drawing.Color.White;
            this.comboBoxCilindrada.ColorG = System.Drawing.Color.White;
            this.comboBoxCilindrada.ColorH = System.Drawing.Color.White;
            this.comboBoxCilindrada.ColorI = System.Drawing.Color.White;
            this.comboBoxCilindrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCilindrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCilindrada.DropDownHeight = 100;
            this.comboBoxCilindrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCilindrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCilindrada.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxCilindrada.ForeColor = System.Drawing.Color.White;
            this.comboBoxCilindrada.FormattingEnabled = true;
            this.comboBoxCilindrada.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCilindrada.IntegralHeight = false;
            this.comboBoxCilindrada.ItemHeight = 20;
            this.comboBoxCilindrada.Items.AddRange(new object[] {
            "50",
            "125",
            "300"});
            this.comboBoxCilindrada.Location = new System.Drawing.Point(526, 129);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCilindrada.StartIndex = 0;
            this.comboBoxCilindrada.TabIndex = 100;
            // 
            // comboBoxNumPortas
            // 
            this.comboBoxNumPortas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxNumPortas.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxNumPortas.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxNumPortas.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxNumPortas.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxNumPortas.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxNumPortas.ColorF = System.Drawing.Color.White;
            this.comboBoxNumPortas.ColorG = System.Drawing.Color.White;
            this.comboBoxNumPortas.ColorH = System.Drawing.Color.White;
            this.comboBoxNumPortas.ColorI = System.Drawing.Color.White;
            this.comboBoxNumPortas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNumPortas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNumPortas.DropDownHeight = 100;
            this.comboBoxNumPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumPortas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNumPortas.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxNumPortas.ForeColor = System.Drawing.Color.White;
            this.comboBoxNumPortas.FormattingEnabled = true;
            this.comboBoxNumPortas.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxNumPortas.IntegralHeight = false;
            this.comboBoxNumPortas.ItemHeight = 20;
            this.comboBoxNumPortas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.comboBoxNumPortas.Location = new System.Drawing.Point(526, 129);
            this.comboBoxNumPortas.Name = "comboBoxNumPortas";
            this.comboBoxNumPortas.Size = new System.Drawing.Size(138, 26);
            this.comboBoxNumPortas.StartIndex = 0;
            this.comboBoxNumPortas.TabIndex = 101;
            // 
            // comboBoxEixos
            // 
            this.comboBoxEixos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxEixos.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEixos.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEixos.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEixos.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEixos.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxEixos.ColorF = System.Drawing.Color.White;
            this.comboBoxEixos.ColorG = System.Drawing.Color.White;
            this.comboBoxEixos.ColorH = System.Drawing.Color.White;
            this.comboBoxEixos.ColorI = System.Drawing.Color.White;
            this.comboBoxEixos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEixos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEixos.DropDownHeight = 100;
            this.comboBoxEixos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEixos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEixos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxEixos.ForeColor = System.Drawing.Color.White;
            this.comboBoxEixos.FormattingEnabled = true;
            this.comboBoxEixos.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxEixos.IntegralHeight = false;
            this.comboBoxEixos.ItemHeight = 20;
            this.comboBoxEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxEixos.Location = new System.Drawing.Point(526, 130);
            this.comboBoxEixos.Name = "comboBoxEixos";
            this.comboBoxEixos.Size = new System.Drawing.Size(138, 26);
            this.comboBoxEixos.StartIndex = 0;
            this.comboBoxEixos.TabIndex = 102;
            // 
            // comboBoxCaixa
            // 
            this.comboBoxCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(173)))));
            this.comboBoxCaixa.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCaixa.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCaixa.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCaixa.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCaixa.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.comboBoxCaixa.ColorF = System.Drawing.Color.White;
            this.comboBoxCaixa.ColorG = System.Drawing.Color.White;
            this.comboBoxCaixa.ColorH = System.Drawing.Color.White;
            this.comboBoxCaixa.ColorI = System.Drawing.Color.White;
            this.comboBoxCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCaixa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCaixa.DropDownHeight = 100;
            this.comboBoxCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCaixa.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.comboBoxCaixa.ForeColor = System.Drawing.Color.White;
            this.comboBoxCaixa.FormattingEnabled = true;
            this.comboBoxCaixa.HoverSelectionColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCaixa.IntegralHeight = false;
            this.comboBoxCaixa.ItemHeight = 20;
            this.comboBoxCaixa.Items.AddRange(new object[] {
            "manual",
            "automatica"});
            this.comboBoxCaixa.Location = new System.Drawing.Point(526, 158);
            this.comboBoxCaixa.Name = "comboBoxCaixa";
            this.comboBoxCaixa.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCaixa.StartIndex = 0;
            this.comboBoxCaixa.TabIndex = 103;
            // 
            // MenuAdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCaixa);
            this.Controls.Add(this.comboBoxEixos);
            this.Controls.Add(this.comboBoxNumPortas);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.numericPesoMax);
            this.Controls.Add(this.numericNumPassageiros);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.numericPrecoDia);
            this.Controls.Add(this.labelEscolheTipo);
            this.Controls.Add(this.comboBoxEscolherVeiculo);
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
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEscolheTipo;
        private ReaLTaiizor.Controls.ForeverComboBox comboBoxEscolherVeiculo;
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
        private ReaLTaiizor.Controls.CrownNumeric numericPrecoDia;
        private ReaLTaiizor.Controls.CrownNumeric numericAno;
        private ReaLTaiizor.Controls.CrownNumeric numericNumPassageiros;
        private ReaLTaiizor.Controls.CrownNumeric numericPesoMax;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Button buttonAdicionarVeiculo;
        private ReaLTaiizor.Controls.Button buttonCancelar;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCombustivel;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCilindrada;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxNumPortas;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxEixos;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCaixa;
    }
}