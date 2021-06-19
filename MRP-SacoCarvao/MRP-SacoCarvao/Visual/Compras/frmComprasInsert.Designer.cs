namespace MRP_SacoCarvao.Compras
{
    partial class frmComprasInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprasInsert));
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.Corpo_pnl = new System.Windows.Forms.Panel();
            this.BarraInf_pnl = new System.Windows.Forms.Panel();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Componente_pnl = new System.Windows.Forms.Panel();
            this.Componente_cbb = new System.Windows.Forms.ComboBox();
            this.Componente_lbl = new System.Windows.Forms.Label();
            this.BarraQtde_pnl = new System.Windows.Forms.Panel();
            this.Qtde_pnl = new System.Windows.Forms.Panel();
            this.Qtde_tbx = new System.Windows.Forms.TextBox();
            this.Qtde_lbl = new System.Windows.Forms.Label();
            this.TipoMov_pnl = new System.Windows.Forms.Panel();
            this.TipoMov_cbb = new System.Windows.Forms.ComboBox();
            this.TipoMov_lbl = new System.Windows.Forms.Label();
            this.BarraDocumento_pnl = new System.Windows.Forms.Panel();
            this.Numero_pnl = new System.Windows.Forms.Panel();
            this.Numero_tbx = new System.Windows.Forms.TextBox();
            this.Numero_lbl = new System.Windows.Forms.Label();
            this.TipoDoc_pnl = new System.Windows.Forms.Panel();
            this.TipoDoc_cbb = new System.Windows.Forms.ComboBox();
            this.TipoDoc_lbl = new System.Windows.Forms.Label();
            this.Data_pnl = new System.Windows.Forms.Panel();
            this.Data_dtp = new System.Windows.Forms.DateTimePicker();
            this.Data_lbl = new System.Windows.Forms.Label();
            this.H1_lbl = new System.Windows.Forms.Label();
            this.Corpo_pnl.SuspendLayout();
            this.BarraInf_pnl.SuspendLayout();
            this.Componente_pnl.SuspendLayout();
            this.BarraQtde_pnl.SuspendLayout();
            this.Qtde_pnl.SuspendLayout();
            this.TipoMov_pnl.SuspendLayout();
            this.BarraDocumento_pnl.SuspendLayout();
            this.Numero_pnl.SuspendLayout();
            this.TipoDoc_pnl.SuspendLayout();
            this.Data_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspEsq_pnl.TabIndex = 21;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(272, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspDir_pnl.TabIndex = 20;
            // 
            // Corpo_pnl
            // 
            this.Corpo_pnl.AutoScroll = true;
            this.Corpo_pnl.AutoSize = true;
            this.Corpo_pnl.Controls.Add(this.BarraInf_pnl);
            this.Corpo_pnl.Controls.Add(this.Componente_pnl);
            this.Corpo_pnl.Controls.Add(this.BarraQtde_pnl);
            this.Corpo_pnl.Controls.Add(this.BarraDocumento_pnl);
            this.Corpo_pnl.Controls.Add(this.Data_pnl);
            this.Corpo_pnl.Controls.Add(this.H1_lbl);
            this.Corpo_pnl.Controls.Add(this.EspDir_pnl);
            this.Corpo_pnl.Controls.Add(this.EspEsq_pnl);
            this.Corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.Corpo_pnl.Name = "Corpo_pnl";
            this.Corpo_pnl.Size = new System.Drawing.Size(304, 393);
            this.Corpo_pnl.TabIndex = 4;
            // 
            // BarraInf_pnl
            // 
            this.BarraInf_pnl.Controls.Add(this.Cancelar_btn);
            this.BarraInf_pnl.Controls.Add(this.OK_btn);
            this.BarraInf_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraInf_pnl.Location = new System.Drawing.Point(32, 345);
            this.BarraInf_pnl.Name = "BarraInf_pnl";
            this.BarraInf_pnl.Size = new System.Drawing.Size(240, 48);
            this.BarraInf_pnl.TabIndex = 4;
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
            this.OK_btn.Location = new System.Drawing.Point(125, 10);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(112, 23);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Componente_pnl
            // 
            this.Componente_pnl.Controls.Add(this.Componente_cbb);
            this.Componente_pnl.Controls.Add(this.Componente_lbl);
            this.Componente_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Componente_pnl.Location = new System.Drawing.Point(32, 196);
            this.Componente_pnl.Name = "Componente_pnl";
            this.Componente_pnl.Size = new System.Drawing.Size(240, 48);
            this.Componente_pnl.TabIndex = 23;
            // 
            // Componente_cbb
            // 
            this.Componente_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Componente_cbb.FormattingEnabled = true;
            this.Componente_cbb.Location = new System.Drawing.Point(0, 17);
            this.Componente_cbb.Name = "Componente_cbb";
            this.Componente_cbb.Size = new System.Drawing.Size(240, 21);
            this.Componente_cbb.TabIndex = 2;
            this.Componente_cbb.SelectedIndexChanged += new System.EventHandler(this.Required_TextChanged);
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
            // BarraQtde_pnl
            // 
            this.BarraQtde_pnl.Controls.Add(this.Qtde_pnl);
            this.BarraQtde_pnl.Controls.Add(this.TipoMov_pnl);
            this.BarraQtde_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraQtde_pnl.Location = new System.Drawing.Point(32, 148);
            this.BarraQtde_pnl.Name = "BarraQtde_pnl";
            this.BarraQtde_pnl.Size = new System.Drawing.Size(240, 48);
            this.BarraQtde_pnl.TabIndex = 22;
            // 
            // Qtde_pnl
            // 
            this.Qtde_pnl.Controls.Add(this.Qtde_tbx);
            this.Qtde_pnl.Controls.Add(this.Qtde_lbl);
            this.Qtde_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Qtde_pnl.Location = new System.Drawing.Point(96, 0);
            this.Qtde_pnl.Name = "Qtde_pnl";
            this.Qtde_pnl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Qtde_pnl.Size = new System.Drawing.Size(144, 48);
            this.Qtde_pnl.TabIndex = 3;
            // 
            // Qtde_tbx
            // 
            this.Qtde_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Qtde_tbx.Location = new System.Drawing.Point(12, 17);
            this.Qtde_tbx.Name = "Qtde_tbx";
            this.Qtde_tbx.Size = new System.Drawing.Size(132, 20);
            this.Qtde_tbx.TabIndex = 1;
            this.Qtde_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Qtde_lbl
            // 
            this.Qtde_lbl.AutoSize = true;
            this.Qtde_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Qtde_lbl.Location = new System.Drawing.Point(12, 0);
            this.Qtde_lbl.Name = "Qtde_lbl";
            this.Qtde_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Qtde_lbl.Size = new System.Drawing.Size(112, 17);
            this.Qtde_lbl.TabIndex = 0;
            this.Qtde_lbl.Text = "Quantidade comprada";
            // 
            // TipoMov_pnl
            // 
            this.TipoMov_pnl.Controls.Add(this.TipoMov_cbb);
            this.TipoMov_pnl.Controls.Add(this.TipoMov_lbl);
            this.TipoMov_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TipoMov_pnl.Location = new System.Drawing.Point(0, 0);
            this.TipoMov_pnl.Name = "TipoMov_pnl";
            this.TipoMov_pnl.Size = new System.Drawing.Size(96, 48);
            this.TipoMov_pnl.TabIndex = 4;
            // 
            // TipoMov_cbb
            // 
            this.TipoMov_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoMov_cbb.FormattingEnabled = true;
            this.TipoMov_cbb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.TipoMov_cbb.Location = new System.Drawing.Point(0, 17);
            this.TipoMov_cbb.Name = "TipoMov_cbb";
            this.TipoMov_cbb.Size = new System.Drawing.Size(96, 21);
            this.TipoMov_cbb.TabIndex = 2;
            this.TipoMov_cbb.SelectedIndexChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // TipoMov_lbl
            // 
            this.TipoMov_lbl.AutoSize = true;
            this.TipoMov_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoMov_lbl.Location = new System.Drawing.Point(0, 0);
            this.TipoMov_lbl.Name = "TipoMov_lbl";
            this.TipoMov_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.TipoMov_lbl.Size = new System.Drawing.Size(77, 17);
            this.TipoMov_lbl.TabIndex = 0;
            this.TipoMov_lbl.Text = "Movimentação";
            // 
            // BarraDocumento_pnl
            // 
            this.BarraDocumento_pnl.Controls.Add(this.Numero_pnl);
            this.BarraDocumento_pnl.Controls.Add(this.TipoDoc_pnl);
            this.BarraDocumento_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDocumento_pnl.Location = new System.Drawing.Point(32, 100);
            this.BarraDocumento_pnl.Name = "BarraDocumento_pnl";
            this.BarraDocumento_pnl.Size = new System.Drawing.Size(240, 48);
            this.BarraDocumento_pnl.TabIndex = 2;
            // 
            // Numero_pnl
            // 
            this.Numero_pnl.Controls.Add(this.Numero_tbx);
            this.Numero_pnl.Controls.Add(this.Numero_lbl);
            this.Numero_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Numero_pnl.Location = new System.Drawing.Point(64, 0);
            this.Numero_pnl.Name = "Numero_pnl";
            this.Numero_pnl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Numero_pnl.Size = new System.Drawing.Size(176, 48);
            this.Numero_pnl.TabIndex = 3;
            // 
            // Numero_tbx
            // 
            this.Numero_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Numero_tbx.Location = new System.Drawing.Point(12, 17);
            this.Numero_tbx.Name = "Numero_tbx";
            this.Numero_tbx.Size = new System.Drawing.Size(164, 20);
            this.Numero_tbx.TabIndex = 1;
            this.Numero_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Numero_lbl
            // 
            this.Numero_lbl.AutoSize = true;
            this.Numero_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Numero_lbl.Location = new System.Drawing.Point(12, 0);
            this.Numero_lbl.Name = "Numero_lbl";
            this.Numero_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Numero_lbl.Size = new System.Drawing.Size(115, 17);
            this.Numero_lbl.TabIndex = 0;
            this.Numero_lbl.Text = "Número do documento";
            // 
            // TipoDoc_pnl
            // 
            this.TipoDoc_pnl.Controls.Add(this.TipoDoc_cbb);
            this.TipoDoc_pnl.Controls.Add(this.TipoDoc_lbl);
            this.TipoDoc_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TipoDoc_pnl.Location = new System.Drawing.Point(0, 0);
            this.TipoDoc_pnl.Name = "TipoDoc_pnl";
            this.TipoDoc_pnl.Size = new System.Drawing.Size(64, 48);
            this.TipoDoc_pnl.TabIndex = 4;
            // 
            // TipoDoc_cbb
            // 
            this.TipoDoc_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoDoc_cbb.FormattingEnabled = true;
            this.TipoDoc_cbb.Items.AddRange(new object[] {
            "CNPJ",
            "CPF",
            "RG"});
            this.TipoDoc_cbb.Location = new System.Drawing.Point(0, 17);
            this.TipoDoc_cbb.Name = "TipoDoc_cbb";
            this.TipoDoc_cbb.Size = new System.Drawing.Size(64, 21);
            this.TipoDoc_cbb.TabIndex = 2;
            this.TipoDoc_cbb.SelectedIndexChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // TipoDoc_lbl
            // 
            this.TipoDoc_lbl.AutoSize = true;
            this.TipoDoc_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TipoDoc_lbl.Location = new System.Drawing.Point(0, 0);
            this.TipoDoc_lbl.Name = "TipoDoc_lbl";
            this.TipoDoc_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.TipoDoc_lbl.Size = new System.Drawing.Size(52, 17);
            this.TipoDoc_lbl.TabIndex = 0;
            this.TipoDoc_lbl.Text = "Tipo doc.";
            // 
            // Data_pnl
            // 
            this.Data_pnl.Controls.Add(this.Data_dtp);
            this.Data_pnl.Controls.Add(this.Data_lbl);
            this.Data_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Data_pnl.Location = new System.Drawing.Point(32, 52);
            this.Data_pnl.Name = "Data_pnl";
            this.Data_pnl.Size = new System.Drawing.Size(240, 48);
            this.Data_pnl.TabIndex = 1;
            // 
            // Data_dtp
            // 
            this.Data_dtp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Data_dtp.Location = new System.Drawing.Point(0, 17);
            this.Data_dtp.Name = "Data_dtp";
            this.Data_dtp.Size = new System.Drawing.Size(240, 20);
            this.Data_dtp.TabIndex = 3;
            this.Data_dtp.ValueChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Data_lbl
            // 
            this.Data_lbl.AutoSize = true;
            this.Data_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Data_lbl.Location = new System.Drawing.Point(0, 0);
            this.Data_lbl.Name = "Data_lbl";
            this.Data_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Data_lbl.Size = new System.Drawing.Size(117, 17);
            this.Data_lbl.TabIndex = 0;
            this.Data_lbl.Text = "Data da movimentação";
            // 
            // H1_lbl
            // 
            this.H1_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1_lbl.Location = new System.Drawing.Point(32, 0);
            this.H1_lbl.Name = "H1_lbl";
            this.H1_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 12);
            this.H1_lbl.Size = new System.Drawing.Size(240, 52);
            this.H1_lbl.TabIndex = 0;
            this.H1_lbl.Text = "Registrar compra";
            this.H1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComprasInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 393);
            this.Controls.Add(this.Corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(272, 39);
            this.Name = "frmComprasInsert";
            this.Text = "Registrar compra";
            this.Corpo_pnl.ResumeLayout(false);
            this.BarraInf_pnl.ResumeLayout(false);
            this.Componente_pnl.ResumeLayout(false);
            this.Componente_pnl.PerformLayout();
            this.BarraQtde_pnl.ResumeLayout(false);
            this.Qtde_pnl.ResumeLayout(false);
            this.Qtde_pnl.PerformLayout();
            this.TipoMov_pnl.ResumeLayout(false);
            this.TipoMov_pnl.PerformLayout();
            this.BarraDocumento_pnl.ResumeLayout(false);
            this.Numero_pnl.ResumeLayout(false);
            this.Numero_pnl.PerformLayout();
            this.TipoDoc_pnl.ResumeLayout(false);
            this.TipoDoc_pnl.PerformLayout();
            this.Data_pnl.ResumeLayout(false);
            this.Data_pnl.PerformLayout();
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
        private System.Windows.Forms.Panel BarraDocumento_pnl;
        private System.Windows.Forms.Panel Data_pnl;
        private System.Windows.Forms.Label Data_lbl;
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.DateTimePicker Data_dtp;
        private System.Windows.Forms.Panel Numero_pnl;
        private System.Windows.Forms.TextBox Numero_tbx;
        private System.Windows.Forms.Label Numero_lbl;
        private System.Windows.Forms.Panel TipoDoc_pnl;
        private System.Windows.Forms.ComboBox TipoDoc_cbb;
        private System.Windows.Forms.Label TipoDoc_lbl;
        private System.Windows.Forms.Panel BarraQtde_pnl;
        private System.Windows.Forms.Panel Qtde_pnl;
        private System.Windows.Forms.TextBox Qtde_tbx;
        private System.Windows.Forms.Label Qtde_lbl;
        private System.Windows.Forms.Panel TipoMov_pnl;
        private System.Windows.Forms.ComboBox TipoMov_cbb;
        private System.Windows.Forms.Label TipoMov_lbl;
        private System.Windows.Forms.Panel Componente_pnl;
        private System.Windows.Forms.ComboBox Componente_cbb;
        private System.Windows.Forms.Label Componente_lbl;
    }
}