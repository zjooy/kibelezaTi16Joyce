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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void CarregarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes!! \n\n" + ex);
            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clienteativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes ativos!! \n\n" + erro.Message);
            }
        }

        private void CarregarClienteInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clienteinativo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a lista de clientes inativos!! \n\n" + erro.Message);
            }
        }

        private void CarregarClienteNome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM clientecompleto WHERE `NOME CLIENTE` LIKE '%"+variaveis.nomeCliente+"%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;

                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente!! \n\n" + erro.Message);
            }
        }

        private void ExcluirCliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `cliente` WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCliente.DataSource = dt;
                dgvCliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o cliente!! \n\n" + erro.Message);
            }
        }





        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            pnlCliente.Location = new Point(this.Width / 2 - pnlCliente.Width / 2, this.Height / 2 - pnlCliente.Height / 2);

            CarregarCliente();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                variaveis.funcao = "CADASTRAR";
                new frmCadCliente().Show();
                Hide();

            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada > 0)
            {
                variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirCliente();
                    CarregarCliente();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha!");
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                cmbStatus.Enabled = true;
                CarregarCliente();
            }
            else
            {
                cmbStatus.Text = "TODOS";
                cmbStatus.Enabled = false;
                variaveis.nomeCliente = txtCliente.Text;
                CarregarClienteNome();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO")
            {
                CarregarClienteAtivo();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarClienteInativo();
            }
            else
            {
                CarregarCliente();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codCliente = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1],ListSortDirection.Ascending);
            dgvCliente.ClearSelection();
        }
    }
}
