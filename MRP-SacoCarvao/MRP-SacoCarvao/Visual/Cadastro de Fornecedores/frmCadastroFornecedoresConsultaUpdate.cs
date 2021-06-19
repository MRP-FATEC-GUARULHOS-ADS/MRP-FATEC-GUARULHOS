using System;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedoresConsultaUpdate : Form
    {
        // funcoes
        private void SetCampos()
        {
            H1_lbl.Text = objFornComp.fornecedor.nomeFornecedor;

            Componente_tbx.Text = objFornComp.componente.ToString();
            Componente_tbx.ReadOnly = true;

            Preco_tbx.Text = objFornComp.preco.ToString();
        }

        // variaveis
        FornecedorComponente objFornComp;

        // funcoes dos controles
        public frmCadastroFornecedoresConsultaUpdate( FornecedorComponente paramFornComp )
        {
            InitializeComponent();

            objFornComp = paramFornComp;

            SetCampos();
        }

        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (Preco_tbx.Text != "")
                OK_btn.Enabled = true;
            else
                OK_btn.Enabled = false;
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            objFornComp.preco = Convert.ToDouble(Preco_tbx.Text);

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "(ʘ ʖ̯ ʘ) " + objFornComp.componente + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                FornecedorComponenteDAO objFornCompDAO = new FornecedorComponenteDAO();
                objFornCompDAO.Update(objFornComp);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
