using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.Width/2,this.Height / 2 - pnlLogin.Height/2);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            variaveis.senha = txtSenha.Text;

            if (variaveis.usuario == "JOYCE" && variaveis.senha == "1234")
            {
                variaveis.nivel = "ADMINISTRADOR";

                new frmMenuPrincipal().Show();
                Hide();
            }
            else
            {
                try
                {
                    banco.Conectar();
                    string selecionar = "SELECT nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, statusFuncionario FROM funcionario WHERE emailFuncionario=@email AND senhaFuncionario=@senha AND statusFuncionario=@status";
                    MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(0);
                        variaveis.nivel= reader.GetString(3);
                        new frmMenuPrincipal().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO!!");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao selecionar usuário de Login"+ex,"ERRO");
                }
            }



            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
