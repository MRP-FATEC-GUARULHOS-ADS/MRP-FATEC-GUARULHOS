namespace MRP_SacoCarvao.Compras
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.ListaCompras_dgv = new System.Windows.Forms.DataGridView();
            this.Pesquisar_lbl = new System.Windows.Forms.Label();
            this.Fornecedores_btn = new System.Windows.Forms.Button();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.Corpo_pnl = new System.Windows.Forms.Panel();
            this.BarraInf_pnl = new System.Windows.Forms.Panel();
            this.Visualizar_btn = new System.Windows.Forms.Button();
            this.Estoque_btn = new System.Windows.Forms.Button();
            this.BarraSup_pnl = new System.Windows.Forms.Panel();
            this.Pesquisar_pnl = new System.Windows.Forms.Panel();
            this.BarraPesquisa_pnl = new System.Windows.Forms.Panel();
            this.Pesquisar_tbx = new System.Windows.Forms.TextBox();
            this.Pesquisar_btn = new System.Windows.Forms.Button();
            this.Registrar_pnl = new System.Windows.Forms.Panel();
            this.Registrar_btn = new System.Windows.Forms.Button();
            this.H1_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCompras_dgv)).BeginInit();
            this.Corpo_pnl.SuspendLayout();
            this.BarraInf_pnl.SuspendLayout();
            this.BarraSup_pnl.SuspendLayout();
            this.Pesquisar_pnl.SuspendLayout();
            this.BarraPesquisa_pnl.SuspendLayout();
            this.Registrar_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaCompras_dgv
            // 
            this.ListaCompras_dgv.AllowUserToAddRows = false;
            this.ListaCompras_dgv.AllowUserToDeleteRows = false;
            this.ListaCompras_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ListaCompras_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCompras_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaCompras_dgv.Location = new System.Drawing.Point(0, 114);
            this.ListaCompras_dgv.MultiSelect = false;
            this.ListaCompras_dgv.Name = "ListaCompras_dgv";
            this.ListaCompras_dgv.ReadOnly = true;
            this.ListaCompras_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaCompras_dgv.Size = new System.Drawing.Size(544, 244);
            this.ListaCompras_dgv.StandardTab = true;
            this.ListaCompras_dgv.TabIndex = 2;
            this.ListaCompras_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaCompras_dgv_CellDoubleClick);
            this.ListaCompras_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RowEnter);
            this.ListaCompras_dgv.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RowLeave);
            // 
            // Pesquisar_lbl
            // 
            this.Pesquisar_lbl.AutoSize = true;
            this.Pesquisar_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pesquisar_lbl.Location = new System.Drawing.Point(12, 0);
            this.Pesquisar_lbl.Name = "Pesquisar_lbl";
            this.Pesquisar_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Pesquisar_lbl.Size = new System.Drawing.Size(53, 17);
            this.Pesquisar_lbl.TabIndex = 0;
            this.Pesquisar_lbl.Text = "Pesquisar";
            // 
            // Fornecedores_btn
            // 
            this.Fornecedores_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Fornecedores_btn.Location = new System.Drawing.Point(429, 10);
            this.Fornecedores_btn.Name = "Fornecedores_btn";
            this.Fornecedores_btn.Size = new System.Drawing.Size(112, 23);
            this.Fornecedores_btn.TabIndex = 2;
            this.Fornecedores_btn.Text = "Fornecedores";
            this.Fornecedores_btn.UseVisualStyleBackColor = true;
            this.Fornecedores_btn.Click += new System.EventHandler(this.Fornecedores_btn_Click);
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(48, 422);
            this.EspEsq_pnl.TabIndex = 1;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(592, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(48, 422);
            this.EspDir_pnl.TabIndex = 2;
            // 
            // Corpo_pnl
            // 
            this.Corpo_pnl.Controls.Add(this.ListaCompras_dgv);
            this.Corpo_pnl.Controls.Add(this.BarraInf_pnl);
            this.Corpo_pnl.Controls.Add(this.BarraSup_pnl);
            this.Corpo_pnl.Controls.Add(this.H1_lbl);
            this.Corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo_pnl.Location = new System.Drawing.Point(48, 0);
            this.Corpo_pnl.Name = "Corpo_pnl";
            this.Corpo_pnl.Size = new System.Drawing.Size(544, 422);
            this.Corpo_pnl.TabIndex = 0;
            // 
            // BarraInf_pnl
            // 
            this.BarraInf_pnl.Controls.Add(this.Visualizar_btn);
            this.BarraInf_pnl.Controls.Add(this.Estoque_btn);
            this.BarraInf_pnl.Controls.Add(this.Fornecedores_btn);
            this.BarraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraInf_pnl.Location = new System.Drawing.Point(0, 358);
            this.BarraInf_pnl.Name = "BarraInf_pnl";
            this.BarraInf_pnl.Size = new System.Drawing.Size(544, 64);
            this.BarraInf_pnl.TabIndex = 3;
            // 
            // Visualizar_btn
            // 
            this.Visualizar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Visualizar_btn.Enabled = false;
            this.Visualizar_btn.Location = new System.Drawing.Point(3, 10);
            this.Visualizar_btn.Name = "Visualizar_btn";
            this.Visualizar_btn.Size = new System.Drawing.Size(112, 23);
            this.Visualizar_btn.TabIndex = 0;
            this.Visualizar_btn.Text = "Visualizar";
            this.Visualizar_btn.UseVisualStyleBackColor = true;
            this.Visualizar_btn.Click += new System.EventHandler(this.Visualizar_btn_Click);
            // 
            // Estoque_btn
            // 
            this.Estoque_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Estoque_btn.Location = new System.Drawing.Point(311, 10);
            this.Estoque_btn.Name = "Estoque_btn";
            this.Estoque_btn.Size = new System.Drawing.Size(112, 23);
            this.Estoque_btn.TabIndex = 1;
            this.Estoque_btn.Text = "Estoque";
            this.Estoque_btn.UseVisualStyleBackColor = true;
            this.Estoque_btn.Click += new System.EventHandler(this.Estoque_btn_Click);
            // 
            // BarraSup_pnl
            // 
            this.BarraSup_pnl.Controls.Add(this.Pesquisar_pnl);
            this.BarraSup_pnl.Controls.Add(this.Registrar_pnl);
            this.BarraSup_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSup_pnl.Location = new System.Drawing.Point(0, 66);
            this.BarraSup_pnl.Name = "BarraSup_pnl";
            this.BarraSup_pnl.Size = new System.Drawing.Size(544, 48);
            this.BarraSup_pnl.TabIndex = 1;
            // 
            // Pesquisar_pnl
            // 
            this.Pesquisar_pnl.Controls.Add(this.BarraPesquisa_pnl);
            this.Pesquisar_pnl.Controls.Add(this.Pesquisar_lbl);
            this.Pesquisar_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pesquisar_pnl.Location = new System.Drawing.Point(150, 0);
            this.Pesquisar_pnl.Name = "Pesquisar_pnl";
            this.Pesquisar_pnl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Pesquisar_pnl.Size = new System.Drawing.Size(394, 48);
            this.Pesquisar_pnl.TabIndex = 1;
            // 
            // BarraPesquisa_pnl
            // 
            this.BarraPesquisa_pnl.Controls.Add(this.Pesquisar_tbx);
            this.BarraPesquisa_pnl.Controls.Add(this.Pesquisar_btn);
            this.BarraPesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraPesquisa_pnl.Location = new System.Drawing.Point(12, 17);
            this.BarraPesquisa_pnl.Name = "BarraPesquisa_pnl";
            this.BarraPesquisa_pnl.Size = new System.Drawing.Size(382, 20);
            this.BarraPesquisa_pnl.TabIndex = 1;
            // 
            // Pesquisar_tbx
            // 
            this.Pesquisar_tbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pesquisar_tbx.Location = new System.Drawing.Point(0, 0);
            this.Pesquisar_tbx.Name = "Pesquisar_tbx";
            this.Pesquisar_tbx.Size = new System.Drawing.Size(350, 20);
            this.Pesquisar_tbx.TabIndex = 0;
            this.Pesquisar_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pesquisar_tbx_KeyDown);
            // 
            // Pesquisar_btn
            // 
            this.Pesquisar_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pesquisar_btn.Location = new System.Drawing.Point(350, 0);
            this.Pesquisar_btn.Name = "Pesquisar_btn";
            this.Pesquisar_btn.Size = new System.Drawing.Size(32, 20);
            this.Pesquisar_btn.TabIndex = 1;
            this.Pesquisar_btn.Text = "👁";
            this.Pesquisar_btn.UseVisualStyleBackColor = true;
            this.Pesquisar_btn.Click += new System.EventHandler(this.Pesquisar_btn_Click);
            // 
            // Registrar_pnl
            // 
            this.Registrar_pnl.Controls.Add(this.Registrar_btn);
            this.Registrar_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Registrar_pnl.Location = new System.Drawing.Point(0, 0);
            this.Registrar_pnl.Name = "Registrar_pnl";
            this.Registrar_pnl.Size = new System.Drawing.Size(150, 48);
            this.Registrar_pnl.TabIndex = 0;
            // 
            // Registrar_btn
            // 
            this.Registrar_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registrar_btn.Location = new System.Drawing.Point(3, 15);
            this.Registrar_btn.Name = "Registrar_btn";
            this.Registrar_btn.Size = new System.Drawing.Size(144, 24);
            this.Registrar_btn.TabIndex = 0;
            this.Registrar_btn.Text = "Registrar Compra";
            this.Registrar_btn.UseVisualStyleBackColor = true;
            this.Registrar_btn.Click += new System.EventHandler(this.Registrar_btn_Click);
            // 
            // H1_lbl
            // 
            this.H1_lbl.AutoSize = true;
            this.H1_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1_lbl.Location = new System.Drawing.Point(0, 0);
            this.H1_lbl.Name = "H1_lbl";
            this.H1_lbl.Padding = new System.Windows.Forms.Padding(0, 24, 0, 16);
            this.H1_lbl.Size = new System.Drawing.Size(108, 66);
            this.H1_lbl.TabIndex = 0;
            this.H1_lbl.Text = "Compras";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.Corpo_pnl);
            this.Controls.Add(this.EspDir_pnl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(448, 320);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.SizeChanged += new System.EventHandler(this.frmCompras_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ListaCompras_dgv)).EndInit();
            this.Corpo_pnl.ResumeLayout(false);
            this.Corpo_pnl.PerformLayout();
            this.BarraInf_pnl.ResumeLayout(false);
            this.BarraSup_pnl.ResumeLayout(false);
            this.Pesquisar_pnl.ResumeLayout(false);
            this.Pesquisar_pnl.PerformLayout();
            this.BarraPesquisa_pnl.ResumeLayout(false);
            this.BarraPesquisa_pnl.PerformLayout();
            this.Registrar_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaCompras_dgv;
        private System.Windows.Forms.Label Pesquisar_lbl;
        private System.Windows.Forms.Button Fornecedores_btn;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel Corpo_pnl;
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.Panel BarraInf_pnl;
        private System.Windows.Forms.Button Estoque_btn;
        private System.Windows.Forms.Panel BarraSup_pnl;
        private System.Windows.Forms.Panel Pesquisar_pnl;
        private System.Windows.Forms.Panel Registrar_pnl;
        private System.Windows.Forms.Button Registrar_btn;
        private System.Windows.Forms.Panel BarraPesquisa_pnl;
        private System.Windows.Forms.TextBox Pesquisar_tbx;
        private System.Windows.Forms.Button Pesquisar_btn;
        private System.Windows.Forms.Button Visualizar_btn;
    }
}
