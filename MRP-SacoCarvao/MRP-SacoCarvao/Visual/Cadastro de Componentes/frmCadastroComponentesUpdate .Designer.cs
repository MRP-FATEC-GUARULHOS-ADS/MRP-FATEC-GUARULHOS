namespace MRP_SacoCarvao.Cadastro_de_Componentes
{
    partial class frmCadastroComponentesUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroComponentesUpdate));
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
            this.Cod_lbl = new System.Windows.Forms.Label();
            this.H1_lbl = new System.Windows.Forms.Label();
            this.Corpo_pnl.SuspendLayout();
            this.BarraInf_pnl.SuspendLayout();
            this.Modelo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspEsq_pnl
            // 
            this.EspEsq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.EspEsq_pnl.Location = new System.Drawing.Point(0, 0);
            this.EspEsq_pnl.Name = "EspEsq_pnl";
            this.EspEsq_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspEsq_pnl.TabIndex = 5;
            // 
            // EspDir_pnl
            // 
            this.EspDir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EspDir_pnl.Location = new System.Drawing.Point(272, 0);
            this.EspDir_pnl.Name = "EspDir_pnl";
            this.EspDir_pnl.Size = new System.Drawing.Size(32, 393);
            this.EspDir_pnl.TabIndex = 6;
            // 
            // Corpo_pnl
            // 
            this.Corpo_pnl.AutoScroll = true;
            this.Corpo_pnl.AutoSize = true;
            this.Corpo_pnl.Controls.Add(this.BarraInf_pnl);
            this.Corpo_pnl.Controls.Add(this.Especs_pnl);
            this.Corpo_pnl.Controls.Add(this.Modelo_pnl);
            this.Corpo_pnl.Controls.Add(this.Cod_lbl);
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
            this.Especs_pnl.Location = new System.Drawing.Point(32, 112);
            this.Especs_pnl.Name = "Especs_pnl";
            this.Especs_pnl.Size = new System.Drawing.Size(240, 0);
            this.Especs_pnl.TabIndex = 3;
            // 
            // Modelo_pnl
            // 
            this.Modelo_pnl.Controls.Add(this.Modelo_tbx);
            this.Modelo_pnl.Controls.Add(this.Modelo_lbl);
            this.Modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modelo_pnl.Location = new System.Drawing.Point(32, 64);
            this.Modelo_pnl.Name = "Modelo_pnl";
            this.Modelo_pnl.Size = new System.Drawing.Size(240, 48);
            this.Modelo_pnl.TabIndex = 2;
            // 
            // Modelo_tbx
            // 
            this.Modelo_tbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modelo_tbx.Location = new System.Drawing.Point(0, 17);
            this.Modelo_tbx.Name = "Modelo_tbx";
            this.Modelo_tbx.Size = new System.Drawing.Size(240, 20);
            this.Modelo_tbx.TabIndex = 1;
            this.Modelo_tbx.TextChanged += new System.EventHandler(this.Modelo_tbx_TextChanged);
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
            // Cod_lbl
            // 
            this.Cod_lbl.AutoSize = true;
            this.Cod_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cod_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_lbl.Location = new System.Drawing.Point(32, 34);
            this.Cod_lbl.Name = "Cod_lbl";
            this.Cod_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.Cod_lbl.Size = new System.Drawing.Size(32, 30);
            this.Cod_lbl.TabIndex = 1;
            this.Cod_lbl.Text = "000";
            // 
            // H1_lbl
            // 
            this.H1_lbl.AutoSize = true;
            this.H1_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.H1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1_lbl.Location = new System.Drawing.Point(32, 0);
            this.H1_lbl.Name = "H1_lbl";
            this.H1_lbl.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.H1_lbl.Size = new System.Drawing.Size(118, 34);
            this.H1_lbl.TabIndex = 0;
            this.H1_lbl.Text = "Placa de vídeo";
            // 
            // frmCadastroComponentesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 393);
            this.Controls.Add(this.Corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(272, 0);
            this.Name = "frmCadastroComponentesUpdate";
            this.Text = "Editar componente";
            this.Corpo_pnl.ResumeLayout(false);
            this.Corpo_pnl.PerformLayout();
            this.BarraInf_pnl.ResumeLayout(false);
            this.Modelo_pnl.ResumeLayout(false);
            this.Modelo_pnl.PerformLayout();
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
        private System.Windows.Forms.Label H1_lbl;
        private System.Windows.Forms.Panel Especs_pnl;
        private System.Windows.Forms.Label Cod_lbl;
    }
}