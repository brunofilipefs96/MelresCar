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
            this.boxMatricula = new ReaLTaiizor.Controls.CrownTextBox();
            this.matricula = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.buttonCancelar = new ReaLTaiizor.Controls.CrownButton();
            this.buttonEditarVeiculo = new ReaLTaiizor.Controls.CrownButton();
            this.labelEscolheTipo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.groupBoxEditarVeiculo = new System.Windows.Forms.GroupBox();
            this.boxPassageiros = new ReaLTaiizor.Controls.CrownTextBox();
            this.boxEixos = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxNPortas = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCaixa = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCilindrada = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxCombustivel = new ReaLTaiizor.Controls.CrownComboBox();
            this.boxEstado = new ReaLTaiizor.Controls.CrownComboBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelClasse = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.boxClasse = new ReaLTaiizor.Controls.CrownComboBox();
            this.textBoxPesoMax = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxModelo = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelPesoMax = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMarca = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelModelo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelNeixos = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxMarca = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxMatricula = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelNportas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelMatricula = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCaixa = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCombustivel = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelCilindrada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelAno = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.labelNpassageiros = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.textBoxAno = new ReaLTaiizor.Controls.CrownTextBox();
            this.textBoxPrecoDiario = new ReaLTaiizor.Controls.CrownTextBox();
            this.labelPrecoDiario = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.comboBoxEscolherVeiculo = new ReaLTaiizor.Controls.ForeverComboBox();
            this.buttonProcurar = new ReaLTaiizor.Controls.CrownButton();
            this.groupBoxEditarVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxMatricula
            // 
            this.boxMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.boxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.boxMatricula.Location = new System.Drawing.Point(572, 16);
            this.boxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.boxMatricula.Name = "boxMatricula";
            this.boxMatricula.Size = new System.Drawing.Size(243, 22);
            this.boxMatricula.TabIndex = 34;
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.BackColor = System.Drawing.Color.Transparent;
            this.matricula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.matricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.matricula.Location = new System.Drawing.Point(459, 17);
            this.matricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(101, 25);
            this.matricula.TabIndex = 33;
            this.matricula.Text = "Matricula:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(145, 465);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCancelar.Size = new System.Drawing.Size(156, 64);
            this.buttonCancelar.TabIndex = 52;
            this.buttonCancelar.Text = "Cancelar";
            // 
            // buttonEditarVeiculo
            // 
            this.buttonEditarVeiculo.Location = new System.Drawing.Point(847, 465);
            this.buttonEditarVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarVeiculo.Name = "buttonEditarVeiculo";
            this.buttonEditarVeiculo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonEditarVeiculo.Size = new System.Drawing.Size(156, 64);
            this.buttonEditarVeiculo.TabIndex = 51;
            this.buttonEditarVeiculo.Text = "Editar";
            this.buttonEditarVeiculo.Click += new System.EventHandler(this.buttonEditarVeiculo_Click);
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
            this.labelEscolheTipo.TabIndex = 50;
            this.labelEscolheTipo.Text = "Tipo de Veiculo:";
            // 
            // groupBoxEditarVeiculo
            // 
            this.groupBoxEditarVeiculo.Controls.Add(this.boxPassageiros);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxEixos);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxNPortas);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxCaixa);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxCilindrada);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxCombustivel);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxEstado);
            this.groupBoxEditarVeiculo.Controls.Add(this.dungeonHeaderLabel1);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelClasse);
            this.groupBoxEditarVeiculo.Controls.Add(this.boxClasse);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxPesoMax);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxModelo);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelPesoMax);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelMarca);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelModelo);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelNeixos);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxMarca);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxMatricula);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelNportas);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelMatricula);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelCaixa);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelCombustivel);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelCilindrada);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelAno);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelNpassageiros);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxAno);
            this.groupBoxEditarVeiculo.Controls.Add(this.textBoxPrecoDiario);
            this.groupBoxEditarVeiculo.Controls.Add(this.labelPrecoDiario);
            this.groupBoxEditarVeiculo.Location = new System.Drawing.Point(145, 75);
            this.groupBoxEditarVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEditarVeiculo.Name = "groupBoxEditarVeiculo";
            this.groupBoxEditarVeiculo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEditarVeiculo.Size = new System.Drawing.Size(857, 377);
            this.groupBoxEditarVeiculo.TabIndex = 49;
            this.groupBoxEditarVeiculo.TabStop = false;
            this.groupBoxEditarVeiculo.Text = "Editar Veiculo";
            // 
            // boxPassageiros
            // 
            this.boxPassageiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.boxPassageiros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPassageiros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.boxPassageiros.Location = new System.Drawing.Point(612, 212);
            this.boxPassageiros.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxEixos.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxNPortas.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxCaixa.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxCilindrada.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxCombustivel.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxEstado.Margin = new System.Windows.Forms.Padding(4);
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
            this.boxClasse.Margin = new System.Windows.Forms.Padding(4);
            this.boxClasse.Name = "boxClasse";
            this.boxClasse.Size = new System.Drawing.Size(216, 23);
            this.boxClasse.TabIndex = 48;
            // 
            // textBoxPesoMax
            // 
            this.textBoxPesoMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPesoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesoMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPesoMax.Location = new System.Drawing.Point(612, 241);
            this.textBoxPesoMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPesoMax.Name = "textBoxPesoMax";
            this.textBoxPesoMax.Size = new System.Drawing.Size(217, 22);
            this.textBoxPesoMax.TabIndex = 26;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxModelo.Location = new System.Drawing.Point(145, 112);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(217, 22);
            this.textBoxModelo.TabIndex = 5;
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
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMarca.Location = new System.Drawing.Point(145, 80);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(217, 22);
            this.textBoxMarca.TabIndex = 6;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxMatricula.Location = new System.Drawing.Point(145, 144);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(217, 22);
            this.textBoxMatricula.TabIndex = 7;
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
            // textBoxAno
            // 
            this.textBoxAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxAno.Location = new System.Drawing.Point(145, 208);
            this.textBoxAno.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAno.MaxLength = 4;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(217, 22);
            this.textBoxAno.TabIndex = 12;
            // 
            // textBoxPrecoDiario
            // 
            this.textBoxPrecoDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPrecoDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecoDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPrecoDiario.Location = new System.Drawing.Point(145, 245);
            this.textBoxPrecoDiario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoDiario.Name = "textBoxPrecoDiario";
            this.textBoxPrecoDiario.Size = new System.Drawing.Size(217, 22);
            this.textBoxPrecoDiario.TabIndex = 13;
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
            // comboBoxEscolherVeiculo
            // 
            this.comboBoxEscolherVeiculo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.comboBoxEscolherVeiculo.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.comboBoxEscolherVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEscolherVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEscolherVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEscolherVeiculo.Enabled = false;
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
            this.comboBoxEscolherVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEscolherVeiculo.Name = "comboBoxEscolherVeiculo";
            this.comboBoxEscolherVeiculo.Size = new System.Drawing.Size(229, 24);
            this.comboBoxEscolherVeiculo.TabIndex = 48;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Location = new System.Drawing.Point(903, 17);
            this.buttonProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonProcurar.Size = new System.Drawing.Size(100, 28);
            this.buttonProcurar.TabIndex = 53;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // MenuEditarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditarVeiculo);
            this.Controls.Add(this.labelEscolheTipo);
            this.Controls.Add(this.groupBoxEditarVeiculo);
            this.Controls.Add(this.comboBoxEscolherVeiculo);
            this.Controls.Add(this.boxMatricula);
            this.Controls.Add(this.matricula);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuEditarVeiculo";
            this.Text = "MenuEditarVeiculo";
            this.groupBoxEditarVeiculo.ResumeLayout(false);
            this.groupBoxEditarVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.CrownTextBox boxMatricula;
        private ReaLTaiizor.Controls.DungeonHeaderLabel matricula;
        private ReaLTaiizor.Controls.CrownButton buttonCancelar;
        private ReaLTaiizor.Controls.CrownButton buttonEditarVeiculo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelEscolheTipo;
        private System.Windows.Forms.GroupBox groupBoxEditarVeiculo;
        private ReaLTaiizor.Controls.CrownTextBox boxPassageiros;
        private ReaLTaiizor.Controls.CrownComboBox boxEixos;
        private ReaLTaiizor.Controls.CrownComboBox boxNPortas;
        private ReaLTaiizor.Controls.CrownComboBox boxCaixa;
        private ReaLTaiizor.Controls.CrownComboBox boxCilindrada;
        private ReaLTaiizor.Controls.CrownComboBox boxCombustivel;
        private ReaLTaiizor.Controls.CrownComboBox boxEstado;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelClasse;
        private ReaLTaiizor.Controls.CrownComboBox boxClasse;
        private ReaLTaiizor.Controls.CrownTextBox textBoxPesoMax;
        private ReaLTaiizor.Controls.CrownTextBox textBoxModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPesoMax;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMarca;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelModelo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNeixos;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMarca;
        private ReaLTaiizor.Controls.CrownTextBox textBoxMatricula;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNportas;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelMatricula;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCaixa;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCombustivel;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCilindrada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelAno;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelNpassageiros;
        private ReaLTaiizor.Controls.CrownTextBox textBoxAno;
        private ReaLTaiizor.Controls.CrownTextBox textBoxPrecoDiario;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelPrecoDiario;
        private ReaLTaiizor.Controls.ForeverComboBox comboBoxEscolherVeiculo;
        private ReaLTaiizor.Controls.CrownButton buttonProcurar;
    }
}