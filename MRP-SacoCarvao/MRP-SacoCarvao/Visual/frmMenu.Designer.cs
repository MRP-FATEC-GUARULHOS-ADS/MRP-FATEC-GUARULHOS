namespace MRP_SacoCarvao
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuMRP = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosFinaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estruturaDeProdutosFinaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMinEMáxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMaxEMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMRP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMRP
            // 
            this.menuMRP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.controleDeUsuáriosToolStripMenuItem});
            this.menuMRP.Location = new System.Drawing.Point(0, 0);
            this.menuMRP.MdiWindowListItem = this.produtosFinaisToolStripMenuItem;
            this.menuMRP.Name = "menuMRP";
            this.menuMRP.Size = new System.Drawing.Size(803, 24);
            this.menuMRP.TabIndex = 0;
            this.menuMRP.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.CheckOnClick = true;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosFinaisToolStripMenuItem,
            this.componentesToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.estruturaDeProdutosFinaisToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosFinaisToolStripMenuItem
            // 
            this.produtosFinaisToolStripMenuItem.Name = "produtosFinaisToolStripMenuItem";
            this.produtosFinaisToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.produtosFinaisToolStripMenuItem.Text = "Produtos Finais";
            this.produtosFinaisToolStripMenuItem.Click += new System.EventHandler(this.ProdutosFinaisToolStripMenuItem_Click);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.ComponentesToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.GruposToolStripMenuItem_Click);
            // 
            // estruturaDeProdutosFinaisToolStripMenuItem
            // 
            this.estruturaDeProdutosFinaisToolStripMenuItem.Name = "estruturaDeProdutosFinaisToolStripMenuItem";
            this.estruturaDeProdutosFinaisToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.estruturaDeProdutosFinaisToolStripMenuItem.Text = "Estrutura de Produtos Finais";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem1,
            this.produtosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // componentesToolStripMenuItem1
            // 
            this.componentesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueMinEMáxToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem1});
            this.componentesToolStripMenuItem1.Name = "componentesToolStripMenuItem1";
            this.componentesToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.componentesToolStripMenuItem1.Text = "Componentes";
            // 
            // estoqueMinEMáxToolStripMenuItem
            // 
            this.estoqueMinEMáxToolStripMenuItem.Name = "estoqueMinEMáxToolStripMenuItem";
            this.estoqueMinEMáxToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.estoqueMinEMáxToolStripMenuItem.Text = "Estoque Min. e Máx.";
            // 
            // movimentaçãoToolStripMenuItem1
            // 
            this.movimentaçãoToolStripMenuItem1.Name = "movimentaçãoToolStripMenuItem1";
            this.movimentaçãoToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.movimentaçãoToolStripMenuItem1.Text = "Movimentação";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueMaxEMinToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // estoqueMaxEMinToolStripMenuItem
            // 
            this.estoqueMaxEMinToolStripMenuItem.Name = "estoqueMaxEMinToolStripMenuItem";
            this.estoqueMaxEMinToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.estoqueMaxEMinToolStripMenuItem.Text = "Estoque Min. e Máx.";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // controleDeUsuáriosToolStripMenuItem
            // 
            this.controleDeUsuáriosToolStripMenuItem.Name = "controleDeUsuáriosToolStripMenuItem";
            this.controleDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.controleDeUsuáriosToolStripMenuItem.Text = "Controle de Usuários";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 468);
            this.Controls.Add(this.menuMRP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMRP;
            this.MinimumSize = new System.Drawing.Size(464, 336);
            this.Name = "frmMenu";
            this.Text = "MRP - Saco de Carvão";
            this.menuMRP.ResumeLayout(false);
            this.menuMRP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMRP;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosFinaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estruturaDeProdutosFinaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueMaxEMinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueMinEMáxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
    }
}

