using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16Joyce
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void CarregarClienteTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente. \n\n"+erro.Message);
            }
        }

        private void CarregarClienteAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente. \n\n" + erro.Message);
            }
        }

        private void CarregarClienteInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente. \n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresatelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente. \n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaAtiva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a empresa ativa. \n\n" + erro.Message);
            }
        }

        private void CarregarEmpresaInativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresainativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar a empresa inativa. \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioTelefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariotelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o funcionario telefone. \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioAtivo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o funcionario ativo. \n\n" + erro.Message);
            }
        }

        private void CarregarFuncionarioInativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRelatorio.DataSource = dt;
                dgvRelatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o funcionario  inativo. \n\n" + erro.Message);
            }
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            pnlRelatorio.Location = new Point(this.Width / 2 - pnlRelatorio.Width / 2, this.Height / 2 - pnlRelatorio.Height / 2);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked == true && radAtivo.Checked == true)
            {
                CarregarClienteAtivo();
                variaveis.relatorio = "Cliente Ativo";
            }
            else if(radCliente.Checked == true && radInativo.Checked == true)
            {
                CarregarClienteInativo();
                variaveis.relatorio = "Cliente Inativo";
            }
            else if (radCliente.Checked == true && radTelefone.Checked == true)
            {
                CarregarClienteTelefone();
                variaveis.relatorio = "Cliente Telefone";
            }
            else if (radFuncionario.Checked == true && radAtivo.Checked == true)
            {
                CarregarFuncionarioAtivo();
                variaveis.relatorio = "Funcionário Ativo";
            }
            else if (radFuncionario.Checked == true && radInativo.Checked == true)
            {
                CarregarFuncionarioInativo();
                variaveis.relatorio = "Funcionário Inativo";
            }
            else if (radFuncionario.Checked == true && radTelefone.Checked == true)
            {
                CarregarFuncionarioTelefone();
                variaveis.relatorio = "Funcionário Telefone";
            }
            else if (radEmpresa.Checked == true && radAtivo.Checked == true)
            {
                CarregarEmpresaAtiva();
                variaveis.relatorio = "Empresa Ativo";
            }
            else if (radEmpresa.Checked == true && radInativo.Checked == true)
            {
                CarregarEmpresaInativa();
                variaveis.relatorio = "Empresa Inativo";
            }
            else if (radEmpresa.Checked == true && radTelefone.Checked == true)
            {
                CarregarEmpresaTelefone();
                variaveis.relatorio = "Empresa Telefone";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog(); //caixa de salvamento
                salvar.Filter = "PDF (*.pdf)|*.pdf"; //filtro em pdf
                salvar.InitialDirectory = @"C:\xampp\htdocs\kibelezati16\admin";
                salvar.FileName = variaveis.relatorio + ".pdf"; //nome do arquivo
                bool fileError = false; //erro de arquivo inicia em falso
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName); //deleta arquivo
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Não foi possível gravar os dados no disco" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvRelatorio.Columns.Count);//gerar tabela em pdf
                            pdfTable.DefaultCell.Padding = 3; //margin interna  na celula 3px
                            pdfTable.WidthPercentage = 100; //largura 100%
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; //alinhamento a esquerda

                            foreach (DataGridViewColumn column in dgvRelatorio.Columns) //gerar titulos
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvRelatorio.Rows) //inserir valores
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using(FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f); //estrutura
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph titulo = new Paragraph();
                                titulo.Add("RELATÓRIO " + variaveis.relatorio + "\n\n");
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("DADOS EXPORTADOS COM SUCESSO!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: ", ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("EXPORTAÇÃO NÃO SALVA", "Info");
            }
        }
    }
}
