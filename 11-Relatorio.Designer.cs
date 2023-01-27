namespace kibelezaTi16Joyce
{
    partial class frmRelatorio
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.lblTabela = new System.Windows.Forms.Label();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.radEmpresa = new System.Windows.Forms.RadioButton();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.radTelefone = new System.Windows.Forms.RadioButton();
            this.radInativo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.pnlTabela.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.relatorio;
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.btnAtualizar);
            this.pnlRelatorio.Controls.Add(this.pnlFiltro);
            this.pnlRelatorio.Controls.Add(this.pnlTabela);
            this.pnlRelatorio.Controls.Add(this.btnFechar);
            this.pnlRelatorio.Controls.Add(this.btnSalvar);
            this.pnlRelatorio.Controls.Add(this.dgvRelatorio);
            this.pnlRelatorio.Location = new System.Drawing.Point(151, 131);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1200, 600);
            this.pnlRelatorio.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1109, 36);
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
            this.btnSalvar.Location = new System.Drawing.Point(1026, 104);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 51);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Enabled = false;
            this.dgvRelatorio.Location = new System.Drawing.Point(233, 161);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(931, 422);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // lblTabela
            // 
            this.lblTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTabela.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.ForeColor = System.Drawing.Color.White;
            this.lblTabela.Location = new System.Drawing.Point(0, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(787, 21);
            this.lblTabela.TabIndex = 11;
            this.lblTabela.Text = "TABELA";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlTabela.Controls.Add(this.radFuncionario);
            this.pnlTabela.Controls.Add(this.radEmpresa);
            this.pnlTabela.Controls.Add(this.radCliente);
            this.pnlTabela.Controls.Add(this.lblTabela);
            this.pnlTabela.Location = new System.Drawing.Point(233, 27);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(787, 64);
            this.pnlTabela.TabIndex = 23;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCliente.ForeColor = System.Drawing.Color.White;
            this.radCliente.Location = new System.Drawing.Point(4, 32);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(103, 22);
            this.radCliente.TabIndex = 24;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "CLIENTE";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // radEmpresa
            // 
            this.radEmpresa.AutoSize = true;
            this.radEmpresa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmpresa.ForeColor = System.Drawing.Color.White;
            this.radEmpresa.Location = new System.Drawing.Point(138, 32);
            this.radEmpresa.Name = "radEmpresa";
            this.radEmpresa.Size = new System.Drawing.Size(111, 22);
            this.radEmpresa.TabIndex = 25;
            this.radEmpresa.TabStop = true;
            this.radEmpresa.Text = "EMPRESA";
            this.radEmpresa.UseVisualStyleBackColor = true;
            // 
            // radFuncionario
            // 
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFuncionario.ForeColor = System.Drawing.Color.White;
            this.radFuncionario.Location = new System.Drawing.Point(281, 32);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(156, 22);
            this.radFuncionario.TabIndex = 26;
            this.radFuncionario.TabStop = true;
            this.radFuncionario.Text = "FUNCIONÁRIO";
            this.radFuncionario.UseVisualStyleBackColor = true;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlFiltro.Controls.Add(this.radTelefone);
            this.pnlFiltro.Controls.Add(this.radInativo);
            this.pnlFiltro.Controls.Add(this.radAtivo);
            this.pnlFiltro.Controls.Add(this.lblFiltro);
            this.pnlFiltro.Location = new System.Drawing.Point(233, 91);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(787, 64);
            this.pnlFiltro.TabIndex = 24;
            // 
            // radTelefone
            // 
            this.radTelefone.AutoSize = true;
            this.radTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTelefone.ForeColor = System.Drawing.Color.White;
            this.radTelefone.Location = new System.Drawing.Point(281, 32);
            this.radTelefone.Name = "radTelefone";
            this.radTelefone.Size = new System.Drawing.Size(118, 22);
            this.radTelefone.TabIndex = 26;
            this.radTelefone.TabStop = true;
            this.radTelefone.Text = "TELEFONE";
            this.radTelefone.UseVisualStyleBackColor = true;
            // 
            // radInativo
            // 
            this.radInativo.AutoSize = true;
            this.radInativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInativo.ForeColor = System.Drawing.Color.White;
            this.radInativo.Location = new System.Drawing.Point(138, 32);
            this.radInativo.Name = "radInativo";
            this.radInativo.Size = new System.Drawing.Size(105, 22);
            this.radInativo.TabIndex = 25;
            this.radInativo.TabStop = true;
            this.radInativo.Text = "INATIVO";
            this.radInativo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.ForeColor = System.Drawing.Color.White;
            this.radAtivo.Location = new System.Drawing.Point(4, 32);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(84, 22);
            this.radAtivo.TabIndex = 24;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "ATIVO";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltro.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(0, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(787, 21);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "FILTRO";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.atualizar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(1044, 36);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(45, 45);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 862);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnlRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.RadioButton radTelefone;
        private System.Windows.Forms.RadioButton radInativo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.RadioButton radFuncionario;
        private System.Windows.Forms.RadioButton radEmpresa;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvRelatorio;
    }
}