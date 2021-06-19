using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MRP_SacoCarvao.Cadastro_de_Componentes.Controles;

namespace MRP_SacoCarvao.Cadastro_de_Componentes
{
    public partial class frmCadastroComponentesUpdate : Form
    {
        //funcoes
        private void SetCampos(Componente paramComp)
        {
            H1_lbl.Text = paramComp.tipoComponente;
            Cod_lbl.Text = paramComp.idComponente.ToString();
            Modelo_tbx.Text = paramComp.modeloComponente;

            List<string> label = paramComp.GetEspecificacoes();
            if (paramComp.especificacao != "")
            {
                string[] valor = paramComp.especificacao.Split(';');

                for (int i = 0; i < label.Count; i++)
                    SpawnEspecificacao("especificacao_" + i, label[i], valor[i], Especs_pnl);
            }
            else
            {
                for (int i = 0; i < label.Count; i++)
                    SpawnEspecificacao("especificacao_" + i, label[i], "", Especs_pnl);
            }
        }
        private void SpawnEspecificacao(string nome, string label, string valor, Panel mae)
        {
            pnlEspecificacao espec = new pnlEspecificacao()
            {
                Name = nome,
                Location = new Point(0, 0)
            };
            espec.nomeCampo.Text = label;
            espec.textbox.Text = valor;
            mae.Controls.Add(espec);
            espec.BringToFront();
        }

        // variaveis
        Componente objComp = new Componente();

        // funcoes dos controles
        public frmCadastroComponentesUpdate( Componente paramComponente )
        {
            objComp = paramComponente;

            InitializeComponent();
            SetCampos(paramComponente);
        }

        private void Modelo_tbx_TextChanged(object sender, System.EventArgs e)
        {
            if (Modelo_tbx.Text != "")
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
            //modelo
            objComp.modeloComponente = Modelo_tbx.Text;

            //especificacoes
            StringBuilder especs = new StringBuilder();
            foreach (pnlEspecificacao spec in Especs_pnl.Controls)
            {
                especs.Insert(0, spec.textbox.Text + ";");
            }
            objComp.especificacao = especs.ToString();

            // confirmando insercao
            DialogResult confirmarUpdate = MessageBox.Show(
                "◉_◉ " + objComp.modeloComponente + " ?!", "Confirmar Alteração",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                ComponenteDAO objCompDAO = new ComponenteDAO();
                objCompDAO.Update(objComp);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
