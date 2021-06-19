namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    partial class frmCadastroFornecedoresConsultaUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedoresConsultaUpdate));
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.Corpo_pnl = new System.Windows.Forms.Panel();
            this.BarraInf_pnl = new System.Windows.Forms.Panel();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Preco_pnl = new System.Windows.Forms.Panel();
            this.Preco_tbx = new System.Windows.Forms.TextBox();
            this.Preco_lbl = new System.Windows.Forms.Label();
            this.Componente_pnl = new System.Windows.Forms.Panel();
            this.Componente_tbx = new System.Windows.Forms.TextBox();
            this.Componente_lbl = new System.Windows.Forms.Label();
            this.H1_lbl = new System.Windows.Forms.Label();
            this.Corpo_pnl.SuspendLayout();
            this.BarraInf_pnl.SuspendLayout();
            this.Preco_pnl.SuspendLayout();
            this.Componente_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 233);
            this.EspEsq_pnl.TabIndex = 20;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(304, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 233);
            this.EspDir_pnl.TabIndex = 21;
            // 
            // Corpo_pnl
            // 
            this.Corpo_pnl.AutoScroll = true;
            this.Corpo_pnl.AutoSize = true;
            this.Corpo_pnl.Controls.Add(this.BarraInf_pnl);
            this.Corpo_pnl.Controls.Add(this.Preco_pnl);
            this.Corpo_pnl.Controls.Add(this.Componente_pnl);
            this.Corpo_pnl.Controls.Add(this.H1_lbl);
            this.Corpo_pnl.Controls.Add(this.EspDir_pnl);
            this.Corpo_pnl.Controls.Add(this.EspEsq_pnl);
            this.Corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.Corpo_pnl.Name = "Corpo_pnl";
            this.Corpo_pnl.Size = new System.Drawing.Size(336, 233);
            this.Corpo_pnl.TabIndex = 0;
            // 
            // BarraInf_pnl
            // 
            this.BarraInf_pnl.Controls.Add(this.Cancelar_btn);
            this.BarraInf_pnl.Controls.Add(this.OK_btn);
            this.BarraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraInf_pnl.Location = new System.Drawing.Point(32, 185);
            this.BarraInf_pnl.Name = "BarraInf_pnl";
            this.BarraInf_pnl.Size = new System.Drawing.Size(272, 48);
            this.BarraInf_pnl.TabIndex = 7;
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cancelar_btn.Location = new System.Drawing.Point(3, 10);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(112, 23);
            this.Cancelar_btn.TabIndex = 1;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OK_btn.Enabled = false;
            this.OK_btn.Location = new System.Drawing.Point(157, 10);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(112, 23);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Preco_pnl
            // 
            this.Preco_pnl.Controls.Add(this.Preco_tbx);
            this.Preco_pnl.Controls.Add(this.Preco_lbl);
            this.Preco_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Preco_pnl.Location = new System.Drawing.Point(32, 100);
            this.Preco_pnl.Name = "Preco_pnl";
            this.Preco_pnl.Size = new System.Drawing.Size(272, 48);
            this.Preco_pnl.TabIndex = 0;
            // 
            // Preco_tbx
            // 
            this.Preco_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Preco_tbx.Location = new System.Drawing.Point(0, 17);
            this.Preco_tbx.Name = "Preco_tbx";
            this.Preco_tbx.Size = new System.Drawing.Size(272, 20);
            this.Preco_tbx.TabIndex = 1;
            this.Preco_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Preco_lbl
            // 
            this.Preco_lbl.AutoSize = true;
            this.Preco_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Preco_lbl.Location = new System.Drawing.Point(0, 0);
            this.Preco_lbl.Name = "Preco_lbl";
            this.Preco_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Preco_lbl.Size = new System.Drawing.Size(35, 17);
            this.Preco_lbl.TabIndex = 0;
            this.Preco_lbl.Text = "Preço";
            // 
            // Componente_pnl
            // 
            this.Componente_pnl.Controls.Add(this.Componente_tbx);
            this.Componente_pnl.Controls.Add(this.Componente_lbl);
            this.Componente_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Componente_pnl.Location = new System.Drawing.Point(32, 52);
            this.Componente_pnl.Name = "Componente_pnl";
            this.Componente_pnl.Size = new System.Drawing.Size(272, 48);
            this.Componente_pnl.TabIndex = 0;
            // 
            // Componente_tbx
            // 
            this.Componente_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Componente_tbx.Location = new System.Drawing.Point(0, 17);
            this.Componente_tbx.Name = "Componente_tbx";
            this.Componente_tbx.Size = new System.Drawing.Size(272, 20);
            this.Componente_tbx.TabIndex = 3;
            // 
            // Componente_lbl
            // 
            this.Componente_lbl.AutoSize = true;
            this.Componente_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Componente_lbl.Location = new System.Drawing.Point(0, 0);
            this.Componente_lbl.Name = "Componente_lbl";
            this.Componente_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Componente_lbl.Size = new System.Drawing.Size(67, 17);
            this.Componente_lbl.TabIndex = 0;
            this.Componente_lbl.Text = "Componente";
            // 
            // H1_lbl
            // 
            this.H1_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1_lbl.Location = new System.Drawing.Point(32, 0);
            this.H1_lbl.Name = "H1_lbl";
            this.H1_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.H1_lbl.Size = new System.Drawing.Size(272, 52);
            this.H1_lbl.TabIndex = 0;
            this.H1_lbl.Text = "Atualizar preço";
            this.H1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroFornecedoresConsultaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 233);
            this.Controls.Add(this.Corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 39);
            this.Name = "frmCadastroFornecedoresConsultaUpdate";
            this.Text = "Cadastrar fornecedor";
            this.Corpo_pnl.ResumeLayout(false);
            this.BarraInf_pnl.ResumeLayout(false);
            this.Preco_pnl.ResumeLayout(false);
            this.Preco_pnl.PerformLayout();
            this.Componente_pnl.ResumeLayout(false);
            this.Componente_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel EspEsq_pnl;
        private System.Windows.Forms.Panel EspDir_pnl;
        private System.Windows.Forms.Panel Corpo_pnl;
        private System.Windows.Forms.Panel BarraInf_pnl;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Panel Componente_pnl;
        private System.Windows.Forms.Label Componente_lbl;
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.Panel Preco_pnl;
        private System.Windows.Forms.TextBox Preco_tbx;
        private System.Windows.Forms.Label Preco_lbl;
        private System.Windows.Forms.TextBox Componente_tbx;
    }
}