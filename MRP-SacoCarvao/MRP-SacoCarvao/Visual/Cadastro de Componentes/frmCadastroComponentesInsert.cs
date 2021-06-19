using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MRP_SacoCarvao.Cadastro_de_Componentes.Controles;

namespace MRP_SacoCarvao.Cadastro_de_Componentes
{
    public partial class frmCadastroComponentesInsert : Form
    {
        // funcoes
        private void SetEspecificacoes( Componente paramComp )
        {
            Especs_pnl.Controls.Clear();

            List<string> label = paramComp.GetEspecificacoes();

            for (int i = 0; i < label.Count; i++)
                SpawnEspecificacao("especificacao_" + i, label[i], Especs_pnl);
        }
        private void SpawnEspecificacao(string nome, string label, Panel mae)
        {
            pnlEspecificacao espec = new pnlEspecificacao()
            {
                Name = nome,
                Location = new Point(0, 0)
            };
            espec.nomeCampo.Text = label;
            mae.Controls.Add(espec);
            espec.BringToFront();
        }

        // funcoes dos controles
        public frmCadastroComponentesInsert()
        {
            InitializeComponent();
        }

        private void Tipo_cbb_TextChanged(object sender, System.EventArgs e)
        {
            if (Modelo_pnl.Visible == false)
                Modelo_pnl.Visible = true;
            Componente objComp = new Componente();
            objComp.tipoComponente = Tipo_cbb.Text;
            SetEspecificacoes(objComp);
        }

        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (Modelo_tbx.Text != "" && Tipo_cbb.Text != "")
            {
                OK_btn.Enabled = true;
            }
            else
            {
                OK_btn.Enabled = false;
            }
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            Componente objComp = new Componente( 0, Tipo_cbb.Text, Modelo_tbx.Text );

            //especificacoes
            StringBuilder especs = new StringBuilder();
            foreach (pnlEspecificacao spec in Especs_pnl.Controls)
            {
                especs.Insert(0, spec.textbox.Text + ";");
            }
            objComp.especificacao = especs.ToString();

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + objComp.modeloComponente + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                ComponenteDAO objCompDAO = new ComponenteDAO();
                objCompDAO.Insert(objComp);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
