namespace kibelezaTi16Joyce
{
    partial class frmReserva
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
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.meuCalendario1 = new kibelezaTi16Joyce.MeuCalendario();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfoReserva = new System.Windows.Forms.Panel();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cmbTempExecucao = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.pnlReserva.SuspendLayout();
            this.pnlInfoReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.reserva;
            this.pnlReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReserva.Controls.Add(this.lblDataReserva);
            this.pnlReserva.Controls.Add(this.meuCalendario1);
            this.pnlReserva.Controls.Add(this.comboBox3);
            this.pnlReserva.Controls.Add(this.label1);
            this.pnlReserva.Controls.Add(this.pnlInfoReserva);
            this.pnlReserva.Controls.Add(this.cmbTempExecucao);
            this.pnlReserva.Controls.Add(this.lblHorario);
            this.pnlReserva.Controls.Add(this.btnFechar);
            this.pnlReserva.Controls.Add(this.btnSalvar);
            this.pnlReserva.Controls.Add(this.btnLimpar);
            this.pnlReserva.Controls.Add(this.txtObservacao);
            this.pnlReserva.Controls.Add(this.txtCodigo);
            this.pnlReserva.Controls.Add(this.lblObservacao);
            this.pnlReserva.Controls.Add(this.lblCodigo);
            this.pnlReserva.Controls.Add(this.lblReserva);
            this.pnlReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.pnlReserva.Location = new System.Drawing.Point(187, 121);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(1200, 600);
            this.pnlReserva.TabIndex = 4;
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataReserva.Location = new System.Drawing.Point(664, 139);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(160, 21);
            this.lblDataReserva.TabIndex = 39;
            this.lblDataReserva.Text = "DATA DA RESERVA";
            // 
            // meuCalendario1
            // 
            this.meuCalendario1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meuCalendario1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.meuCalendario1.Location = new System.Drawing.Point(668, 162);
            this.meuCalendario1.Name = "meuCalendario1";
            this.meuCalendario1.TabIndex = 38;
            this.meuCalendario1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.meuCalendario1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.meuCalendario1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "AGUARDANDO",
            "APROVADA",
            "CANCELADA",
            "FINALIZADA"});
            this.comboBox3.Location = new System.Drawing.Point(214, 422);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(442, 30);
            this.comboBox3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(210, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "STATUS";
            // 
            // pnlInfoReserva
            // 
            this.pnlInfoReserva.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfoReserva.Controls.Add(this.cmbServico);
            this.pnlInfoReserva.Controls.Add(this.lblStatus);
            this.pnlInfoReserva.Controls.Add(this.cmbCliente);
            this.pnlInfoReserva.Controls.Add(this.lblCliente);
            this.pnlInfoReserva.Controls.Add(this.cmbFuncionario);
            this.pnlInfoReserva.Controls.Add(this.lblFuncionario);
            this.pnlInfoReserva.Location = new System.Drawing.Point(196, 139);
            this.pnlInfoReserva.Name = "pnlInfoReserva";
            this.pnlInfoReserva.Size = new System.Drawing.Size(460, 240);
            this.pnlInfoReserva.TabIndex = 34;
            // 
            // cmbServico
            // 
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.Enabled = false;
            this.cmbServico.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbServico.Location = new System.Drawing.Point(17, 194);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(422, 30);
            this.cmbServico.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(14, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 21);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "SERVIÇO";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbCliente.Location = new System.Drawing.Point(18, 116);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(422, 30);
            this.cmbCliente.TabIndex = 16;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCliente.Location = new System.Drawing.Point(14, 95);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(78, 21);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "CLIENTE";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Enabled = false;
            this.cmbFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmbFuncionario.Location = new System.Drawing.Point(18, 39);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(422, 30);
            this.cmbFuncionario.TabIndex = 14;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFuncionario.Location = new System.Drawing.Point(14, 18);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(122, 21);
            this.lblFuncionario.TabIndex = 13;
            this.lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // cmbTempExecucao
            // 
            this.cmbTempExecucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempExecucao.Enabled = false;
            this.cmbTempExecucao.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbTempExecucao.FormattingEnabled = true;
            this.cmbTempExecucao.Items.AddRange(new object[] {
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00"});
            this.cmbTempExecucao.Location = new System.Drawing.Point(985, 162);
            this.cmbTempExecucao.Name = "cmbTempExecucao";
            this.cmbTempExecucao.Size = new System.Drawing.Size(197, 30);
            this.cmbTempExecucao.TabIndex = 33;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorario.Location = new System.Drawing.Point(982, 139);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(87, 21);
            this.lblHorario.TabIndex = 32;
            this.lblHorario.Text = "HORÁRIO";
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
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(734, 507);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 61);
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
            this.btnLimpar.Location = new System.Drawing.Point(982, 507);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 61);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(349, 91);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(836, 31);
            this.txtObservacao.TabIndex = 4;
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
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblObservacao.Location = new System.Drawing.Point(345, 67);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(119, 21);
            this.lblObservacao.TabIndex = 2;
            this.lblObservacao.Text = "OBSERVAÇÃO";
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
            // lblReserva
            // 
            this.lblReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblReserva.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(187, 1);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(1013, 54);
            this.lblReserva.TabIndex = 0;
            this.lblReserva.Text = "RESERVA";
            this.lblReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1575, 842);
            this.Controls.Add(this.pnlReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            this.pnlInfoReserva.ResumeLayout(false);
            this.pnlInfoReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Panel pnlInfoReserva;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cmbTempExecucao;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label lblDataReserva;
        private MeuCalendario meuCalendario1;
    }
}