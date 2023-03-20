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
    public partial class frmAjuda : Form
    {
        public frmAjuda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Hide();
        }

        private void frmAjuda_Load(object sender, EventArgs e)
        {
            pnlAjuda.Location = new Point(this.Width / 2 - pnlAjuda.Width / 2, this.Height / 2 - pnlAjuda.Height / 2);

        }
    }
}
