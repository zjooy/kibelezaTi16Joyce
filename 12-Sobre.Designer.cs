namespace kibelezaTi16Joyce
{
    partial class frmSobre
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
            this.pnlSobre = new System.Windows.Forms.Panel();
            this.lblSobre = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSobre
            // 
            this.pnlSobre.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.sobre;
            this.pnlSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSobre.Controls.Add(this.lblSobre);
            this.pnlSobre.Controls.Add(this.btnFechar);
            this.pnlSobre.Location = new System.Drawing.Point(134, 119);
            this.pnlSobre.Name = "pnlSobre";
            this.pnlSobre.Size = new System.Drawing.Size(1200, 600);
            this.pnlSobre.TabIndex = 4;
            // 
            // lblSobre
            // 
            this.lblSobre.BackColor = System.Drawing.Color.Transparent;
            this.lblSobre.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSobre.Location = new System.Drawing.Point(219, 63);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(935, 537);
            this.lblSobre.TabIndex = 23;
            this.lblSobre.Text = "SISTEMA DESENVOLVIDO PELA TURMA\r\n\r\nTÉCNICO EM INFORMÁTICA - TI16 - 2023\r\n\r\nSENAC " +
    "SÃO MIGUEL PAULISTA\r\n\r\nDESENVOLVEDORA: JOYCE";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1109, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 45);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibelezaTi16Joyce.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1468, 838);
            this.Controls.Add(this.pnlSobre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.pnlSobre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSobre;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSobre;
    }
}