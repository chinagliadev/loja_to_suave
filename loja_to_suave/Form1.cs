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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_clientes cadastro_Clientes = new Cadastro_clientes();
            cadastro_Clientes.Show();
            this.Hide();

        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
            this.Hide();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_produto cadastrar_Produto = new Cadastrar_produto();
            cadastrar_Produto.Show();
            this.Hide();
        }

        private void gerenciamentosDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciamento_Produtos gerenciamento_Produtos = new Gerenciamento_Produtos();
            gerenciamento_Produtos.Show();
            this.Hide();
        }
    }
}
