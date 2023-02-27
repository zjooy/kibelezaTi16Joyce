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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarDadosEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresa` WHERE idEmpresa=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeEmpresa = dr.GetString(1);
                    variaveis.cnpjCpfEmpresa = dr.GetString(2);
                    variaveis.razaoSocialEmpresa = dr.GetString(3);
                    variaveis.emailEmpresa = dr.GetString(4);
                    variaveis.statusEmpresa = dr.GetString(5);
                    variaveis.dataCadEmpresa = dr.GetDateTime(6);
                    variaveis.horarioAtendEmpresa = DateTime.Parse(dr.GetString(7));

                    txtCodigo.Text = variaveis.codEmpresa.ToString();
                    txtNomeFantasia.Text = variaveis.nomeEmpresa;
                    mkdCpfCnpj.Text = variaveis.cnpjCpfEmpresa;
                    if (mkdCpfCnpj.Text.Length > 15)
                    {
                        cmbDocumento.Text = "CNPJ";
                    }
                    else
                    {
                        cmbDocumento.Text = "CPF";
                    }
                    txtRazaoSocial.Text = variaveis.razaoSocialEmpresa;
                    txtEmail.Text = variaveis.emailEmpresa;
                    cmbStatus.Text = variaveis.statusEmpresa;
                    mkdDataDeCadastro.Text = variaveis.dataCadEmpresa.ToString("dd/MM/yyyy");
                    cmbCargaHoraria.Text = variaveis.horarioAtendEmpresa.ToString("HH:mm");
                    banco.Desconectar();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro ao carregar dados da Empresa! \n\n" + ex);
            }
        }

        private void InserirEmpresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `empresa`(`idEmpresa`, `nomeFantasia`, `cnpjCpfEmpresa`, `razaoSocialEmpresa`, `emailEmpresa`, `statusEmpresa`, `dataCadEmpresa`, `horarioAtendEmpresa`) VALUES (DEFAULT,@nomeEmpresa,@cnpjCpfEmpresa,@razaoSocialEmpresa,@emailEmpresa,@statusEmpresa,@dataCadEmpresa,@horarioAtendEmpresa)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpfEmpresa", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocialEmpresa", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@dataCadEmpresa", variaveis.dataCadEmpresa.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horarioAtendEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DA EMPRESA REALIZADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR A EMPRESA. \n\n" + ex);
            }
        }

        

        private void AlterarEmpresa()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `empresa` SET `nomeFantasia`=@nomeEmpresa,`cnpjCpfEmpresa`=@cnpjCpfEmpresa,`razaoSocialEmpresa`=@razaoSocialEmpresa,`emailEmpresa`=@emailEmpresa,`statusEmpresa`=@statusEmpresa,`horarioAtendEmpresa`=@horarioAtendEmpresa WHERE idEmpresa=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpfEmpresa", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocialEmpresa", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@horarioAtendEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DA EMPRESA REALIZADO COM SUCESSO!!", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR A EMPRESA. \n\n" + ex);
            }
        }

        //fone empresa
        public void InserirFoneEmpresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `foneempresa`(`idFoneEmpresa`, `numeroEmpresa`, `operFoneEmpresa`, `descFoneEmpresa`, `idEmpresa`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codEmpresa)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", variaveis.codEmpresa);              
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA CADASTRADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR TELEFONE. \n\n" + ex);
            }
        }

        private void CarregarUltimaEmpresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idEmpresa) FROM `empresa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.codEmpresa = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar última empresa \n\n" + ex);
            }
        }

        public void AlterarFoneEmpresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "UPDATE `foneempresa` SET `numeroEmpresa`=@numeroFone, `operFoneEmpresa`=@operFone, `descFoneEmpresa`=@descFone WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA ALTERADO COM SUCESSO!!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR TELEFONE. \n\n" + ex);
            }
        }

        public void CarregarFoneEmpesa()
        {

                try
                {
                    banco.Conectar();
                    string inserir = "SELECT * FROM `foneempresa` WHERE `idFoneEmpresa`=@codigo";
                    MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                    cmd.Parameters.AddWithValue("@codigo", variaveis.codFoneEmpresa);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        variaveis.codFoneEmpresa = dr.GetInt32(0);
                        variaveis.numeroFoneEmpresa = dr.GetString(1);
                        variaveis.operadoraEmpresa = dr.GetString(2);
                        variaveis.descricaoEmpresa = dr.GetString(3);
                        variaveis.codEmpresa = dr.GetInt32(4);

                        txtCodigo.Text = variaveis.codFoneEmpresa.ToString();
                        mkdCadTelefone.Text = variaveis.numeroFoneEmpresa;
                        cmbOperadora.Text = variaveis.operadoraEmpresa;
                        txtDescricao.Text = variaveis.descricaoEmpresa;
                    }
                    banco.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO AO CARREGAR DADOS DO TELEFONE. \n\n" + ex);
                }
        }


        public void CarregarTelefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM foneempresa WHERE `idEmpresa`=@codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEmpresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTelefone.DataSource = dt;
                dgvTelefone.Columns[0].Visible = false;
                dgvTelefone.Columns[1].HeaderText = "NÚMERO";
                dgvTelefone.Columns[2].HeaderText = "OPERADORA";
                dgvTelefone.Columns[3].HeaderText = "DESCRICAO";
                dgvTelefone.Columns[4].Visible = false;

                dgvTelefone.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR TELEFONES \n\n" + ex);
            }
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            pnlCadEmpresa.Location = new Point(this.Width / 2 - pnlCadEmpresa.Width / 2, this.Height / 2 - pnlCadEmpresa.Height / 2);

            cmbDocumento.Text = "CNPJ";

            CarregarTelefones();

            if (variaveis.funcao == "ALTERAR")
            {
                CarregarDadosEmpresa();
                lblCadEmpresa.Text = "ALTERAR EMPRESA";
            }

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome da empresa!");
                txtNomeFantasia.Focus();
            }
            else if (mkdCpfCnpj.MaskCompleted == false)
            {
                MessageBox.Show("Favor preencher corretamente o número do documento!");
                mkdCpfCnpj.Focus();
            }
            else if (txtRazaoSocial.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a razão social!");
                txtRazaoSocial.Focus();
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email!");
                txtEmail.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status!");
                cmbStatus.Focus();
            }
            else if (cmbCargaHoraria.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar a carga horária!");
                cmbCargaHoraria.Focus();
            }
            else
            {
                variaveis.nomeEmpresa = txtNomeFantasia.Text;
                variaveis.cnpjCpfEmpresa = mkdCpfCnpj.Text;
                variaveis.razaoSocialEmpresa = txtRazaoSocial.Text;
                variaveis.emailEmpresa = txtEmail.Text;
                variaveis.statusEmpresa = cmbStatus.Text;
                if (variaveis.funcao == "CADASTRAR")
                {
                    mkdDataDeCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadEmpresa = DateTime.Parse(mkdDataDeCadastro.Text);
                }
                variaveis.horarioAtendEmpresa = DateTime.Parse(cmbCargaHoraria.Text);

                if (variaveis.funcao == "CADASTRAR")
                {
                    InserirEmpresa();
                    CarregarUltimaEmpresa();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    AlterarEmpresa();
                }

                pnlTelefone.Enabled = true;
                btnSalvar.Enabled = false;
                btnLimpar.Enabled = false;

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR FONE";
            pnlCadFone.Visible = true;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
            pnlCadEmpresa.Enabled = false;
            mkdCadTelefone.Focus(); 
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            pnlCadEmpresa.Enabled = true;
            CarregarTelefones();
            pnlCadFone.Visible = false;
            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);

        }

        private void txtNomeFantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbDocumento.Enabled = true;
                cmbDocumento.Focus();
            }
        }

        private void mkdCadTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbOperadora.Enabled = true;
                cmbOperadora.Focus();
            }
        }

        private void cmbOperadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvarFone.Enabled = true;
                btnSalvarFone.Focus();
            }
        }

        private void mkdCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRazaoSocial.Enabled = true;
                txtRazaoSocial.Focus();
            }
            
        }

        private void cmbDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCpfCnpj.Enabled = true;
                mkdCpfCnpj.Focus();
            }
            
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
            
        }

        private void btnSalvarFone_Click(object sender, EventArgs e)
        {
            if (mkdCadTelefone.MaskCompleted == false)
            {
                MessageBox.Show("Preencher o telefone");
                mkdCadTelefone.Focus();
            }
            else if (cmbOperadora.Text == "")
            {
                MessageBox.Show("Preencher a operadora");
                cmbOperadora.Focus();
            }
            else if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencher a operadora");
                txtDescricao.Focus();
            }
            else
            {
                variaveis.numeroFoneEmpresa = mkdCadTelefone.Text;
                variaveis.operadoraEmpresa = cmbOperadora.Text;
                variaveis.descricaoEmpresa = txtDescricao.Text;

                if (variaveis.funcao == "CADASTRAR FONE")
                {
                    InserirFoneEmpresa();
                }
                else if (variaveis.funcao == "ALTERAR FONE")
                {
                    AlterarFoneEmpresa();
                }
            }
            btnLimparFone.PerformClick();
        }

        private void btnLimparFone_Click(object sender, EventArgs e)
        {
            mkdCadTelefone.Text = String.Empty;
            cmbOperadora.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            cmbOperadora.Enabled = false;
            txtDescricao.Enabled = false;
            btnSalvarFone.Enabled = false;
            mkdCadTelefone.Focus();
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCargaHoraria.Enabled = true;
                cmbCargaHoraria.Focus();
            }
        }

        private void cmbCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR FONE";
            pnlCadFone.Visible = true;

            CarregarFoneEmpesa();

            pnlCadFone.Location = new Point(this.Width / 2 - pnlCadFone.Width / 2, this.Height / 2 - pnlCadFone.Height / 2);
            pnlCadEmpresa.Enabled = false;
            mkdCadTelefone.Focus();
        }

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocumento.Text == "CNPJ")
            {
                mkdCpfCnpj.Mask = "00,000,000/0000-00";
            }
            else if (cmbDocumento.Text == "CPF")
            {
                mkdCpfCnpj.Mask = "000,000,000-00";
            }
        }

        private void dgvTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = -1;
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFoneEmpresa = Convert.ToInt32(dgvTelefone[0, variaveis.linhaSelecionada].Value);
            }
        }

        
    }
}
