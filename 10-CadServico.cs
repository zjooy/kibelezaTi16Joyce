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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadServico.Location = new Point(this.Width / 2 - pnlCadServico.Width / 2, this.Height / 2 - pnlCadServico.Height / 2);


            if (txtCodigo.Text != "")
            {
                //pnlFoto.Enabled = true;
                btnSalvar.Enabled = true;
                txtValor.Enabled = true;
                txtDescricao.Enabled = true;
                cmbStatus.Enabled = true;
                cmbEmpresa.Enabled = true;
                btnFoto1.Enabled = true;
                btnFoto2.Enabled = true;
                btnFoto3.Enabled = true;
                btnFoto4.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }
    }
}
