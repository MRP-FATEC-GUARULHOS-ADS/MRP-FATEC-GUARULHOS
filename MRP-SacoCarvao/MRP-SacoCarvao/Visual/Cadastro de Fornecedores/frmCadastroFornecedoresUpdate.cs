using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedoresUpdate : Form
    {
        //funcoes
        private void SetCampos(Fornecedor paramForn)
        {
            H1_lbl.Text = paramForn.nomeFornecedor;
            Nome_tbx.Text = paramForn.nomeFornecedor;
            CEP_tbx.Text = paramForn.cep;
            Tipo_cbb.Text = paramForn.tipoLogradouro;
            Logr_tbx.Text = paramForn.logradouro;
            Num_tbx.Text = paramForn.numero;
            Compl_tbx.Text = paramForn.complemento;
            Bairro_tbx.Text = paramForn.bairro;
            Cidade_tbx.Text = paramForn.cidade;
            UF_cbb.Text = paramForn.uf;
            Tel_tbx.Text = paramForn.telefone;
            Cel_tbx.Text = paramForn.celular;
            EMail_tbx.Text = paramForn.email;
            Site_tbx.Text = paramForn.urlSite;
        }

        // variaveis
        Fornecedor objForn = new Fornecedor();

        // funcoes dos controles
        public frmCadastroFornecedoresUpdate( Fornecedor paramFornecedor )
        {
            objForn = paramFornecedor;

            InitializeComponent();
            SetCampos(paramFornecedor);
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
            //modelo
            objForn.nomeFornecedor = Nome_tbx.Text;
            objForn.cep = CEP_tbx.Text;
            objForn.tipoLogradouro = Tipo_cbb.Text;
            objForn.logradouro = Logr_tbx.Text;
            objForn.numero = Num_tbx.Text;
            objForn.complemento = Compl_tbx.Text;
            objForn.bairro = Bairro_tbx.Text;
            objForn.cidade = Cidade_tbx.Text;
            objForn.cidade = UF_cbb.Text;
            objForn.telefone = Tel_tbx.Text;
            objForn.celular = Cel_tbx.Text;
            objForn.email = EMail_tbx.Text;
            objForn.urlSite = Site_tbx.Text;

            // confirmando insercao
            DialogResult confirmarUpdate = MessageBox.Show(
                "(○｀ 3′○) " + objForn.nomeFornecedor + " ?!", "Confirmar Alteração",
                MessageBoxButtons.YesNo
            );
            if (confirmarUpdate == DialogResult.Yes)
            {
                FornecedorDAO objFornDAO = new FornecedorDAO();
                objFornDAO.Update(objForn);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
