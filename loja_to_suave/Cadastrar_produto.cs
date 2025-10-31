using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_to_suave
{
    public partial class Cadastrar_produto : Form
    {
        public Cadastrar_produto()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        // ======= BOTÕES DE NAVEGAÇÃO =======
        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_clientes cadastro_Clientes = new Cadastro_clientes();
            cadastro_Clientes.Show();
            this.Close();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores cadastro_Fornecedor = new Fornecedores();
            cadastro_Fornecedor.Show();
            this.Close();
        }

        // ======= BOTÃO CADASTRAR PRODUTO =======
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text.Trim();
            string descricaoProduto = txtDescricaoProduto.Text.Trim();
            string precoCustoStr = txtPrecoCustoProduto.Text.Trim();
            string precoVendaStr = txtPrecoVendaProduto.Text.Trim();
            string categoriaProduto = txtCategoriaProduto.Text.Trim();
            string caminhoImagemProduto = img_produto.Text.Trim();
            string quantidadeStr = txtQuantidade.Text.Trim();
            string codigo = txtCodigoProduto.Text.Trim();

            // Valida campos obrigatórios
            if (string.IsNullOrEmpty(nomeProduto) ||
                string.IsNullOrEmpty(descricaoProduto) ||
                string.IsNullOrEmpty(precoCustoStr) ||
                string.IsNullOrEmpty(precoVendaStr) ||
                string.IsNullOrEmpty(categoriaProduto) ||
                string.IsNullOrEmpty(caminhoImagemProduto) ||
                string.IsNullOrEmpty(quantidadeStr) ||
                string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida nome do produto
            if (!Regex.IsMatch(nomeProduto, @"^[A-Za-zÀ-ÿ\s]+$"))
            {
                MessageBox.Show("O nome do produto deve conter apenas letras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida preços
            if (!Regex.IsMatch(precoCustoStr, @"^[0-9]+([.,][0-9]{1,2})?$") ||
                !Regex.IsMatch(precoVendaStr, @"^[0-9]+([.,][0-9]{1,2})?$"))
            {
                MessageBox.Show("Os campos de preço devem conter apenas números (ex: 10,50 ou 10.50).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxFornecedores.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFornecedorSelecionado = (int)(comboBoxFornecedores.SelectedValue);
            string nomeFornecedorSelecionado = comboBoxFornecedores.Text;
            
            if (!Regex.IsMatch(quantidadeStr, @"^[0-9]+$"))
            {
                MessageBox.Show("A quantidade deve conter apenas números inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precoCustoProduto = Convert.ToDecimal(precoCustoStr.Replace(',', '.'));
            decimal precoVendaProduto = Convert.ToDecimal(precoVendaStr.Replace(',', '.'));
            int quantidadeProduto = Convert.ToInt32(quantidadeStr);

            if (precoVendaProduto < precoCustoProduto)
            {
                MessageBox.Show("O preço de venda não pode ser menor que o preço de custo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidadeProduto <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CadastrarProduto(
                idFornecedorSelecionado,
                nomeFornecedorSelecionado,
                codigo,
                nomeProduto,
                precoCustoProduto,
                precoVendaProduto,
                quantidadeProduto,
                descricaoProduto,
                categoriaProduto,
                caminhoImagemProduto
            );
        }

        public void CadastrarProduto(
            int idFornecedor,
            string nomeFornecedor,
            string codigoProduto,
            string nomeProduto,
            decimal precoCusto,
            decimal precoVenda,
            int qtdProduto,
            string descricao,
            string categoria,
            string caminhoArquivo)
        {
            string sqlInserirProduto = @"INSERT INTO produtos 
            (id_fornecedor, codigo ,nome_fornecedor, nome_produto, preco_custo, qtd_produto, preco_venda, descricao, categoria, caminho_arquivo)
            VALUES (@id_fornecedor, @codigo,@nome_fornecedor, @nome_produto, @preco_custo, @qtd_produto, @preco_venda, @descricao, @categoria, @caminho_arquivo)";

            Conexao conexao = new Conexao();
            try
            {
                using (var conn = conexao.AbrirConexao())
                {
                    using (var cmd = new MySqlCommand(sqlInserirProduto, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_fornecedor", idFornecedor);
                        cmd.Parameters.AddWithValue("@nome_fornecedor", nomeFornecedor);
                        cmd.Parameters.AddWithValue("@codigo", codigoProduto);
                        cmd.Parameters.AddWithValue("@nome_produto", nomeProduto);
                        cmd.Parameters.AddWithValue("@preco_custo", precoCusto);
                        cmd.Parameters.AddWithValue("@qtd_produto", qtdProduto);
                        cmd.Parameters.AddWithValue("@preco_venda", precoVenda);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@caminho_arquivo", caminhoArquivo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtNomeProduto.Clear();
                txtPrecoCustoProduto.Clear();
                txtPrecoVendaProduto.Clear();
                txtQuantidade.Clear();
                txtDescricaoProduto.Clear();
                txtCategoriaProduto.Clear();
                txtCodigoProduto.Clear();
                img_produto.Text = string.Empty;
                comboBoxFornecedores.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarFornecedores()
        {
            string sql = "SELECT id_fornecedor, razao_social FROM fornecedores ORDER BY razao_social";

            Conexao conexao = new Conexao();

            try
            {
                using (var conn = conexao.AbrirConexao())
                {
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            comboBoxFornecedores.DataSource = dt;
                            comboBoxFornecedores.DisplayMember = "razao_social";
                            comboBoxFornecedores.ValueMember = "id_fornecedor";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFornecedores.SelectedItem == null || comboBoxFornecedores.SelectedValue == null)
                return;

            try
            {
                int idFornecedorSelecionado;

                if (comboBoxFornecedores.SelectedValue is DataRowView drv)
                {
                    idFornecedorSelecionado = Convert.ToInt32(drv["id_fornecedor"]);
                }
                else
                {
                    idFornecedorSelecionado = Convert.ToInt32(comboBoxFornecedores.SelectedValue);
                }

                string nomeFornecedorSelecionado = comboBoxFornecedores.Text;
                Console.WriteLine($"Fornecedor: {nomeFornecedorSelecionado}, ID: {idFornecedorSelecionado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter fornecedor selecionado: " + ex.Message);
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma imagem do produto";
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        img_produto.Image = Image.FromFile(ofd.FileName);

                        img_produto.Text = ofd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void img_produto_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecoCustoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoriaProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelObs_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
