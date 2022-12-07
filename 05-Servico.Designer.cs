namespace kibelezaTi16Joyce
{
    partial class frmServico
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
            this.pnlServico = new System.Windows.Forms.Panel();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.pnlServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.pnlBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlServico
            // 
            this.pnlServico.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.servico;
            this.pnlServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlServico.Controls.Add(this.pnlBusca);
            this.pnlServico.Controls.Add(this.dgvServico);
            this.pnlServico.Controls.Add(this.btnExcluir);
            this.pnlServico.Controls.Add(this.btnAlterar);
            this.pnlServico.Controls.Add(this.btnCadastrar);
            this.pnlServico.Controls.Add(this.btnFechar);
            this.pnlServico.Location = new System.Drawing.Point(55, 102);
            this.pnlServico.Name = "pnlServico";
            this.pnlServico.Size = new System.Drawing.Size(1200, 600);
            this.pnlServico.TabIndex = 0;
            // 
            // dgvServico
            // 
            this.dgvServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(192, 60);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(1002, 478);
            this.dgvServico.TabIndex = 13;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(1034, 544);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 50);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(628, 543);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(160, 50);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(192, 544);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1148, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlBusca.Controls.Add(this.cmbStatus);
            this.pnlBusca.Controls.Add(this.txtServico);
            this.pnlBusca.Controls.Add(this.lblStatus);
            this.pnlBusca.Controls.Add(this.lblServico);
            this.pnlBusca.Location = new System.Drawing.Point(191, 6);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(954, 50);
            this.pnlBusca.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(741, 10);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(206, 29);
            this.cmbStatus.TabIndex = 4;
            // 
            // txtServico
            // 
            this.txtServico.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtServico.Location = new System.Drawing.Point(104, 10);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(547, 29);
            this.txtServico.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(649, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "STATUS";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.White;
            this.lblServico.Location = new System.Drawing.Point(4, 11);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(103, 27);
            this.lblServico.TabIndex = 1;
            this.lblServico.Text = "SERVIÇO";
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 810);
            this.Controls.Add(this.pnlServico);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "servico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServico_Load);
            this.pnlServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlServico;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvServico;
    }
}