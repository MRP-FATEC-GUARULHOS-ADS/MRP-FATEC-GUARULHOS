namespace MRP_SacoCarvao.Cadastro_de_Componentes
{
    partial class frmCadastroComponentesInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroComponentesInsert));
            this.EspEsq_pnl = new System.Windows.Forms.Panel();
            this.EspDir_pnl = new System.Windows.Forms.Panel();
            this.Corpo_pnl = new System.Windows.Forms.Panel();
            this.BarraInf_pnl = new System.Windows.Forms.Panel();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Especs_pnl = new System.Windows.Forms.Panel();
            this.Modelo_pnl = new System.Windows.Forms.Panel();
            this.Modelo_tbx = new System.Windows.Forms.TextBox();
            this.Modelo_lbl = new System.Windows.Forms.Label();
            this.Tipo_pnl = new System.Windows.Forms.Panel();
            this.Tipo_cbb = new System.Windows.Forms.ComboBox();
            this.Tipo_lbl = new System.Windows.Forms.Label();
            this.H1_lbl = new System.Windows.Forms.Label();
            this.Corpo_pnl.SuspendLayout();
            this.BarraInf_pnl.SuspendLayout();
            this.Modelo_pnl.SuspendLayout();
            this.Tipo_pnl.SuspendLayout();
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
            this.Corpo_pnl.Controls.Add(this.Especs_pnl);
            this.Corpo_pnl.Controls.Add(this.Modelo_pnl);
            this.Corpo_pnl.Controls.Add(this.Tipo_pnl);
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
            // Especs_pnl
            // 
            this.Especs_pnl.AutoSize = true;
            this.Especs_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Especs_pnl.Location = new System.Drawing.Point(32, 148);
            this.Especs_pnl.Name = "Especs_pnl";
            this.Especs_pnl.Size = new System.Drawing.Size(240, 0);
            this.Especs_pnl.TabIndex = 3;
            // 
            // Modelo_pnl
            // 
            this.Modelo_pnl.Controls.Add(this.Modelo_tbx);
            this.Modelo_pnl.Controls.Add(this.Modelo_lbl);
            this.Modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modelo_pnl.Location = new System.Drawing.Point(32, 100);
            this.Modelo_pnl.Name = "Modelo_pnl";
            this.Modelo_pnl.Size = new System.Drawing.Size(240, 48);
            this.Modelo_pnl.TabIndex = 2;
            this.Modelo_pnl.Visible = false;
            // 
            // Modelo_tbx
            // 
            this.Modelo_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modelo_tbx.Location = new System.Drawing.Point(0, 17);
            this.Modelo_tbx.Name = "Modelo_tbx";
            this.Modelo_tbx.Size = new System.Drawing.Size(240, 20);
            this.Modelo_tbx.TabIndex = 1;
            this.Modelo_tbx.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Modelo_lbl
            // 
            this.Modelo_lbl.AutoSize = true;
            this.Modelo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modelo_lbl.Location = new System.Drawing.Point(0, 0);
            this.Modelo_lbl.Name = "Modelo_lbl";
            this.Modelo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Modelo_lbl.Size = new System.Drawing.Size(120, 17);
            this.Modelo_lbl.TabIndex = 0;
            this.Modelo_lbl.Text = "Modelo do Componente";
            // 
            // Tipo_pnl
            // 
            this.Tipo_pnl.Controls.Add(this.Tipo_cbb);
            this.Tipo_pnl.Controls.Add(this.Tipo_lbl);
            this.Tipo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tipo_pnl.Location = new System.Drawing.Point(32, 52);
            this.Tipo_pnl.Name = "Tipo_pnl";
            this.Tipo_pnl.Size = new System.Drawing.Size(240, 48);
            this.Tipo_pnl.TabIndex = 1;
            // 
            // Tipo_cbb
            // 
            this.Tipo_cbb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tipo_cbb.FormattingEnabled = true;
            this.Tipo_cbb.Items.AddRange(new object[] {
            "HD",
            "SSD",
            "Memória RAM",
            "Placa de Vídeo",
            "Placa Mãe",
            "Processador",
            "Sistema",
            "Tela"});
            this.Tipo_cbb.Location = new System.Drawing.Point(0, 17);
            this.Tipo_cbb.Name = "Tipo_cbb";
            this.Tipo_cbb.Size = new System.Drawing.Size(240, 21);
            this.Tipo_cbb.TabIndex = 2;
            this.Tipo_cbb.SelectedIndexChanged += new System.EventHandler(this.Tipo_cbb_TextChanged);
            this.Tipo_cbb.TextChanged += new System.EventHandler(this.Required_TextChanged);
            // 
            // Tipo_lbl
            // 
            this.Tipo_lbl.AutoSize = true;
            this.Tipo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tipo_lbl.Location = new System.Drawing.Point(0, 0);
            this.Tipo_lbl.Name = "Tipo_lbl";
            this.Tipo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Tipo_lbl.Size = new System.Drawing.Size(106, 17);
            this.Tipo_lbl.TabIndex = 0;
            this.Tipo_lbl.Text = "Tipo de Componente";
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
            this.H1_lbl.Text = "Cadastrar componente";
            this.H1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroComponentesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 393);
            this.Controls.Add(this.Corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(272, 39);
            this.Name = "frmCadastroComponentesInsert";
            this.Text = "Cadastrar componente";
            this.Corpo_pnl.ResumeLayout(false);
            this.Corpo_pnl.PerformLayout();
            this.BarraInf_pnl.ResumeLayout(false);
            this.Modelo_pnl.ResumeLayout(false);
            this.Modelo_pnl.PerformLayout();
            this.Tipo_pnl.ResumeLayout(false);
            this.Tipo_pnl.PerformLayout();
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
        private System.Windows.Forms.Panel Modelo_pnl;
        private System.Windows.Forms.TextBox Modelo_tbx;
        private System.Windows.Forms.Label Modelo_lbl;
        private System.Windows.Forms.Panel Tipo_pnl;
        private System.Windows.Forms.ComboBox Tipo_cbb;
        private System.Windows.Forms.Label Tipo_lbl;
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.Panel Especs_pnl;
    }
}