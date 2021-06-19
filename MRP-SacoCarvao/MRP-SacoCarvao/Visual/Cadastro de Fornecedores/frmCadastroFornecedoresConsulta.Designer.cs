namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    partial class frmCadastroFornecedoresConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedoresConsulta));
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.Corpo_pnl = new System.Windows.Forms.Panel();
            this.ListaComps_dgv = new System.Windows.Forms.DataGridView();
            this.BarraInf_pnl = new System.Windows.Forms.Panel();
            this.Editar_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.BarraSup_pnl = new System.Windows.Forms.Panel();
            this.ExcluirComp_btn = new System.Windows.Forms.Button();
            this.CadastrarComp_btn = new System.Windows.Forms.Button();
            this.AtualizarComp_btn = new System.Windows.Forms.Button();
            this.H1_lbl = new System.Windows.Forms.Label();
            this.Corpo_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaComps_dgv)).BeginInit();
            this.BarraInf_pnl.SuspendLayout();
            this.BarraSup_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(432, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspDir_pnl.TabIndex = 21;
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspEsq_pnl.TabIndex = 20;
            // 
            // Corpo_pnl
            // 
            this.Corpo_pnl.Controls.Add(this.ListaComps_dgv);
            this.Corpo_pnl.Controls.Add(this.BarraInf_pnl);
            this.Corpo_pnl.Controls.Add(this.BarraSup_pnl);
            this.Corpo_pnl.Controls.Add(this.H1_lbl);
            this.Corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo_pnl.Location = new System.Drawing.Point(32, 0);
            this.Corpo_pnl.Name = "Corpo_pnl";
            this.Corpo_pnl.Size = new System.Drawing.Size(400, 393);
            this.Corpo_pnl.TabIndex = 22;
            // 
            // ListaComps_dgv
            // 
            this.ListaComps_dgv.AllowUserToAddRows = false;
            this.ListaComps_dgv.AllowUserToDeleteRows = false;
            this.ListaComps_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ListaComps_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaComps_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaComps_dgv.Location = new System.Drawing.Point(0, 114);
            this.ListaComps_dgv.MultiSelect = false;
            this.ListaComps_dgv.Name = "ListaComps_dgv";
            this.ListaComps_dgv.ReadOnly = true;
            this.ListaComps_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaComps_dgv.Size = new System.Drawing.Size(400, 215);
            this.ListaComps_dgv.StandardTab = true;
            this.ListaComps_dgv.TabIndex = 2;
            this.ListaComps_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            this.ListaComps_dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RowEnter);
            // 
            // BarraInf_pnl
            // 
            this.BarraInf_pnl.Controls.Add(this.Editar_btn);
            this.BarraInf_pnl.Controls.Add(this.OK_btn);
            this.BarraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraInf_pnl.Location = new System.Drawing.Point(0, 329);
            this.BarraInf_pnl.Name = "BarraInf_pnl";
            this.BarraInf_pnl.Size = new System.Drawing.Size(400, 64);
            this.BarraInf_pnl.TabIndex = 3;
            // 
            // Editar_btn
            // 
            this.Editar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Editar_btn.Location = new System.Drawing.Point(3, 10);
            this.Editar_btn.Name = "Editar_btn";
            this.Editar_btn.Size = new System.Drawing.Size(208, 23);
            this.Editar_btn.TabIndex = 0;
            this.Editar_btn.Text = "Editar Informações do Fornecedor";
            this.Editar_btn.UseVisualStyleBackColor = true;
            this.Editar_btn.Click += new System.EventHandler(this.Editar_btn_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OK_btn.Location = new System.Drawing.Point(285, 10);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(112, 23);
            this.OK_btn.TabIndex = 1;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // BarraSup_pnl
            // 
            this.BarraSup_pnl.Controls.Add(this.ExcluirComp_btn);
            this.BarraSup_pnl.Controls.Add(this.CadastrarComp_btn);
            this.BarraSup_pnl.Controls.Add(this.AtualizarComp_btn);
            this.BarraSup_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSup_pnl.Location = new System.Drawing.Point(0, 66);
            this.BarraSup_pnl.Name = "BarraSup_pnl";
            this.BarraSup_pnl.Size = new System.Drawing.Size(400, 48);
            this.BarraSup_pnl.TabIndex = 1;
            // 
            // ExcluirComp_btn
            // 
            this.ExcluirComp_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExcluirComp_btn.Enabled = false;
            this.ExcluirComp_btn.Location = new System.Drawing.Point(301, 15);
            this.ExcluirComp_btn.Name = "ExcluirComp_btn";
            this.ExcluirComp_btn.Size = new System.Drawing.Size(96, 24);
            this.ExcluirComp_btn.TabIndex = 2;
            this.ExcluirComp_btn.Text = "Excluir";
            this.ExcluirComp_btn.UseVisualStyleBackColor = true;
            this.ExcluirComp_btn.Click += new System.EventHandler(this.Excluir_btn_Click);
            // 
            // CadastrarComp_btn
            // 
            this.CadastrarComp_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CadastrarComp_btn.Location = new System.Drawing.Point(3, 15);
            this.CadastrarComp_btn.Name = "CadastrarComp_btn";
            this.CadastrarComp_btn.Size = new System.Drawing.Size(144, 24);
            this.CadastrarComp_btn.TabIndex = 0;
            this.CadastrarComp_btn.Text = "Cadastrar Componente";
            this.CadastrarComp_btn.UseVisualStyleBackColor = true;
            this.CadastrarComp_btn.Click += new System.EventHandler(this.Cadastrar_btn_Click);
            // 
            // AtualizarComp_btn
            // 
            this.AtualizarComp_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AtualizarComp_btn.Enabled = false;
            this.AtualizarComp_btn.Location = new System.Drawing.Point(199, 15);
            this.AtualizarComp_btn.Name = "AtualizarComp_btn";
            this.AtualizarComp_btn.Size = new System.Drawing.Size(96, 24);
            this.AtualizarComp_btn.TabIndex = 1;
            this.AtualizarComp_btn.Text = "Atualizar";
            this.AtualizarComp_btn.UseVisualStyleBackColor = true;
            this.AtualizarComp_btn.Click += new System.EventHandler(this.Atualizar_btn_Click);
            // 
            // H1_lbl
            // 
            this.H1_lbl.AutoSize = true;
            this.H1_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1_lbl.Location = new System.Drawing.Point(0, 0);
            this.H1_lbl.Name = "H1_lbl";
            this.H1_lbl.Padding = new System.Windows.Forms.Padding(0, 24, 0, 16);
            this.H1_lbl.Size = new System.Drawing.Size(132, 66);
            this.H1_lbl.TabIndex = 0;
            this.H1_lbl.Text = "Fornecedor";
            // 
            // frmCadastroFornecedoresConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 393);
            this.Controls.Add(this.Corpo_pnl);
            this.Controls.Add(this.EspEsq_pnl);
            this.Controls.Add(this.EspDir_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(448, 39);
            this.Name = "frmCadastroFornecedoresConsulta";
            this.Text = "Editar fornecedor";
            this.Load += new System.EventHandler(this.FormCadastroFornecedoresConsulta_Load);
            this.SizeChanged += new System.EventHandler(this.FormCadastroFornecedoresConsulta_SizeChanged);
            this.Corpo_pnl.ResumeLayout(false);
            this.Corpo_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaComps_dgv)).EndInit();
            this.BarraInf_pnl.ResumeLayout(false);
            this.BarraSup_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Panel Corpo_pnl;
        private System.Windows.Forms.DataGridView ListaComps_dgv;
        private System.Windows.Forms.Panel BarraInf_pnl;
        private System.Windows.Forms.Button Editar_btn;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Panel BarraSup_pnl;
        private System.Windows.Forms.Button AtualizarComp_btn;
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.Button CadastrarComp_btn;
        private System.Windows.Forms.Button ExcluirComp_btn;
    }
}