namespace kibelezaTi16Joyce
{
    partial class frmEmpresa
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
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pnlEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.pnlBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.empresa;
            this.pnlEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmpresa.Controls.Add(this.dgvEmpresa);
            this.pnlEmpresa.Controls.Add(this.btnExcluir);
            this.pnlEmpresa.Controls.Add(this.btnAlterar);
            this.pnlEmpresa.Controls.Add(this.btnCadastrar);
            this.pnlEmpresa.Controls.Add(this.btnFechar);
            this.pnlEmpresa.Controls.Add(this.pnlBusca);
            this.pnlEmpresa.Location = new System.Drawing.Point(75, 94);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(1200, 600);
            this.pnlEmpresa.TabIndex = 0;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(192, 61);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(1002, 478);
            this.dgvEmpresa.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(1034, 545);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 50);
            this.btnExcluir.TabIndex = 6;
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
            this.btnAlterar.Location = new System.Drawing.Point(628, 544);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(160, 50);
            this.btnAlterar.TabIndex = 5;
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
            this.btnCadastrar.Location = new System.Drawing.Point(192, 545);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1144, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.pnlBusca.Controls.Add(this.cmbStatus);
            this.pnlBusca.Controls.Add(this.txtEmpresa);
            this.pnlBusca.Controls.Add(this.lblStatus);
            this.pnlBusca.Controls.Add(this.lblEmpresa);
            this.pnlBusca.Location = new System.Drawing.Point(192, 5);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(946, 50);
            this.pnlBusca.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVA",
            "INATIVA"});
            this.cmbStatus.Location = new System.Drawing.Point(725, 10);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(206, 29);
            this.cmbStatus.TabIndex = 3;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmpresa.Location = new System.Drawing.Point(115, 10);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(520, 29);
            this.txtEmpresa.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(636, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "STATUS";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(3, 10);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(111, 27);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 812);
            this.Controls.Add(this.pnlEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.pnlEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}