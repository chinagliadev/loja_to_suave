using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_to_suave
{
    public partial class Fornecedores : Form
    {
        public int IdFornecedorSelecionado { get; private set; }
        public string NomeFornecedorSelecionado { get; private set; }
        public Fornecedores()
        {
        InitializeComponent();
        }

        private string LimparDocumento(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            return new string(texto.Where(char.IsDigit).ToArray());
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            string nome = txtContatoNomeFornecedor.Text.Trim();
            string cnpj = LimparDocumento(txtCpnjFornecedor.Text);
            string razao_social = txtRazaoSocial.Text.Trim();
            string email = txtEmailFornecedor.Text.Trim();
            string telefone = LimparDocumento(txtTelefoneFornecedor.Text);
            string endereco = txtEnderecoFornecedor.Text.Trim();
            string rua = txtRuaFornecedor.Text.Trim();
            string bairro = txtBairroFornecedor.Text.Trim();
            string numero = txtNumeroFornecedor.Text.Trim();
            string complemento = txtComplementoFornecedor.Text.Trim();
            string obs = txtObservacaoFornecedor.Text.Trim();


            if (string.IsNullOrWhiteSpace(razao_social) ||
                string.IsNullOrWhiteSpace(cnpj) ||
                string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(endereco) ||
                string.IsNullOrWhiteSpace(rua) ||
                string.IsNullOrWhiteSpace(bairro) ||
                string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[A-Za-zÀ-ÿ\s]+$"))
            {
                MessageBox.Show("O nome do contato não pode conter números ou caracteres especiais.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(razao_social, @"^[A-Za-zÀ-ÿ0-9\s\.,\-]+$"))
            {
                MessageBox.Show("A razão social contém caracteres inválidos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (telefone.Length < 10)
            {
                MessageBox.Show("Telefone inválido. Verifique o número informado.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            long id = cadastrarFornecedor(razao_social, cnpj, nome, email, telefone, endereco, rua, bairro, numero, complemento, obs);

            if (id > 0)
            {
                IdFornecedorSelecionado = (int)id; //
                NomeFornecedorSelecionado = razao_social; 
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        public long cadastrarFornecedor(string razao_social, string cnpj, string nome, string email, string telefone, string endereco, string rua, string bairro, string numero, string complemento = null, string obs = null)
        {
            string sqlInserirFornecedor = @"INSERT INTO fornecedores 
        (razao_social, cnpj, contato_nome, telefone, email, endereco, rua, bairro, numero, complemento, observacao)
        VALUES (@razao_social, @cnpj, @nome_contato, @telefone, @email, @endereco, @rua, @bairro, @numero, @complemento, @obs)";

            Conexao conexao = new Conexao();
            long idFornecedor = 0;

            try
            {
                using (var conn = conexao.AbrirConexao())
                {
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlInserirFornecedor, conn))
                    {
                        cmd.Parameters.AddWithValue("@razao_social", razao_social);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@nome_contato", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@rua", rua);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@complemento", (object)complemento ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@obs", (object)obs ?? DBNull.Value);

                        cmd.ExecuteNonQuery();

                        idFornecedor = cmd.LastInsertedId;
                    }
                }

                return idFornecedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int BuscarIdFornecedor(string nomeFornecedor)
        {
            int idFornecedor = 0;
            string sql = "SELECT id_fornecedor FROM fornecedores WHERE razao_social = @nome LIMIT 1";

            Conexao conexao = new Conexao();

            try
            {
                using (var conn = conexao.AbrirConexao())
                {
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeFornecedor);
                        var resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                            idFornecedor = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + ex.Message);
            }

            return idFornecedor;
        }

    }
}
