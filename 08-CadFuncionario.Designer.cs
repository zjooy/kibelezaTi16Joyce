namespace kibelezaTi16Joyce
{
    partial class frmCadFuncionario
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
            this.pnlCadFuncionario = new System.Windows.Forms.Panel();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCargaHoraria = new System.Windows.Forms.ComboBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.mkdDataDeCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCadFuncionario = new System.Windows.Forms.Label();
            this.pnlCadFuncionario.SuspendLayout();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadFuncionario
            // 
            this.pnlCadFuncionario.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.funcionario;
            this.pnlCadFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadFuncionario.Controls.Add(this.cmbEmpresa);
            this.pnlCadFuncionario.Controls.Add(this.lblEmpresa);
            this.pnlCadFuncionario.Controls.Add(this.cmbNivel);
            this.pnlCadFuncionario.Controls.Add(this.lblNivel);
            this.pnlCadFuncionario.Controls.Add(this.txtSenha);
            this.pnlCadFuncionario.Controls.Add(this.lblSenha);
            this.pnlCadFuncionario.Controls.Add(this.btnFechar);
            this.pnlCadFuncionario.Controls.Add(this.btnSalvar);
            this.pnlCadFuncionario.Controls.Add(this.btnLimpar);
            this.pnlCadFuncionario.Controls.Add(this.cmbCargaHoraria);
            this.pnlCadFuncionario.Controls.Add(this.lblCargaHoraria);
            this.pnlCadFuncionario.Controls.Add(this.mkdDataDeCadastro);
            this.pnlCadFuncionario.Controls.Add(this.label3);
            this.pnlCadFuncionario.Controls.Add(this.pnlTelefone);
            this.pnlCadFuncionario.Controls.Add(this.cmbStatus);
            this.pnlCadFuncionario.Controls.Add(this.lblStatus);
            this.pnlCadFuncionario.Controls.Add(this.lblEmail);
            this.pnlCadFuncionario.Controls.Add(this.txtEmail);
            this.pnlCadFuncionario.Controls.Add(this.txtNomeFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.txtCodigo);
            this.pnlCadFuncionario.Controls.Add(this.lblNomeFuncionario);
            this.pnlCadFuncionario.Controls.Add(this.lblCodigo);
            this.pnlCadFuncionario.Controls.Add(this.lblCadFuncionario);
            this.pnlCadFuncionario.Location = new System.Drawing.Point(147, 138);
            this.pnlCadFuncionario.Name = "pnlCadFuncionario";
            this.pnlCadFuncionario.Size = new System.Drawing.Size(1200, 600);
            this.pnlCadFuncionario.TabIndex = 1;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(873, 315);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(312, 30);
            this.cmbEmpresa.TabIndex = 28;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmpresa.Location = new System.Drawing.Point(873, 291);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(87, 21);
            this.lblEmpresa.TabIndex = 27;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Enabled = false;
            this.cmbNivel.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OUTROS"});
            this.cmbNivel.Location = new System.Drawing.Point(196, 239);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(238, 30);
            this.cmbNivel.TabIndex = 26;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNivel.Location = new System.Drawing.Point(193, 216);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(58, 21);
            this.lblNivel.TabIndex = 25;
            this.lblNivel.Text = "NÍVEL";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(930, 169);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(255, 31);
            this.txtSenha.TabIndex = 24;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSenha.Location = new System.Drawing.Point(929, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 21);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "SENHA";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1146, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 45);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(986, 496);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(199, 45);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(986, 434);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(199, 45);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // cmbCargaHoraria
            // 
            this.cmbCargaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaHoraria.Enabled = false;
            this.cmbCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbCargaHoraria.FormattingEnabled = true;
            this.cmbCargaHoraria.Items.AddRange(new object[] {
            "02:00",
            "04:00",
            "06:00",
            "08:00",
            "10:00"});
            this.cmbCargaHoraria.Location = new System.Drawing.Point(929, 240);
            this.cmbCargaHoraria.Name = "cmbCargaHoraria";
            this.cmbCargaHoraria.Size = new System.Drawing.Size(256, 30);
            this.cmbCargaHoraria.TabIndex = 19;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.BackColor = System.Drawing.Color.Transparent;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCargaHoraria.Location = new System.Drawing.Point(929, 216);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(146, 21);
            this.lblCargaHoraria.TabIndex = 18;
            this.lblCargaHoraria.Text = "CARGA HORÁRIA";
            // 
            // mkdDataDeCadastro
            // 
            this.mkdDataDeCadastro.Enabled = false;
            this.mkdDataDeCadastro.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDataDeCadastro.Location = new System.Drawing.Point(716, 238);
            this.mkdDataDeCadastro.Mask = "00/00/0000";
            this.mkdDataDeCadastro.Name = "mkdDataDeCadastro";
            this.mkdDataDeCadastro.Size = new System.Drawing.Size(201, 31);
            this.mkdDataDeCadastro.TabIndex = 17;
            this.mkdDataDeCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(712, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "DATA DE CADASTRO";
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.telefone;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.bntExcluir);
            this.pnlTelefone.Controls.Add(this.btnAlterar);
            this.pnlTelefone.Controls.Add(this.btnCadastrar);
            this.pnlTelefone.Controls.Add(this.dgvTelefone);
            this.pnlTelefone.Enabled = false;
            this.pnlTelefone.Location = new System.Drawing.Point(197, 277);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(670, 316);
            this.pnlTelefone.TabIndex = 15;
            // 
            // bntExcluir
            // 
            this.bntExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.bntExcluir.FlatAppearance.BorderSize = 0;
            this.bntExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExcluir.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.ForeColor = System.Drawing.Color.White;
            this.bntExcluir.Location = new System.Drawing.Point(523, 267);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(140, 46);
            this.bntExcluir.TabIndex = 13;
            this.bntExcluir.Text = "EXCLUIR";
            this.bntExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(324, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(140, 46);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(110, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(140, 46);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Enabled = false;
            this.dgvTelefone.Location = new System.Drawing.Point(110, 0);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.Size = new System.Drawing.Size(553, 264);
            this.dgvTelefone.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(451, 239);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(253, 30);
            this.cmbStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(448, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 21);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "STATUS";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(193, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(194, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(715, 31);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(349, 91);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(836, 31);
            this.txtNomeFuncionario.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(194, 91);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 31);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(345, 67);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(175, 21);
            this.lblNomeFuncionario.TabIndex = 2;
            this.lblNomeFuncionario.Text = "NOME FUNCIONÁRIO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(193, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 21);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblCadFuncionario
            // 
            this.lblCadFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadFuncionario.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblCadFuncionario.Location = new System.Drawing.Point(187, 1);
            this.lblCadFuncionario.Name = "lblCadFuncionario";
            this.lblCadFuncionario.Size = new System.Drawing.Size(1013, 54);
            this.lblCadFuncionario.TabIndex = 0;
            this.lblCadFuncionario.Text = "CADASTRAR FUNCIONÁRIO";
            this.lblCadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1495, 876);
            this.Controls.Add(this.pnlCadFuncionario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.pnlCadFuncionario.ResumeLayout(false);
            this.pnlCadFuncionario.PerformLayout();
            this.pnlTelefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadFuncionario;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCargaHoraria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.MaskedTextBox mkdDataDeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCadFuncionario;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}