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

namespace loja_to_suave
{
    public partial class Gerenciamento_Produtos : Form
    {
        public Gerenciamento_Produtos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoVendaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoCustoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoriaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProdutoGerenciamento.Text.Trim();
            buscarProdutos(codigo);
        }


        private void buscarProdutos(string codigo)
        {
            string sqlBuscar = "SELECT * FROM produtos WHERE codigo LIKE @codigo";

            Conexao conexao = new Conexao();

            using (var connection = conexao.AbrirConexao())
            {
                using (var command = new MySql.Data.MySqlClient.MySqlCommand(sqlBuscar, connection))
                {
                    command.Parameters.AddWithValue("@codigo", "%" + codigo + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int idProduto = reader.GetInt32("id_produto");
                                string nomeProduto = reader.GetString("nome_produto");
                                int qtd_produto = reader.GetInt32("qtd_produto");
                                string cod = reader.GetString("codigo");
                                decimal preco = reader.GetDecimal("preco_venda");
                                decimal preco_custo = reader.GetDecimal("preco_custo");
                                string descricao = reader.GetString("descricao");
                                string caminhoImagem = reader.GetString("caminho_arquivo");

                                txtNomeProdutoGerenciamento.Text = nomeProduto;
                                txtPrecoVendaProdutoGerenciamento.Text = preco.ToString("F2");
                                txtCategoriaProdutoGerenciamento.Text = reader.GetString("categoria");
                                txtPrecoCustoProdutoGerenciamento.Text = preco_custo.ToString("F2");
                                txtDescricaoProdutoGerenciamento.Text = descricao;
                                txtQuantidadeGerenciamento.Text = qtd_produto.ToString();

                                if (!string.IsNullOrEmpty(caminhoImagem) && File.Exists(caminhoImagem))
                                {
                                    img_produtoGerenciamento.ImageLocation = caminhoImagem;
                                }
                                else
                                {
                                    img_produtoGerenciamento.Image = null;
                                    MessageBox.Show("Imagem não encontrada no caminho informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum produto encontrado com esse código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private string LimparDocumento(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";
            return new string(texto.Where(char.IsDigit).ToArray());
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = LimparDocumento(txtCpfClienteGerenciamento.Text);
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Por favor, insira um nome ou CPF para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            buscarCliente(cpf);
        }


        private void buscarCliente(string nomeOuCpf)
        {
            string sqlBuscar = "SELECT * FROM clientes WHERE nome LIKE @busca OR cpf LIKE @busca";

            Conexao conexao = new Conexao();

            using (var connection = conexao.AbrirConexao())
            {
                using (var command = new MySqlCommand(sqlBuscar, connection))
                {
                    command.Parameters.AddWithValue("@busca", "%" + nomeOuCpf + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int idCliente = reader.GetInt32("id_cliente");
                                string nome = reader.GetString("nome");
                                string cpf = reader.IsDBNull(reader.GetOrdinal("cpf")) ? "" : reader.GetString("cpf");
                                string email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString("email");
                                string telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? "" : reader.GetString("telefone");
                                string endereco = reader.IsDBNull(reader.GetOrdinal("endereco")) ? "" : reader.GetString("endereco");
                                string bairro = reader.IsDBNull(reader.GetOrdinal("bairro")) ? "" : reader.GetString("bairro");
                                string rua = reader.IsDBNull(reader.GetOrdinal("rua")) ? "" : reader.GetString("rua");
                                int numero = reader.IsDBNull(reader.GetOrdinal("numero")) ? 0 : reader.GetInt32("numero");
                                string complemento = reader.IsDBNull(reader.GetOrdinal("complemento")) ? "" : reader.GetString("complemento");
                                string observacao = reader.IsDBNull(reader.GetOrdinal("observacao")) ? "" : reader.GetString("observacao");

                                txtNomeClienteGerenciamento.Text = nome;
                                txtCpfClienteGerenciamento.Text = cpf;
                                txtEmailClienteGerenciamento.Text = email;
                                txtTelefoneClienteGerenciamento.Text = telefone;
                                txtEnderecoClienteGerenciamento.Text = endereco;
                                txtBairroClienteGerenciamento.Text = bairro;
                                txtRuaClienteGerenciamento.Text = rua;
                                txtNumeroClienteGerenciamento.Text = numero.ToString();
                                txtComplementoClienteGerenciamento.Text = complemento;
                                txtObservacaoUsuarioGerenciamento.Text = observacao;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtCpnjFornecedorGerenciamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            string cnpj = LimparDocumento(txtCpnjFornecedorGerenciamento.Text);
            if (string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("Por favor, insira um nome ou CNPJ para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            buscarFornecedorPorCnpj(cnpj);
        }


        private void buscarFornecedorPorCnpj(string cnpj)
        {
            string sqlBuscar = "SELECT * FROM fornecedores WHERE cnpj = @cnpj"; // busca exata

            Conexao conexao = new Conexao();
            using (var connection = conexao.AbrirConexao())
            {
                using (var command = new MySqlCommand(sqlBuscar, connection))
                {
                    command.Parameters.AddWithValue("@cnpj", cnpj);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int idFornecedor = reader.GetInt32("id_fornecedor");
                                string razaoSocial = reader.GetString("razao_social");
                                string cnpjFornecedor = reader.IsDBNull(reader.GetOrdinal("cnpj")) ? "" : reader.GetString("cnpj");
                                string contatoNome = reader.IsDBNull(reader.GetOrdinal("contato_nome")) ? "" : reader.GetString("contato_nome");
                                string telefone = reader.IsDBNull(reader.GetOrdinal("telefone")) ? "" : reader.GetString("telefone");
                                string email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString("email");
                                string endereco = reader.IsDBNull(reader.GetOrdinal("endereco")) ? "" : reader.GetString("endereco");
                                string rua = reader.IsDBNull(reader.GetOrdinal("rua")) ? "" : reader.GetString("rua");
                                string bairro = reader.IsDBNull(reader.GetOrdinal("bairro")) ? "" : reader.GetString("bairro");
                                int numero = reader.IsDBNull(reader.GetOrdinal("numero")) ? 0 : reader.GetInt32("numero");
                                string complemento = reader.IsDBNull(reader.GetOrdinal("complemento")) ? "" : reader.GetString("complemento");
                                string observacao = reader.IsDBNull(reader.GetOrdinal("observacao")) ? "" : reader.GetString("observacao");

                                // Preenche os campos na interface
                                txtRazaoSocialGerenciamento.Text = razaoSocial;
                                txtCpnjFornecedorGerenciamento.Text = cnpjFornecedor;
                                txtContatoNomeFornecedorGerenciamento.Text = contatoNome;
                                txtTelefoneFornecedorGerenciamento.Text = telefone;
                                txtEmailFornecedorGerenciamento.Text = email;
                                txtEnderecoFornecedorGerenciamento.Text = endereco;
                                txtRuaFornecedorGerenciamento.Text = rua;
                                txtBairroFornecedorGerenciamento.Text = bairro;
                                txtNumeroFornecedorGerenciamento.Text = numero.ToString();
                                txtComplementoFornecedorGerenciamento.Text = complemento;
                                txtObservacaoFornecedorGerenciamento.Text = observacao;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum fornecedor encontrado com esse CNPJ.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}


