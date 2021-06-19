using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedoresInsert : Form
    {
        // funcoes dos controles
        public frmCadastroFornecedoresInsert()
        {
            InitializeComponent();
        }

        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (Nome_tbx.Text != "" &&
                Logr_tbx.Text != "" && Num_tbx.Text != "" && CEP_tbx.Text != "" &&
                Bairro_tbx.Text != "" && Cidade_tbx.Text != "" && UF_cbb.Text != "" &&
                Tel_tbx.Text != "" && EMail_tbx.Text != "")
            {
                OK_btn.Enabled = true;
            }
            else
                OK_btn.Enabled = false;
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            Fornecedor objForn = new Fornecedor(
                0, Nome_tbx.Text,
                Tipo_cbb.Text, Logr_tbx.Text, Num_tbx.Text,
                Compl_tbx.Text, CEP_tbx.Text, Bairro_tbx.Text, Cidade_tbx.Text, UF_cbb.Text,
                Tel_tbx.Text, Cel_tbx.Text, EMail_tbx.Text, Site_tbx.Text
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "(ʘ ʖ̯ ʘ) " + objForn.nomeFornecedor + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                FornecedorDAO objFornDAO = new FornecedorDAO();
                objFornDAO.Insert(objForn);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
