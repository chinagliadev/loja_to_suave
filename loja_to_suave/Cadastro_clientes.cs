using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_to_suave
{
    public partial class Cadastro_clientes : Form
    {
        public Cadastro_clientes()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private string LimparDocumento(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            return new string(texto.Where(char.IsDigit).ToArray());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text.Trim();
            string cpf = LimparDocumento(txtCpfCliente.Text);
            string email = txtEmailCliente.Text.Trim();
            string telefone = LimparDocumento(txtTelefoneCliente.Text);
            string endereco = txtEnderecoCliente.Text.Trim();
            string rua = txtRuaCliente.Text.Trim();
            string bairro = txtBairroCliente.Text.Trim();
            string numero = txtNumeroCliente.Text.Trim();

            string complemento = txtComplementoCliente.Text.Trim();
            string obs = txtObservacaoUsuario.Text.Trim();


            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo NOME é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("O campo CPF é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpfCliente.Focus();
                return;
            }

            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpfCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("O campo E-MAIL é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("O campo TELEFONE é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefoneCliente.Focus();
                return;
            }
            if (telefone.Length < 10)
            {
                MessageBox.Show("O Telefone deve conter DDD e pelo menos 8 ou 9 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefoneCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("O campo ENDEREÇO é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rua))
            {
                MessageBox.Show("O campo RUA é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuaCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(bairro))
            {
                MessageBox.Show("O campo BAIRRO é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairroCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("O campo NÚMERO é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroCliente.Focus();
                return;
            }

            cadastrarcliente(nome, cpf, email, telefone, endereco, rua, bairro, numero, complemento, obs);

        }

        public void cadastrarcliente(string nome, string cpf, string email, string telefone, string endereco, string rua, string bairro, string numero, string complemento = null, string obs = null)
        {
            string sqlInserirCliente = "INSERT INTO clientes (nome, cpf, email, telefone, endereco, rua, bairro, numero, complemento, observacao) " +
                                  "VALUES (@nome, @cpf, @email, @telefone, @endereco, @rua, @bairro, @numero, @complemento, @observacao)";
            Conexao conexao = new Conexao();
            try
            {
                using (var conn = conexao.AbrirConexao())
                {
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlInserirCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@rua", rua);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@complemento", complemento);
                        cmd.Parameters.AddWithValue("@observacao", obs);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCliente.Clear();
                txtCpfCliente.Clear();
                txtEmailCliente.Clear();
                txtTelefoneCliente.Clear();
                txtEnderecoCliente.Clear();
                txtRuaCliente.Clear();
                txtBairroCliente.Clear();
                txtNumeroCliente.Clear();
                txtComplementoCliente.Clear();
                txtObservacaoUsuario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
            this.Close();
        }
    }
}
