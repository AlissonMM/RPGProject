namespace RPG_Project
{
    partial class FormRpg
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRpg));
            this.lblRPG = new System.Windows.Forms.Label();
            this.btnRolarD20 = new System.Windows.Forms.Button();
            this.lblResultadoD20 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNomePersonagem = new System.Windows.Forms.Label();
            this.txtboxNomePersonagem = new System.Windows.Forms.TextBox();
            this.btnCriarPersonagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudForca = new System.Windows.Forms.NumericUpDown();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cmbboxClasse = new System.Windows.Forms.ComboBox();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.nudDestreza = new System.Windows.Forms.NumericUpDown();
            this.lblConstituição = new System.Windows.Forms.Label();
            this.nudConstituicao = new System.Windows.Forms.NumericUpDown();
            this.btnSubirDeNivel = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblInteligencia = new System.Windows.Forms.Label();
            this.nudInteligencia = new System.Windows.Forms.NumericUpDown();
            this.lblSabedoria = new System.Windows.Forms.Label();
            this.nudSabedoria = new System.Windows.Forms.NumericUpDown();
            this.lblCarisma = new System.Windows.Forms.Label();
            this.nudCarisma = new System.Windows.Forms.NumericUpDown();
            this.lblRaca = new System.Windows.Forms.Label();
            this.cmbboxRaca = new System.Windows.Forms.ComboBox();
            this.btnCarregarPersonagem = new System.Windows.Forms.Button();
            this.btnExcluirPersonagem = new System.Windows.Forms.Button();
            this.lblModForça = new System.Windows.Forms.Label();
            this.lblModDestreza = new System.Windows.Forms.Label();
            this.lblModConstituicao = new System.Windows.Forms.Label();
            this.lblModInteligencia = new System.Windows.Forms.Label();
            this.lblModSabedoria = new System.Windows.Forms.Label();
            this.lblModCarisma = new System.Windows.Forms.Label();
            this.lblAvisoMod = new System.Windows.Forms.Label();
            this.lblPVTotal = new System.Windows.Forms.Label();
            this.nudPVTotal = new System.Windows.Forms.NumericUpDown();
            this.lblPVAtuais = new System.Windows.Forms.Label();
            this.nudPVAtuais = new System.Windows.Forms.NumericUpDown();
            this.rtxtBoxItens = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirItens = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.nudProficiencia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstituicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteligencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSabedoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPVTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPVAtuais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProficiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRPG
            // 
            this.lblRPG.AutoSize = true;
            this.lblRPG.BackColor = System.Drawing.Color.Transparent;
            this.lblRPG.Font = new System.Drawing.Font("Viner Hand ITC", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPG.Location = new System.Drawing.Point(134, 9);
            this.lblRPG.Name = "lblRPG";
            this.lblRPG.Size = new System.Drawing.Size(537, 86);
            this.lblRPG.TabIndex = 0;
            this.lblRPG.Text = "Ficha de Personagem";
            // 
            // btnRolarD20
            // 
            this.btnRolarD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarD20.Location = new System.Drawing.Point(729, 178);
            this.btnRolarD20.Name = "btnRolarD20";
            this.btnRolarD20.Size = new System.Drawing.Size(149, 31);
            this.btnRolarD20.TabIndex = 1;
            this.btnRolarD20.Text = "Rolar D20";
            this.btnRolarD20.UseVisualStyleBackColor = true;
            this.btnRolarD20.Click += new System.EventHandler(this.btnRolarD20_Click);
            // 
            // lblResultadoD20
            // 
            this.lblResultadoD20.AutoSize = true;
            this.lblResultadoD20.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoD20.Location = new System.Drawing.Point(772, 212);
            this.lblResultadoD20.Name = "lblResultadoD20";
            this.lblResultadoD20.Size = new System.Drawing.Size(68, 13);
            this.lblResultadoD20.TabIndex = 2;
            this.lblResultadoD20.Text = "Resultado:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(731, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 29);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNomePersonagem
            // 
            this.lblNomePersonagem.AutoSize = true;
            this.lblNomePersonagem.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePersonagem.Location = new System.Drawing.Point(0, 86);
            this.lblNomePersonagem.Name = "lblNomePersonagem";
            this.lblNomePersonagem.Size = new System.Drawing.Size(171, 16);
            this.lblNomePersonagem.TabIndex = 4;
            this.lblNomePersonagem.Text = "Nome do Personagem: ";
            // 
            // txtboxNomePersonagem
            // 
            this.txtboxNomePersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNomePersonagem.Location = new System.Drawing.Point(192, 83);
            this.txtboxNomePersonagem.Name = "txtboxNomePersonagem";
            this.txtboxNomePersonagem.Size = new System.Drawing.Size(234, 20);
            this.txtboxNomePersonagem.TabIndex = 5;
            this.txtboxNomePersonagem.TextChanged += new System.EventHandler(this.txtboxNomePersonagem_TextChanged);
            // 
            // btnCriarPersonagem
            // 
            this.btnCriarPersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPersonagem.Location = new System.Drawing.Point(729, 236);
            this.btnCriarPersonagem.Name = "btnCriarPersonagem";
            this.btnCriarPersonagem.Size = new System.Drawing.Size(152, 28);
            this.btnCriarPersonagem.TabIndex = 7;
            this.btnCriarPersonagem.Text = "Salvar Personagem";
            this.btnCriarPersonagem.UseVisualStyleBackColor = true;
            this.btnCriarPersonagem.Click += new System.EventHandler(this.btnCriarPersonagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Força: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudForca
            // 
            this.nudForca.Location = new System.Drawing.Point(192, 104);
            this.nudForca.Name = "nudForca";
            this.nudForca.Size = new System.Drawing.Size(44, 20);
            this.nudForca.TabIndex = 10;
            this.nudForca.ValueChanged += new System.EventHandler(this.nudForca_ValueChanged);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.BackColor = System.Drawing.Color.Transparent;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(681, 88);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(52, 13);
            this.lblClasse.TabIndex = 12;
            this.lblClasse.Text = "Classe: ";
            // 
            // cmbboxClasse
            // 
            this.cmbboxClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxClasse.FormattingEnabled = true;
            this.cmbboxClasse.Items.AddRange(new object[] {
            "Bárbaro",
            "Bardo",
            "Bruxo",
            "Guerreiro",
            "Ladino",
            "Paladino",
            "Mago",
            "Feiticeiro",
            "Druida",
            "Clérigo"});
            this.cmbboxClasse.Location = new System.Drawing.Point(749, 85);
            this.cmbboxClasse.Name = "cmbboxClasse";
            this.cmbboxClasse.Size = new System.Drawing.Size(101, 21);
            this.cmbboxClasse.TabIndex = 14;
            this.cmbboxClasse.SelectedIndexChanged += new System.EventHandler(this.cmbboxClasse_SelectedIndexChanged);
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.BackColor = System.Drawing.Color.Transparent;
            this.lblDestreza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestreza.Location = new System.Drawing.Point(40, 130);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(78, 16);
            this.lblDestreza.TabIndex = 16;
            this.lblDestreza.Text = "Destreza: ";
            // 
            // nudDestreza
            // 
            this.nudDestreza.Location = new System.Drawing.Point(192, 126);
            this.nudDestreza.Name = "nudDestreza";
            this.nudDestreza.Size = new System.Drawing.Size(44, 20);
            this.nudDestreza.TabIndex = 17;
            this.nudDestreza.ValueChanged += new System.EventHandler(this.nudDestreza_ValueChanged);
            // 
            // lblConstituição
            // 
            this.lblConstituição.AutoSize = true;
            this.lblConstituição.BackColor = System.Drawing.Color.Transparent;
            this.lblConstituição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstituição.Location = new System.Drawing.Point(21, 149);
            this.lblConstituição.Name = "lblConstituição";
            this.lblConstituição.Size = new System.Drawing.Size(101, 16);
            this.lblConstituição.TabIndex = 19;
            this.lblConstituição.Text = "Constituição: ";
            // 
            // nudConstituicao
            // 
            this.nudConstituicao.Location = new System.Drawing.Point(192, 149);
            this.nudConstituicao.Name = "nudConstituicao";
            this.nudConstituicao.Size = new System.Drawing.Size(44, 20);
            this.nudConstituicao.TabIndex = 20;
            this.nudConstituicao.ValueChanged += new System.EventHandler(this.nudConstituicao_ValueChanged);
            // 
            // btnSubirDeNivel
            // 
            this.btnSubirDeNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirDeNivel.Location = new System.Drawing.Point(731, 309);
            this.btnSubirDeNivel.Name = "btnSubirDeNivel";
            this.btnSubirDeNivel.Size = new System.Drawing.Size(149, 27);
            this.btnSubirDeNivel.TabIndex = 22;
            this.btnSubirDeNivel.Text = "Subir de Nível";
            this.btnSubirDeNivel.UseVisualStyleBackColor = true;
            this.btnSubirDeNivel.Click += new System.EventHandler(this.btnSubirDeNivel_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(762, 113);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(46, 13);
            this.lblNivel.TabIndex = 23;
            this.lblNivel.Text = "Nível: ";
            this.lblNivel.Click += new System.EventHandler(this.lblNivel_Click);
            // 
            // lblInteligencia
            // 
            this.lblInteligencia.AutoSize = true;
            this.lblInteligencia.BackColor = System.Drawing.Color.Transparent;
            this.lblInteligencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteligencia.Location = new System.Drawing.Point(26, 171);
            this.lblInteligencia.Name = "lblInteligencia";
            this.lblInteligencia.Size = new System.Drawing.Size(96, 16);
            this.lblInteligencia.TabIndex = 25;
            this.lblInteligencia.Text = "Inteligência: ";
            // 
            // nudInteligencia
            // 
            this.nudInteligencia.Location = new System.Drawing.Point(192, 171);
            this.nudInteligencia.Name = "nudInteligencia";
            this.nudInteligencia.Size = new System.Drawing.Size(44, 20);
            this.nudInteligencia.TabIndex = 26;
            this.nudInteligencia.ValueChanged += new System.EventHandler(this.nudInteligencia_ValueChanged);
            // 
            // lblSabedoria
            // 
            this.lblSabedoria.AutoSize = true;
            this.lblSabedoria.BackColor = System.Drawing.Color.Transparent;
            this.lblSabedoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabedoria.Location = new System.Drawing.Point(33, 192);
            this.lblSabedoria.Name = "lblSabedoria";
            this.lblSabedoria.Size = new System.Drawing.Size(89, 16);
            this.lblSabedoria.TabIndex = 28;
            this.lblSabedoria.Text = "Sabedoria: ";
            // 
            // nudSabedoria
            // 
            this.nudSabedoria.Location = new System.Drawing.Point(192, 192);
            this.nudSabedoria.Name = "nudSabedoria";
            this.nudSabedoria.Size = new System.Drawing.Size(44, 20);
            this.nudSabedoria.TabIndex = 29;
            this.nudSabedoria.ValueChanged += new System.EventHandler(this.nudSabedoria_ValueChanged);
            // 
            // lblCarisma
            // 
            this.lblCarisma.AutoSize = true;
            this.lblCarisma.BackColor = System.Drawing.Color.Transparent;
            this.lblCarisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarisma.Location = new System.Drawing.Point(40, 214);
            this.lblCarisma.Name = "lblCarisma";
            this.lblCarisma.Size = new System.Drawing.Size(73, 16);
            this.lblCarisma.TabIndex = 31;
            this.lblCarisma.Text = "Carisma: ";
            // 
            // nudCarisma
            // 
            this.nudCarisma.Location = new System.Drawing.Point(192, 214);
            this.nudCarisma.Name = "nudCarisma";
            this.nudCarisma.Size = new System.Drawing.Size(44, 20);
            this.nudCarisma.TabIndex = 32;
            this.nudCarisma.ValueChanged += new System.EventHandler(this.nudCarisma_ValueChanged);
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.BackColor = System.Drawing.Color.Transparent;
            this.lblRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(434, 86);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(45, 13);
            this.lblRaca.TabIndex = 33;
            this.lblRaca.Text = "Raça: ";
            // 
            // cmbboxRaca
            // 
            this.cmbboxRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxRaca.FormattingEnabled = true;
            this.cmbboxRaca.Items.AddRange(new object[] {
            "Anão da Colina",
            "Anão da Montanha",
            "Alto Elfo",
            "Elfo da Floresta",
            "Elfo Negro (Drow)",
            "Meio-Elfo",
            "Halfling Pés Leves",
            "Halfling Robusto",
            "Humano",
            "Humano Variante",
            "Draconato",
            "Gnomo da Floresta",
            "Gnomo das Rochas",
            "Meio-Orc",
            "Infernal"});
            this.cmbboxRaca.Location = new System.Drawing.Point(486, 83);
            this.cmbboxRaca.Name = "cmbboxRaca";
            this.cmbboxRaca.Size = new System.Drawing.Size(160, 21);
            this.cmbboxRaca.TabIndex = 34;
            // 
            // btnCarregarPersonagem
            // 
            this.btnCarregarPersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarPersonagem.Location = new System.Drawing.Point(731, 270);
            this.btnCarregarPersonagem.Name = "btnCarregarPersonagem";
            this.btnCarregarPersonagem.Size = new System.Drawing.Size(149, 33);
            this.btnCarregarPersonagem.TabIndex = 37;
            this.btnCarregarPersonagem.Text = "Carregar Personagem";
            this.btnCarregarPersonagem.UseVisualStyleBackColor = true;
            this.btnCarregarPersonagem.Click += new System.EventHandler(this.btnCarregarPersonagem_Click);
            // 
            // btnExcluirPersonagem
            // 
            this.btnExcluirPersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPersonagem.Location = new System.Drawing.Point(729, 342);
            this.btnExcluirPersonagem.Name = "btnExcluirPersonagem";
            this.btnExcluirPersonagem.Size = new System.Drawing.Size(149, 33);
            this.btnExcluirPersonagem.TabIndex = 38;
            this.btnExcluirPersonagem.Text = "Morte";
            this.btnExcluirPersonagem.UseVisualStyleBackColor = true;
            this.btnExcluirPersonagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblModForça
            // 
            this.lblModForça.AutoSize = true;
            this.lblModForça.BackColor = System.Drawing.Color.Transparent;
            this.lblModForça.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModForça.Location = new System.Drawing.Point(150, 106);
            this.lblModForça.Name = "lblModForça";
            this.lblModForça.Size = new System.Drawing.Size(0, 13);
            this.lblModForça.TabIndex = 39;
            // 
            // lblModDestreza
            // 
            this.lblModDestreza.AutoSize = true;
            this.lblModDestreza.BackColor = System.Drawing.Color.Transparent;
            this.lblModDestreza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModDestreza.Location = new System.Drawing.Point(150, 128);
            this.lblModDestreza.Name = "lblModDestreza";
            this.lblModDestreza.Size = new System.Drawing.Size(0, 13);
            this.lblModDestreza.TabIndex = 40;
            // 
            // lblModConstituicao
            // 
            this.lblModConstituicao.AutoSize = true;
            this.lblModConstituicao.BackColor = System.Drawing.Color.Transparent;
            this.lblModConstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModConstituicao.Location = new System.Drawing.Point(150, 151);
            this.lblModConstituicao.Name = "lblModConstituicao";
            this.lblModConstituicao.Size = new System.Drawing.Size(0, 13);
            this.lblModConstituicao.TabIndex = 41;
            // 
            // lblModInteligencia
            // 
            this.lblModInteligencia.AutoSize = true;
            this.lblModInteligencia.BackColor = System.Drawing.Color.Transparent;
            this.lblModInteligencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModInteligencia.Location = new System.Drawing.Point(150, 178);
            this.lblModInteligencia.Name = "lblModInteligencia";
            this.lblModInteligencia.Size = new System.Drawing.Size(0, 13);
            this.lblModInteligencia.TabIndex = 42;
            // 
            // lblModSabedoria
            // 
            this.lblModSabedoria.AutoSize = true;
            this.lblModSabedoria.BackColor = System.Drawing.Color.Transparent;
            this.lblModSabedoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModSabedoria.Location = new System.Drawing.Point(150, 201);
            this.lblModSabedoria.Name = "lblModSabedoria";
            this.lblModSabedoria.Size = new System.Drawing.Size(0, 13);
            this.lblModSabedoria.TabIndex = 43;
            // 
            // lblModCarisma
            // 
            this.lblModCarisma.AutoSize = true;
            this.lblModCarisma.BackColor = System.Drawing.Color.Transparent;
            this.lblModCarisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModCarisma.Location = new System.Drawing.Point(150, 223);
            this.lblModCarisma.Name = "lblModCarisma";
            this.lblModCarisma.Size = new System.Drawing.Size(0, 13);
            this.lblModCarisma.TabIndex = 44;
            // 
            // lblAvisoMod
            // 
            this.lblAvisoMod.AutoSize = true;
            this.lblAvisoMod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvisoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoMod.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAvisoMod.Location = new System.Drawing.Point(200, 426);
            this.lblAvisoMod.Name = "lblAvisoMod";
            this.lblAvisoMod.Size = new System.Drawing.Size(502, 20);
            this.lblAvisoMod.TabIndex = 45;
            this.lblAvisoMod.Text = "Para atualizar seus modificadores de atributos salve seu personagem!";
            this.lblAvisoMod.Visible = false;
            // 
            // lblPVTotal
            // 
            this.lblPVTotal.AutoSize = true;
            this.lblPVTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPVTotal.Location = new System.Drawing.Point(261, 113);
            this.lblPVTotal.Name = "lblPVTotal";
            this.lblPVTotal.Size = new System.Drawing.Size(66, 13);
            this.lblPVTotal.TabIndex = 46;
            this.lblPVTotal.Text = "PV Totais:";
            // 
            // nudPVTotal
            // 
            this.nudPVTotal.Location = new System.Drawing.Point(333, 111);
            this.nudPVTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPVTotal.Name = "nudPVTotal";
            this.nudPVTotal.Size = new System.Drawing.Size(44, 20);
            this.nudPVTotal.TabIndex = 47;
            // 
            // lblPVAtuais
            // 
            this.lblPVAtuais.AutoSize = true;
            this.lblPVAtuais.BackColor = System.Drawing.Color.Transparent;
            this.lblPVAtuais.Location = new System.Drawing.Point(261, 149);
            this.lblPVAtuais.Name = "lblPVAtuais";
            this.lblPVAtuais.Size = new System.Drawing.Size(66, 13);
            this.lblPVAtuais.TabIndex = 48;
            this.lblPVAtuais.Text = "PV Atuais:";
            // 
            // nudPVAtuais
            // 
            this.nudPVAtuais.Location = new System.Drawing.Point(333, 145);
            this.nudPVAtuais.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPVAtuais.Name = "nudPVAtuais";
            this.nudPVAtuais.Size = new System.Drawing.Size(44, 20);
            this.nudPVAtuais.TabIndex = 49;
            // 
            // rtxtBoxItens
            // 
            this.rtxtBoxItens.Location = new System.Drawing.Point(24, 270);
            this.rtxtBoxItens.Name = "rtxtBoxItens";
            this.rtxtBoxItens.Size = new System.Drawing.Size(255, 119);
            this.rtxtBoxItens.TabIndex = 50;
            this.rtxtBoxItens.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(58, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Itens, idiomas e características:";
            // 
            // btnExcluirItens
            // 
            this.btnExcluirItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItens.Location = new System.Drawing.Point(61, 395);
            this.btnExcluirItens.Name = "btnExcluirItens";
            this.btnExcluirItens.Size = new System.Drawing.Size(152, 28);
            this.btnExcluirItens.TabIndex = 52;
            this.btnExcluirItens.Text = "Excluir Itens";
            this.btnExcluirItens.UseVisualStyleBackColor = true;
            this.btnExcluirItens.Click += new System.EventHandler(this.btnExcluirItens_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackgroundImage = global::RPG_Project.Properties.Resources.fotopersonagempadrao;
            this.pictureBoxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoto.InitialImage = null;
            this.pictureBoxFoto.Location = new System.Drawing.Point(326, 248);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(179, 175);
            this.pictureBoxFoto.TabIndex = 53;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(356, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Foto do Personagem";
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarFoto.Location = new System.Drawing.Point(511, 381);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(117, 33);
            this.btnCarregarFoto.TabIndex = 55;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nudProficiencia
            // 
            this.nudProficiencia.Location = new System.Drawing.Point(471, 111);
            this.nudProficiencia.Name = "nudProficiencia";
            this.nudProficiencia.Size = new System.Drawing.Size(41, 20);
            this.nudProficiencia.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Proficiência: ";
            // 
            // FormRpg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::RPG_Project.Properties.Resources.pergaminho1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudProficiencia);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.btnExcluirItens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtBoxItens);
            this.Controls.Add(this.nudPVAtuais);
            this.Controls.Add(this.lblPVAtuais);
            this.Controls.Add(this.nudPVTotal);
            this.Controls.Add(this.lblPVTotal);
            this.Controls.Add(this.lblAvisoMod);
            this.Controls.Add(this.lblModCarisma);
            this.Controls.Add(this.lblModSabedoria);
            this.Controls.Add(this.lblModInteligencia);
            this.Controls.Add(this.lblModConstituicao);
            this.Controls.Add(this.lblModDestreza);
            this.Controls.Add(this.lblModForça);
            this.Controls.Add(this.btnExcluirPersonagem);
            this.Controls.Add(this.btnCarregarPersonagem);
            this.Controls.Add(this.cmbboxRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.nudCarisma);
            this.Controls.Add(this.lblCarisma);
            this.Controls.Add(this.nudSabedoria);
            this.Controls.Add(this.lblSabedoria);
            this.Controls.Add(this.nudInteligencia);
            this.Controls.Add(this.lblInteligencia);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnSubirDeNivel);
            this.Controls.Add(this.nudConstituicao);
            this.Controls.Add(this.lblConstituição);
            this.Controls.Add(this.nudDestreza);
            this.Controls.Add(this.lblDestreza);
            this.Controls.Add(this.cmbboxClasse);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.nudForca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarPersonagem);
            this.Controls.Add(this.txtboxNomePersonagem);
            this.Controls.Add(this.lblNomePersonagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblResultadoD20);
            this.Controls.Add(this.btnRolarD20);
            this.Controls.Add(this.lblRPG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRpg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.Load += new System.EventHandler(this.RPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstituicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteligencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSabedoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPVTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPVAtuais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProficiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRPG;
        private System.Windows.Forms.Button btnRolarD20;
        private System.Windows.Forms.Label lblResultadoD20;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNomePersonagem;
        private System.Windows.Forms.TextBox txtboxNomePersonagem;
        private System.Windows.Forms.Button btnCriarPersonagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudForca;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ComboBox cmbboxClasse;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.NumericUpDown nudDestreza;
        private System.Windows.Forms.Label lblConstituição;
        private System.Windows.Forms.NumericUpDown nudConstituicao;
        private System.Windows.Forms.Button btnSubirDeNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblInteligencia;
        private System.Windows.Forms.NumericUpDown nudInteligencia;
        private System.Windows.Forms.Label lblSabedoria;
        private System.Windows.Forms.NumericUpDown nudSabedoria;
        private System.Windows.Forms.Label lblCarisma;
        private System.Windows.Forms.NumericUpDown nudCarisma;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.ComboBox cmbboxRaca;
        private System.Windows.Forms.Button btnCarregarPersonagem;
        private System.Windows.Forms.Button btnExcluirPersonagem;
        private System.Windows.Forms.Label lblModForça;
        private System.Windows.Forms.Label lblModDestreza;
        private System.Windows.Forms.Label lblModConstituicao;
        private System.Windows.Forms.Label lblModInteligencia;
        private System.Windows.Forms.Label lblModSabedoria;
        private System.Windows.Forms.Label lblModCarisma;
        private System.Windows.Forms.Label lblAvisoMod;
        private System.Windows.Forms.Label lblPVTotal;
        private System.Windows.Forms.NumericUpDown nudPVTotal;
        private System.Windows.Forms.Label lblPVAtuais;
        private System.Windows.Forms.NumericUpDown nudPVAtuais;
        private System.Windows.Forms.RichTextBox rtxtBoxItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirItens;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.NumericUpDown nudProficiencia;
        private System.Windows.Forms.Label label4;
    }
}

