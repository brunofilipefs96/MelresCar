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
            this.labelPrecoDiario = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxPrecoDiario = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxAno = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelNpassageiros = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelAno = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCilindrada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCombustivel = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCaixa = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMatricula = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelNportas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxMatricula = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxMarca = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelNeixos = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelModelo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMarca = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelPesoMax = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxModelo = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxPesoMax = new ReaLTaiizor.Controls.CrownTextBox();
            this.boxClasse = new ReaLTaiizor.Controls.CrownComboBox();
            this.labelClasse = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label = new System.Windows.Forms.GroupBox();
            this.boxPassageiros = new ReaLTaiizor.Controls.CrownTextBox();
            this.boxEixos = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxNPortas = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCaixa = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCilindrada = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCombustivel = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxEstado = new ReaLTaiizor.Controls.CrownComboBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.label.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(117, 457);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancelar.Size = new System.Drawing.Size(156, 64);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "Cancelar";
            // 
            // buttonAdicionarVeiculo
            // 
            this.buttonAdicionarVeiculo.Location = new System.Drawing.Point(819, 457);
            this.buttonAdicionarVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdicionarVeiculo.Name = "buttonAdicionarVeiculo";
            this.buttonAdicionarVeiculo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonAdicionarVeiculo.Size = new System.Drawing.Size(156, 64);
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
            this.labelEscolheTipo.Location = new System.Drawing.Point(37, 16);
            this.labelEscolheTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEscolheTipo.Name = "labelEscolheTipo";
            this.labelEscolheTipo.Size = new System.Drawing.Size(154, 25);
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
            this.comboBoxEscolherVeiculo.Location = new System.Drawing.Point(204, 16);
            this.comboBoxEscolherVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEscolherVeiculo.Name = "comboBoxEscolherVeiculo";
            this.comboBoxEscolherVeiculo.Size = new System.Drawing.Size(229, 24);
            this.comboBoxEscolherVeiculo.TabIndex = 42;
            this.comboBoxEscolherVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboBoxEscolherVeiculo_SelectedIndexChanged);
            // 
            // labelPrecoDiario
            // 
            this.labelPrecoDiario.AutoSize = true;
            this.labelPrecoDiario.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecoDiario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPrecoDiario.Location = new System.Drawing.Point(28, 241);
            this.labelPrecoDiario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecoDiario.Name = "labelPrecoDiario";
            this.labelPrecoDiario.Size = new System.Drawing.Size(105, 25);
            this.labelPrecoDiario.TabIndex = 14;
            this.labelPrecoDiario.Text = "Preço/Dia:";
            // 
            // textBoxPrecoDiario
            // 
            this.textBoxPrecoDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPrecoDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPrecoDiario.Location = new System.Drawing.Point(145, 245);
            this.textBoxPrecoDiario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrecoDiario.Name = "textBoxPrecoDiario";
            this.textBoxPrecoDiario.Size = new System.Drawing.Size(217, 22);
            this.textBoxPrecoDiario.TabIndex = 13;
            // 
            // textBoxAno
            // 
            this.textBoxAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxAno.Location = new System.Drawing.Point(145, 208);
            this.textBoxAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAno.MaxLength = 4;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(217, 22);
            this.textBoxAno.TabIndex = 12;
            // 
            // labelNpassageiros
            // 
            this.labelNpassageiros.AutoSize = true;
            this.labelNpassageiros.BackColor = System.Drawing.Color.Transparent;
            this.labelNpassageiros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNpassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNpassageiros.Location = new System.Drawing.Point(448, 208);
            this.labelNpassageiros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNpassageiros.Name = "labelNpassageiros";
            this.labelNpassageiros.Size = new System.Drawing.Size(149, 25);
            this.labelNpassageiros.TabIndex = 16;
            this.labelNpassageiros.Text = "Nº Passageiros:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.BackColor = System.Drawing.Color.Transparent;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelAno.Location = new System.Drawing.Point(81, 208);
            this.labelAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(54, 25);
            this.labelAno.TabIndex = 11;
            this.labelAno.Text = "Ano:";
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.BackColor = System.Drawing.Color.Transparent;
            this.labelCilindrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCilindrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCilindrada.Location = new System.Drawing.Point(495, 80);
            this.labelCilindrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(108, 25);
            this.labelCilindrada.TabIndex = 17;
            this.labelCilindrada.Text = "Cilindrada:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.labelCombustivel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCombustivel.Location = new System.Drawing.Point(9, 176);
            this.labelCombustivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(127, 25);
            this.labelCombustivel.TabIndex = 10;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelCaixa
            // 
            this.labelCaixa.AutoSize = true;
            this.labelCaixa.BackColor = System.Drawing.Color.Transparent;
            this.labelCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelCaixa.Location = new System.Drawing.Point(535, 112);
            this.labelCaixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaixa.Name = "labelCaixa";
            this.labelCaixa.Size = new System.Drawing.Size(65, 25);
            this.labelCaixa.TabIndex = 19;
            this.labelCaixa.Text = "Caixa:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.BackColor = System.Drawing.Color.Transparent;
            this.labelMatricula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelMatricula.Location = new System.Drawing.Point(37, 144);
            this.labelMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(101, 25);
            this.labelMatricula.TabIndex = 8;
            this.labelMatricula.Text = "Matricula:";
            // 
            // labelNportas
            // 
            this.labelNportas.AutoSize = true;
            this.labelNportas.BackColor = System.Drawing.Color.Transparent;
            this.labelNportas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNportas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNportas.Location = new System.Drawing.Point(496, 144);
            this.labelNportas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNportas.Name = "labelNportas";
            this.labelNportas.Size = new System.Drawing.Size(103, 25);
            this.labelNportas.TabIndex = 21;
            this.labelNportas.Text = "Nº Portas:";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMatricula.Location = new System.Drawing.Point(145, 144);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(217, 22);
            this.textBoxMatricula.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMarca.Location = new System.Drawing.Point(145, 80);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(217, 22);
            this.textBoxMarca.TabIndex = 6;
            // 
            // labelNeixos
            // 
            this.labelNeixos.AutoSize = true;
            this.labelNeixos.BackColor = System.Drawing.Color.Transparent;
            this.labelNeixos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelNeixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelNeixos.Location = new System.Drawing.Point(504, 176);
            this.labelNeixos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeixos.Name = "labelNeixos";
            this.labelNeixos.Size = new System.Drawing.Size(92, 25);
            this.labelNeixos.TabIndex = 23;
            this.labelNeixos.Text = "Nº Eixos:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.BackColor = System.Drawing.Color.Transparent;
            this.labelModelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelModelo.Location = new System.Drawing.Point(55, 112);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(86, 25);
            this.labelModelo.TabIndex = 4;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelMarca.Location = new System.Drawing.Point(63, 80);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(77, 25);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelPesoMax
            // 
            this.labelPesoMax.AutoSize = true;
            this.labelPesoMax.BackColor = System.Drawing.Color.Transparent;
            this.labelPesoMax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelPesoMax.Location = new System.Drawing.Point(489, 238);
            this.labelPesoMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPesoMax.Name = "labelPesoMax";
            this.labelPesoMax.Size = new System.Drawing.Size(105, 25);
            this.labelPesoMax.TabIndex = 25;
            this.labelPesoMax.Text = "Peso/Max:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxModelo.Location = new System.Drawing.Point(145, 112);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(217, 22);
            this.textBoxModelo.TabIndex = 5;
            // 
            // textBoxPesoMax
            // 
            this.textBoxPesoMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPesoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPesoMax.Location = new System.Drawing.Point(612, 241);
            this.textBoxPesoMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPesoMax.Name = "textBoxPesoMax";
            this.textBoxPesoMax.Size = new System.Drawing.Size(217, 22);
            this.textBoxPesoMax.TabIndex = 26;
            // 
            // boxClasse
            // 
            this.boxClasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxClasse.FormattingEnabled = true;
            this.boxClasse.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.boxClasse.Location = new System.Drawing.Point(145, 277);
            this.boxClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxClasse.Name = "boxClasse";
            this.boxClasse.Size = new System.Drawing.Size(216, 23);
            this.boxClasse.TabIndex = 48;
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.BackColor = System.Drawing.Color.Transparent;
            this.labelClasse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelClasse.Location = new System.Drawing.Point(55, 278);
            this.labelClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(70, 25);
            this.labelClasse.TabIndex = 49;
            this.labelClasse.Text = "Classe:";
            // 
            // label
            // 
            this.label.Controls.Add(this.boxPassageiros);
            this.label.Controls.Add(this.boxEixos);
            this.label.Controls.Add(this.boxNPortas);
            this.label.Controls.Add(this.boxCaixa);
            this.label.Controls.Add(this.boxCilindrada);
            this.label.Controls.Add(this.boxCombustivel);
            this.label.Controls.Add(this.boxEstado);
            this.label.Controls.Add(this.dungeonHeaderLabel1);
            this.label.Controls.Add(this.labelClasse);
            this.label.Controls.Add(this.boxClasse);
            this.label.Controls.Add(this.textBoxPesoMax);
            this.label.Controls.Add(this.textBoxModelo);
            this.label.Controls.Add(this.labelPesoMax);
            this.label.Controls.Add(this.labelMarca);
            this.label.Controls.Add(this.labelModelo);
            this.label.Controls.Add(this.labelNeixos);
            this.label.Controls.Add(this.textBoxMarca);
            this.label.Controls.Add(this.textBoxMatricula);
            this.label.Controls.Add(this.labelNportas);
            this.label.Controls.Add(this.labelMatricula);
            this.label.Controls.Add(this.labelCaixa);
            this.label.Controls.Add(this.labelCombustivel);
            this.label.Controls.Add(this.labelCilindrada);
            this.label.Controls.Add(this.labelAno);
            this.label.Controls.Add(this.labelNpassageiros);
            this.label.Controls.Add(this.textBoxAno);
            this.label.Controls.Add(this.textBoxPrecoDiario);
            this.label.Controls.Add(this.labelPrecoDiario);
            this.label.Location = new System.Drawing.Point(117, 66);
            this.label.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label.Size = new System.Drawing.Size(857, 377);
            this.label.TabIndex = 43;
            this.label.TabStop = false;
            this.label.Text = "Adicionar Veiculo";
            // 
            // boxPassageiros
            // 
            this.boxPassageiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.boxPassageiros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.boxPassageiros.Location = new System.Drawing.Point(612, 212);
            this.boxPassageiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxPassageiros.Name = "boxPassageiros";
            this.boxPassageiros.Size = new System.Drawing.Size(217, 22);
            this.boxPassageiros.TabIndex = 57;
            // 
            // boxEixos
            // 
            this.boxEixos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxEixos.FormattingEnabled = true;
            this.boxEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.boxEixos.Location = new System.Drawing.Point(612, 176);
            this.boxEixos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxEixos.Name = "boxEixos";
            this.boxEixos.Size = new System.Drawing.Size(216, 23);
            this.boxEixos.TabIndex = 56;
            // 
            // boxNPortas
            // 
            this.boxNPortas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxNPortas.FormattingEnabled = true;
            this.boxNPortas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.boxNPortas.Location = new System.Drawing.Point(612, 144);
            this.boxNPortas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxNPortas.Name = "boxNPortas";
            this.boxNPortas.Size = new System.Drawing.Size(216, 23);
            this.boxNPortas.TabIndex = 55;
            // 
            // boxCaixa
            // 
            this.boxCaixa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxCaixa.FormattingEnabled = true;
            this.boxCaixa.Items.AddRange(new object[] {
            "manual",
            "automatica"});
            this.boxCaixa.Location = new System.Drawing.Point(612, 112);
            this.boxCaixa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCaixa.Name = "boxCaixa";
            this.boxCaixa.Size = new System.Drawing.Size(216, 23);
            this.boxCaixa.TabIndex = 54;
            // 
            // boxCilindrada
            // 
            this.boxCilindrada.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxCilindrada.FormattingEnabled = true;
            this.boxCilindrada.Items.AddRange(new object[] {
            "50",
            "125",
            "300"});
            this.boxCilindrada.Location = new System.Drawing.Point(612, 79);
            this.boxCilindrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCilindrada.Name = "boxCilindrada";
            this.boxCilindrada.Size = new System.Drawing.Size(216, 23);
            this.boxCilindrada.TabIndex = 53;
            // 
            // boxCombustivel
            // 
            this.boxCombustivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxCombustivel.FormattingEnabled = true;
            this.boxCombustivel.Items.AddRange(new object[] {
            "gasolina",
            "diesel",
            "hibrido",
            "eletrico"});
            this.boxCombustivel.Location = new System.Drawing.Point(145, 175);
            this.boxCombustivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCombustivel.Name = "boxCombustivel";
            this.boxCombustivel.Size = new System.Drawing.Size(216, 23);
            this.boxCombustivel.TabIndex = 52;
            // 
            // boxEstado
            // 
            this.boxEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Items.AddRange(new object[] {
            "disponivel",
            "manutencao",
            "reservado",
            "alugado"});
            this.boxEstado.Location = new System.Drawing.Point(145, 310);
            this.boxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(216, 23);
            this.boxEstado.TabIndex = 51;
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(57, 310);
            this.dungeonHeaderLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(76, 25);
            this.dungeonHeaderLabel1.TabIndex = 50;
            this.dungeonHeaderLabel1.Text = "Estado:";
            // 
            // MenuAdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionarVeiculo);
            this.Controls.Add(this.labelEscolheTipo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxEscolherVeiculo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuAdicionarVeiculo";
            this.Text = "MenuAdicionarVeiculo";
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonAdicionarVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEscolheTipo;
        private ReaLTaiizor.Controls.ForeverComboBox comboBoxEscolherVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPrecoDiario;
        private ReaLTaiizor.Controls.CrownTextBox textBoxPrecoDiario;
        private ReaLTaiizor.Controls.CrownTextBox textBoxAno;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNpassageiros;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelAno;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCilindrada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCombustivel;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCaixa;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMatricula;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNportas;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMatricula;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNeixos;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPesoMax;
        private ReaLTaiizor.Controls.CrownTextBox textBoxModelo;
        private ReaLTaiizor.Controls.CrownTextBox textBoxPesoMax;
        private ReaLTaiizor.Controls.CrownComboBox boxClasse;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelClasse;
        private System.Windows.Forms.GroupBox label;
        private ReaLTaiizor.Controls.CrownComboBox boxEstado;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.CrownComboBox boxCombustivel;
        private ReaLTaiizor.Controls.CrownComboBox boxNPortas;
        private ReaLTaiizor.Controls.CrownComboBox boxCaixa;
        private ReaLTaiizor.Controls.CrownComboBox boxCilindrada;
        private ReaLTaiizor.Controls.CrownComboBox boxEixos;
        private ReaLTaiizor.Controls.CrownTextBox boxPassageiros;
    }
}