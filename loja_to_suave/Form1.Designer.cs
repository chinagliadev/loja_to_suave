namespace loja_to_suave
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentosDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1585, 33);
            this.menuStrip1.TabIndex = 0;
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
            this.cadastroProdutoToolStripMenuItem,
            this.gerenciamentosDeProdutosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroClienteToolStripMenuItem.Image")));
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroFornecedorToolStripMenuItem.Image")));
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            this.cadastroProdutoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroProdutoToolStripMenuItem.Image")));
            this.cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            this.cadastroProdutoToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.cadastroProdutoToolStripMenuItem.Text = "Cadastro Produto";
            this.cadastroProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutoToolStripMenuItem_Click);
            // 
            // gerenciamentosDeProdutosToolStripMenuItem
            // 
            this.gerenciamentosDeProdutosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerenciamentosDeProdutosToolStripMenuItem.Image")));
            this.gerenciamentosDeProdutosToolStripMenuItem.Name = "gerenciamentosDeProdutosToolStripMenuItem";
            this.gerenciamentosDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.gerenciamentosDeProdutosToolStripMenuItem.Text = "Gerenciamentos Loja";
            this.gerenciamentosDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentosDeProdutosToolStripMenuItem_Click);
            // 
            // historicoDeCompraToolStripMenuItem
            // 
            this.historicoDeCompraToolStripMenuItem.Name = "historicoDeCompraToolStripMenuItem";
            this.historicoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.historicoDeCompraToolStripMenuItem.Text = "Historico de Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 866);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 827);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeCompraToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentosDeProdutosToolStripMenuItem;
    }
}

