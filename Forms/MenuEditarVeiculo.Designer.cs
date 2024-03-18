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
            this.numericPesoMax = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericNumPassageiros = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericAno = new ReaLTaiizor.Controls.CrownNumeric();
            this.numericPrecoDia = new ReaLTaiizor.Controls.CrownNumeric();
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
            this.labelEditarCliente = new ReaLTaiizor.Controls.BigLabel();
            this.labelVeiculo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.buttonCancelar = new ReaLTaiizor.Controls.Button();
            this.buttonEditarVeiculo = new ReaLTaiizor.Controls.Button();
            this.comboBoxCombustivel = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxEixos = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxNumPortas = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxCilindrada = new ReaLTaiizor.Controls.DungeonComboBox();
            this.comboBoxCaixa = new ReaLTaiizor.Controls.DungeonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPesoMax
            // 
            this.numericPesoMax.DecimalPlaces = 2;
            this.numericPesoMax.Location = new System.Drawing.Point(544, 123);
            this.numericPesoMax.Maximum = new decimal(new int[] {
            24000,
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
            this.numericAno.Location = new System.Drawing.Point(194, 213);
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
            this.numericPrecoDia.Location = new System.Drawing.Point(193, 238);
            this.numericPrecoDia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPrecoDia.Name = "numericPrecoDia";
            this.numericPrecoDia.Size = new System.Drawing.Size(73, 20);
            this.numericPrecoDia.TabIndex = 94;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxModelo.Location = new System.Drawing.Point(193, 154);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(129, 20);
            this.textBoxModelo.TabIndex = 91;
            // 
            // labelPesoMax
            // 
            this.labelPesoMax.AutoSize = true;
            this.labelPesoMax.BackColor = System.Drawing.Color.Transparent;
            this.labelPesoMax.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelPesoMax.Location = new System.Drawing.Point(451, 123);
            this.labelPesoMax.Name = "labelPesoMax";
            this.labelPesoMax.Size = new System.Drawing.Size(84, 21);
            this.labelPesoMax.TabIndex = 107;
            this.labelPesoMax.Text = "Peso/Max:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelMarca.Location = new System.Drawing.Point(128, 128);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(61, 21);
            this.labelMarca.TabIndex = 97;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.BackColor = System.Drawing.Color.Transparent;
            this.labelModelo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelModelo.Location = new System.Drawing.Point(122, 149);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(64, 21);
            this.labelModelo.TabIndex = 98;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelEixos
            // 
            this.labelEixos.AutoSize = true;
            this.labelEixos.BackColor = System.Drawing.Color.Transparent;
            this.labelEixos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelEixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelEixos.Location = new System.Drawing.Point(462, 126);
            this.labelEixos.Name = "labelEixos";
            this.labelEixos.Size = new System.Drawing.Size(69, 21);
            this.labelEixos.TabIndex = 106;
            this.labelEixos.Text = "Nº Eixos:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMarca.Location = new System.Drawing.Point(193, 128);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(129, 20);
            this.textBoxMarca.TabIndex = 90;
            // 
            // labelNumPortas
            // 
            this.labelNumPortas.AutoSize = true;
            this.labelNumPortas.BackColor = System.Drawing.Color.Transparent;
            this.labelNumPortas.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelNumPortas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelNumPortas.Location = new System.Drawing.Point(456, 127);
            this.labelNumPortas.Name = "labelNumPortas";
            this.labelNumPortas.Size = new System.Drawing.Size(78, 21);
            this.labelNumPortas.TabIndex = 105;
            this.labelNumPortas.Text = "Nº Portas:";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.BackColor = System.Drawing.Color.Transparent;
            this.labelCaixa.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelCaixa.Location = new System.Drawing.Point(485, 154);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(52, 21);
            this.labelCaixa.TabIndex = 104;
            this.labelCaixa.Text = "Caixa:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.labelCombustivel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelCombustivel.Location = new System.Drawing.Point(88, 178);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(98, 21);
            this.labelCombustivel.TabIndex = 99;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.BackColor = System.Drawing.Color.Transparent;
            this.labelCilindrada.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelCilindrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelCilindrada.Location = new System.Drawing.Point(455, 128);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(85, 21);
            this.labelCilindrada.TabIndex = 103;
            this.labelCilindrada.Text = "Cilindrada:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.Color.Transparent;
            this.labelAno.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelAno.Location = new System.Drawing.Point(145, 212);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(41, 21);
            this.labelAno.TabIndex = 100;
            this.labelAno.Text = "Ano:";
            // 
            // labelPassageiros
            // 
            this.labelPassageiros.AutoSize = true;
            this.labelPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.labelPassageiros.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelPassageiros.Location = new System.Drawing.Point(420, 152);
            this.labelPassageiros.Name = "labelPassageiros";
            this.labelPassageiros.Size = new System.Drawing.Size(116, 21);
            this.labelPassageiros.TabIndex = 102;
            this.labelPassageiros.Text = "Nº Passageiros:";
            // 
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(103, 238);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(83, 21);
            this.labelPrecoDiario.TabIndex = 101;
            this.labelPrecoDiario.Text = "Preço/Dia:";
            // 
            // labelEditarCliente
            // 
            this.labelEditarCliente.AutoSize = true;
            this.labelEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelEditarCliente.Font = new System.Drawing.Font("Stencil", 25F);
            this.labelEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelEditarCliente.Location = new System.Drawing.Point(12, 9);
            this.labelEditarCliente.Name = "labelEditarCliente";
            this.labelEditarCliente.Size = new System.Drawing.Size(283, 40);
            this.labelEditarCliente.TabIndex = 116;
            this.labelEditarCliente.Text = "Editar Veículo";
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelVeiculo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.labelVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.labelVeiculo.Location = new System.Drawing.Point(63, 71);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(67, 21);
            this.labelVeiculo.TabIndex = 117;
            this.labelVeiculo.Text = "Veículo: ";
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
            this.buttonCancelar.Location = new System.Drawing.Point(536, 386);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonCancelar.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelar.TabIndex = 118;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // buttonEditarVeiculo
            // 
            this.buttonEditarVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditarVeiculo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarVeiculo.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarVeiculo.Image = null;
            this.buttonEditarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarVeiculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.Location = new System.Drawing.Point(662, 386);
            this.buttonEditarVeiculo.Name = "buttonEditarVeiculo";
            this.buttonEditarVeiculo.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.buttonEditarVeiculo.Size = new System.Drawing.Size(120, 40);
            this.buttonEditarVeiculo.TabIndex = 119;
            this.buttonEditarVeiculo.Text = "Editar";
            this.buttonEditarVeiculo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonEditarVeiculo.Click += new System.EventHandler(this.buttonEditarVeiculo_Click_1);
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
            "gasoleo",
            "hibrido",
            "eletrico"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(194, 178);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCombustivel.StartIndex = 0;
            this.comboBoxCombustivel.TabIndex = 121;
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
            this.comboBoxEixos.Location = new System.Drawing.Point(536, 121);
            this.comboBoxEixos.Name = "comboBoxEixos";
            this.comboBoxEixos.Size = new System.Drawing.Size(138, 26);
            this.comboBoxEixos.StartIndex = 0;
            this.comboBoxEixos.TabIndex = 122;
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
            this.comboBoxNumPortas.Location = new System.Drawing.Point(536, 121);
            this.comboBoxNumPortas.Name = "comboBoxNumPortas";
            this.comboBoxNumPortas.Size = new System.Drawing.Size(138, 26);
            this.comboBoxNumPortas.StartIndex = 0;
            this.comboBoxNumPortas.TabIndex = 123;
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
            this.comboBoxCilindrada.Location = new System.Drawing.Point(536, 121);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCilindrada.StartIndex = 0;
            this.comboBoxCilindrada.TabIndex = 124;
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
            this.comboBoxCaixa.Location = new System.Drawing.Point(536, 151);
            this.comboBoxCaixa.Name = "comboBoxCaixa";
            this.comboBoxCaixa.Size = new System.Drawing.Size(138, 26);
            this.comboBoxCaixa.StartIndex = 0;
            this.comboBoxCaixa.TabIndex = 125;
            // 
            // MenuEditarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCaixa);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.comboBoxNumPortas);
            this.Controls.Add(this.comboBoxEixos);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.buttonEditarVeiculo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelVeiculo);
            this.Controls.Add(this.labelEditarCliente);
            this.Controls.Add(this.numericPesoMax);
            this.Controls.Add(this.numericNumPassageiros);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.numericPrecoDia);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuEditarVeiculo";
            this.Text = "MenuEditarVeiculo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEditarVeiculo);
            ((System.ComponentModel.ISupportInitialize)(this.numericPesoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPassageiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.CrownNumeric numericPesoMax;
        private ReaLTaiizor.Controls.CrownNumeric numericNumPassageiros;
        private ReaLTaiizor.Controls.CrownNumeric numericAno;
        private ReaLTaiizor.Controls.CrownNumeric numericPrecoDia;
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
        private ReaLTaiizor.Controls.BigLabel labelEditarCliente;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelVeiculo;
        private ReaLTaiizor.Controls.Button buttonCancelar;
        private ReaLTaiizor.Controls.Button buttonEditarVeiculo;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCombustivel;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxEixos;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxNumPortas;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCilindrada;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCaixa;
    }
}