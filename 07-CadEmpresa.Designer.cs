namespace kibelezaTi16Joyce
{
    partial class frmCadEmpresa
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
            this.pnlCadEmpresa = new System.Windows.Forms.Panel();
            this.pnlTelefone = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkdCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCadEmpresa = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mkdDataDeCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.cmbCargaHoraria = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlCadEmpresa.SuspendLayout();
            this.pnlTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadEmpresa
            // 
            this.pnlCadEmpresa.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.empresa;
            this.pnlCadEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCadEmpresa.Controls.Add(this.btnFechar);
            this.pnlCadEmpresa.Controls.Add(this.btnSalvar);
            this.pnlCadEmpresa.Controls.Add(this.btnLimpar);
            this.pnlCadEmpresa.Controls.Add(this.cmbCargaHoraria);
            this.pnlCadEmpresa.Controls.Add(this.lblCargaHoraria);
            this.pnlCadEmpresa.Controls.Add(this.mkdDataDeCadastro);
            this.pnlCadEmpresa.Controls.Add(this.label3);
            this.pnlCadEmpresa.Controls.Add(this.pnlTelefone);
            this.pnlCadEmpresa.Controls.Add(this.cmbStatus);
            this.pnlCadEmpresa.Controls.Add(this.lblStatus);
            this.pnlCadEmpresa.Controls.Add(this.cmbDocumento);
            this.pnlCadEmpresa.Controls.Add(this.lblEmail);
            this.pnlCadEmpresa.Controls.Add(this.txtRazaoSocial);
            this.pnlCadEmpresa.Controls.Add(this.label2);
            this.pnlCadEmpresa.Controls.Add(this.txtEmail);
            this.pnlCadEmpresa.Controls.Add(this.label1);
            this.pnlCadEmpresa.Controls.Add(this.mkdCpfCnpj);
            this.pnlCadEmpresa.Controls.Add(this.lblDocumento);
            this.pnlCadEmpresa.Controls.Add(this.txtNomeFantasia);
            this.pnlCadEmpresa.Controls.Add(this.txtCodigo);
            this.pnlCadEmpresa.Controls.Add(this.lblNomeFantasia);
            this.pnlCadEmpresa.Controls.Add(this.lblCodigo);
            this.pnlCadEmpresa.Controls.Add(this.lblCadEmpresa);
            this.pnlCadEmpresa.Location = new System.Drawing.Point(47, 93);
            this.pnlCadEmpresa.Name = "pnlCadEmpresa";
            this.pnlCadEmpresa.Size = new System.Drawing.Size(1200, 600);
            this.pnlCadEmpresa.TabIndex = 0;
            // 
            // pnlTelefone
            // 
            this.pnlTelefone.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.telefone;
            this.pnlTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTelefone.Controls.Add(this.bntExcluir);
            this.pnlTelefone.Controls.Add(this.btnAlterar);
            this.pnlTelefone.Controls.Add(this.btnCadastrar);
            this.pnlTelefone.Controls.Add(this.dgvTelefone);
            this.pnlTelefone.Location = new System.Drawing.Point(197, 277);
            this.pnlTelefone.Name = "pnlTelefone";
            this.pnlTelefone.Size = new System.Drawing.Size(670, 316);
            this.pnlTelefone.TabIndex = 15;
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
            this.cmbStatus.Location = new System.Drawing.Point(932, 239);
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
            this.lblStatus.Location = new System.Drawing.Point(929, 216);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 21);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "STATUS";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.cmbDocumento.Location = new System.Drawing.Point(194, 164);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(146, 30);
            this.cmbDocumento.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(193, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(613, 164);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(572, 31);
            this.txtRazaoSocial.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(610, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "RAZÃO SOCIAL";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(194, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(715, 31);
            this.txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(345, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "CNPJ / CPF";
            // 
            // mkdCpfCnpj
            // 
            this.mkdCpfCnpj.Enabled = false;
            this.mkdCpfCnpj.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCpfCnpj.Location = new System.Drawing.Point(348, 164);
            this.mkdCpfCnpj.Mask = "00,000,000/0000-00";
            this.mkdCpfCnpj.Name = "mkdCpfCnpj";
            this.mkdCpfCnpj.Size = new System.Drawing.Size(247, 31);
            this.mkdCpfCnpj.TabIndex = 6;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDocumento.Location = new System.Drawing.Point(192, 141);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(114, 21);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "DOCUMENTO";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(349, 91);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(836, 31);
            this.txtNomeFantasia.TabIndex = 4;
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
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeFantasia.Location = new System.Drawing.Point(345, 67);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(250, 21);
            this.lblNomeFantasia.TabIndex = 2;
            this.lblNomeFantasia.Text = "NOME FANTASIA DA EMPRESA";
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
            // lblCadEmpresa
            // 
            this.lblCadEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCadEmpresa.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblCadEmpresa.Location = new System.Drawing.Point(187, 1);
            this.lblCadEmpresa.Name = "lblCadEmpresa";
            this.lblCadEmpresa.Size = new System.Drawing.Size(1013, 54);
            this.lblCadEmpresa.TabIndex = 0;
            this.lblCadEmpresa.Text = "CADASTRAR EMPRESA";
            this.lblCadEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(982, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "DATA DE CADASTRO";
            // 
            // mkdDataDeCadastro
            // 
            this.mkdDataDeCadastro.Enabled = false;
            this.mkdDataDeCadastro.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDataDeCadastro.Location = new System.Drawing.Point(984, 313);
            this.mkdDataDeCadastro.Mask = "00/00/0000";
            this.mkdDataDeCadastro.Name = "mkdDataDeCadastro";
            this.mkdDataDeCadastro.Size = new System.Drawing.Size(201, 31);
            this.mkdDataDeCadastro.TabIndex = 17;
            this.mkdDataDeCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.BackColor = System.Drawing.Color.Transparent;
            this.lblCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCargaHoraria.Location = new System.Drawing.Point(986, 361);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(146, 21);
            this.lblCargaHoraria.TabIndex = 18;
            this.lblCargaHoraria.Text = "CARGA HORÁRIA";
            // 
            // cmbCargaHoraria
            // 
            this.cmbCargaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargaHoraria.Enabled = false;
            this.cmbCargaHoraria.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbCargaHoraria.FormattingEnabled = true;
            this.cmbCargaHoraria.Items.AddRange(new object[] {
            "04:00",
            "06:00",
            "08:00",
            "10:00",
            "12:00"});
            this.cmbCargaHoraria.Location = new System.Drawing.Point(986, 385);
            this.cmbCargaHoraria.Name = "cmbCargaHoraria";
            this.cmbCargaHoraria.Size = new System.Drawing.Size(199, 30);
            this.cmbCargaHoraria.TabIndex = 19;
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
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 807);
            this.Controls.Add(this.pnlCadEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadEmpresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadEmpresa_Load);
            this.pnlCadEmpresa.ResumeLayout(false);
            this.pnlCadEmpresa.PerformLayout();
            this.pnlTelefone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadEmpresa;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCadEmpresa;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkdCpfCnpj;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlTelefone;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCargaHoraria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.MaskedTextBox mkdDataDeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}