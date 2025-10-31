namespace loja_to_suave
{
    partial class Cadastrar_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_produto));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCadastrarProduto = new System.Windows.Forms.ToolStripButton();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPrecoVendaProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoriaProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecoCustoProduto = new System.Windows.Forms.TextBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.img_produto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.comboBoxFornecedores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Salvar Produto";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnCadastrarProduto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 57);
            this.toolStrip1.TabIndex = 80;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastrarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProduto.Image")));
            this.btnCadastrarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(54, 54);
            this.btnCadastrarProduto.Text = "toolStripButton1";
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(17, 553);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(821, 198);
            this.txtDescricaoProduto.TabIndex = 77;
            this.txtDescricaoProduto.TextChanged += new System.EventHandler(this.txtDescricaoProduto_TextChanged);
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObs.Location = new System.Drawing.Point(14, 513);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(119, 24);
            this.labelObs.TabIndex = 76;
            this.labelObs.Text = "DESCRIÇÃO";
            this.labelObs.Click += new System.EventHandler(this.labelObs_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(15, 192);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(396, 31);
            this.txtNomeProduto.TabIndex = 65;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "PREÇO DE CUSTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "NOME DO PRODUTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.historicoDeCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 33);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroClienteToolStripMenuItem,
            this.cadastroFornecedorToolStripMenuItem,
            this.cadastroProdutoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroClienteToolStripMenuItem.Image")));
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroFornecedorToolStripMenuItem.Image")));
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            this.cadastroProdutoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroProdutoToolStripMenuItem.Image")));
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            // 
            // historicoDeCompraToolStripMenuItem
            // 
            this.historicoDeCompraToolStripMenuItem.Name = "historicoDeCompraToolStripMenuItem";
            this.historicoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.historicoDeCompraToolStripMenuItem.Text = "Historico de Compra";
            // 
            // txtPrecoVendaProduto
            // 
            this.txtPrecoVendaProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoVendaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVendaProduto.Location = new System.Drawing.Point(442, 276);
            this.txtPrecoVendaProduto.Name = "txtPrecoVendaProduto";
            this.txtPrecoVendaProduto.Size = new System.Drawing.Size(394, 31);
            this.txtPrecoVendaProduto.TabIndex = 85;
            this.txtPrecoVendaProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 84;
            this.label4.Text = "PREÇO DE VENDA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaProduto.Location = new System.Drawing.Point(15, 355);
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(396, 31);
            this.txtCategoriaProduto.TabIndex = 86;
            this.txtCategoriaProduto.TextChanged += new System.EventHandler(this.txtCategoriaProduto_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 87;
            this.label11.Text = "CATEGORIA";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtPrecoCustoProduto
            // 
            this.txtPrecoCustoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoCustoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCustoProduto.Location = new System.Drawing.Point(17, 276);
            this.txtPrecoCustoProduto.Name = "txtPrecoCustoProduto";
            this.txtPrecoCustoProduto.Size = new System.Drawing.Size(394, 31);
            this.txtPrecoCustoProduto.TabIndex = 88;
            this.txtPrecoCustoProduto.TextChanged += new System.EventHandler(this.txtPrecoCustoProduto_TextChanged);
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.BackColor = System.Drawing.Color.Gold;
            this.btnCarregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarregarFoto.Location = new System.Drawing.Point(1048, 447);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(386, 43);
            this.btnCarregarFoto.TabIndex = 89;
            this.btnCarregarFoto.Text = "CARREGAR FOTO";
            this.btnCarregarFoto.UseVisualStyleBackColor = false;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // img_produto
            // 
            this.img_produto.Location = new System.Drawing.Point(1048, 192);
            this.img_produto.Name = "img_produto";
            this.img_produto.Size = new System.Drawing.Size(386, 234);
            this.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_produto.TabIndex = 90;
            this.img_produto.TabStop = false;
            this.img_produto.Click += new System.EventHandler(this.img_produto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "QUANTIDADE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(440, 355);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(396, 31);
            this.txtQuantidade.TabIndex = 91;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // comboBoxFornecedores
            // 
            this.comboBoxFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFornecedores.FormattingEnabled = true;
            this.comboBoxFornecedores.Location = new System.Drawing.Point(16, 447);
            this.comboBoxFornecedores.Name = "comboBoxFornecedores";
            this.comboBoxFornecedores.Size = new System.Drawing.Size(393, 32);
            this.comboBoxFornecedores.TabIndex = 93;
            this.comboBoxFornecedores.SelectedIndexChanged += new System.EventHandler(this.comboBoxFornecedores_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 94;
            this.label6.Text = "FORNECEDOR";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(442, 192);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(396, 31);
            this.txtCodigoProduto.TabIndex = 95;
            this.txtCodigoProduto.TextChanged += new System.EventHandler(this.txtCodigoProduto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 24);
            this.label7.TabIndex = 96;
            this.label7.Text = "CODIGO PRODUTO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Cadastrar_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFornecedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.img_produto);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.txtPrecoCustoProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCategoriaProduto);
            this.Controls.Add(this.txtPrecoVendaProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Cadastrar_produto";
            this.Text = "Cadastrar_produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeCompraToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPrecoVendaProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoriaProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecoCustoProduto;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.PictureBox img_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox comboBoxFornecedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label7;
    }
}