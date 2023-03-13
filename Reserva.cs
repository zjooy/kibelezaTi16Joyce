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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        public void InserirReserva()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `reserva`(`idReserva`, `obsReserva`, `dataReserva`, `horaReserva`, `statusReserva`, `idFuncionario`, `idCliente`, `idServico`) VALUES (DEFAULT, @obs,@dataReserva,@horaReserva,@status,@codFuncionario,@codCliente,@codServico)";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", variaveis.codServico);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reserva cadastrada com sucesso", "CADASTRO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar a reserva!!\n\n" + erro, "ERRO");
            }
        }

        public void AlterarReserva()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `reserva` SET `obsReserva`=@obs,`dataReserva`=@dataReserva,`horaReserva`=@horaReserva,`statusReserva`=@status,`idFuncionario`=@codFuncionario,`idCliente`=@codCliente,`idServico`=@codServico WHERE `idReserva`=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", variaveis.codServico);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codReserva);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reserva alterada com sucesso", "ALTERAÇÃO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar a reserva!!\n\n" + erro, "ERRO");
            }
        }

        public void CarregarDadosReserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT `idReserva`, `obsReserva`,`dataReserva`,DATE_FORMAT(horaReserva,'%H:%i'), `statusReserva`, `nomeFuncionario`, `nomeCliente`, `nomeServico` FROM `reserva` INNER JOIN funcionario ON reserva.idFuncionario = funcionario.idFuncionario INNER JOIN cliente ON reserva.idReserva = cliente.idCliente INNER JOIN servico ON reserva.idServico = servico.idServico WHERE idReserva = @codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codReserva);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.obsReserva = reader.GetString(1);
                    variaveis.dataReserva = reader.GetDateTime(2);
                    variaveis.horarioReserva = DateTime.Parse(reader.GetString(3));
                    variaveis.statusReserva = reader.GetString(4);
                    variaveis.nomeFuncionario = reader.GetString(5);
                    variaveis.nomeCliente = reader.GetString(6);
                    variaveis.nomeServico = reader.GetString(7);
                    txtCodigo.Text = variaveis.codReserva.ToString();
                    txtObservacao.Text = variaveis.obsReserva;
                    calReserva.SelectionStart = variaveis.dataReserva;
                    cmbHorario.Text = variaveis.horarioReserva.ToString("HH:mm");
                    cmbStatus.Text = variaveis.statusReserva;
                    cmbFuncionario.Text = variaveis.nomeFuncionario;
                    cmbCliente.Text = variaveis.nomeCliente;
                    cmbServico.Text = variaveis.nomeServico;

                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar dados da reserva!!\n\n" + erro, "ERRO");
            }
        }

        public void CarregarFuncionarios()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idFuncionario,nomeFuncionario FROM funcionario ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFuncionario.DataSource = dt;
                cmbFuncionario.DisplayMember = "nomeFuncionario";
                cmbFuncionario.ValueMember = "idFuncionario";
                cmbFuncionario.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de funcionários.\n\n" + ex.Message);
            }
        }

        public void CarregarClientes()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idCliente,nomeCliente FROM cliente ORDER BY nomeCliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCliente.DataSource = dt;
                cmbCliente.DisplayMember = "nomeCliente";
                cmbCliente.ValueMember = "idCliente";
                cmbCliente.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Clientes.\n\n" + ex.Message);
            }
        }

        public void CarregarServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idServico,nomeServico FROM servico ORDER BY nomeServico";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbServico.DataSource = dt;
                cmbServico.DisplayMember = "nomeServico";
                cmbServico.ValueMember = "idServico";
                cmbServico.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Servicos.\n\n" + ex.Message);
            }
        }

        public void CarregarHorarioDisponivel()
        {
            try
            {
                banco.Conectar();
                string sql = "SELECT `idHorarioReserva`,DATE_FORMAT(`horarioReserva`, '%H:%i')  FROM `horariosreserva` WHERE DATE_FORMAT(`horarioReserva`, '%H:%i') NOT IN (SELECT DATE_FORMAT(`horarioReserva`, '%H:%i') FROM reserva WHERE idFuncionario=@codFuncionario AND dataReserva=@dataReserva AND NOT idReserva = @codigoReserva) ORDER BY horarioReserva";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigoReserva", variaveis.codReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Convert.ToInt32(cmbFuncionario.SelectedValue));
                cmd.Parameters.AddWithValue("@dataReserva", Convert.ToDateTime(calReserva.SelectionStart.ToShortTimeString()));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbHorario.DataSource = dt;
                cmbHorario.DisplayMember = "DATE_FORMAT(`horarioReserva`, '%H:%i')"; // CAMPO QUE PRECISA MOSTRAR
                cmbHorario.ValueMember = "idHorarioReserva";
                cmbHorario.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar horários disponíveis.\n\n" + erro, "ERRO");
            }
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            pnlReserva.Location = new Point(this.Width / 2 - pnlReserva.Width / 2, this.Height / 2 - pnlReserva.Height / 2);

            calReserva.MinDate = DateTime.Now;
            calReserva.MaxDate = DateTime.Now.AddDays(31);

            CarregarFuncionarios();
            CarregarClientes();
            CarregarServico();

            if (variaveis.funcao == "EDITAR")
            {
                lblReserva.Text = "EDITAR RESERVA";
                CarregarDadosReserva();
                CarregarHorarioDisponivel();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Hide();
        }

        private void cmbFuncionario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarHorarioDisponivel();
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbFuncionario.Enabled = true;
                cmbFuncionario.Focus();
            }
        }

        private void cmbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCliente.Enabled = true;
                CarregarHorarioDisponivel();
                cmbCliente.Focus();
            }
        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbServico.Enabled = true;
                cmbServico.Focus();
            }
        }

        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calReserva.Enabled = true;
                calReserva.Focus();
            }
        }

        private void calReserva_DateSelected(object sender, DateRangeEventArgs e)
        {
            variaveis.dataReserva = calReserva.SelectionStart;
            cmbHorario.Enabled = true;
            cmbHorario.Focus();
            CarregarHorarioDisponivel();
        }

        private void cmbHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtObservacao.Clear();
            cmbHorario.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;

            txtObservacao.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtObservacao.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a observação");
                txtObservacao.Focus();
            }
            else if (cmbStatus.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o status");
                cmbStatus.Focus();
            }
            else if (cmbHorario.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o horário");
                cmbHorario.Focus();
            }
            else if (cmbFuncionario.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o funcionário");
                cmbFuncionario.Focus();
            }
            else if (cmbCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o cliente");
                cmbCliente.Focus();
            }
            else if (cmbServico.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o serviço");
                cmbServico.Focus();
            }
            else
            {
                variaveis.obsReserva = txtObservacao.Text;
                variaveis.dataReserva = calReserva.SelectionStart;
                variaveis.horarioReserva = DateTime.Parse(cmbHorario.Text);
                variaveis.statusReserva = cmbStatus.Text;
                variaveis.codFuncionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
                variaveis.codCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                variaveis.codServico = Convert.ToInt32(cmbServico.SelectedValue);

                if (variaveis.funcao == "AGENDAR")
                {
                    InserirReserva();
                }
                else if (variaveis.funcao == "EDITAR")
                {
                    AlterarReserva();
                }
            }
        }
    }
}
