using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16Joyce
{
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadEmpresa.Location = new Point(this.Width / 2 - pnlCadEmpresa.Width / 2, this.Height / 2 - pnlCadEmpresa.Height / 2);

            cmbDocumento.Text = "CNPJ";

            if (txtCodigo.Text != "")
            {
                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = true;
                cmbDocumento.Enabled = true;
                mkdCpfCnpj.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbCargaHoraria.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }
    }
}
