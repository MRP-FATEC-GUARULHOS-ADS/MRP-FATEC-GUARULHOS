using System;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedoresConsultaInsert : Form
    {
        // funcoes
        public void ListaComponentes()
        {
            ComponenteDAO compDAO = new ComponenteDAO();
            BindingSource bs = new BindingSource();
            bs.DataSource = compDAO.GetComponentes();
            Componente_cbb.DataSource = bs;
        }

        // variaveis
        Fornecedor objFornecedor;

        // funcoes dos controles
        public frmCadastroFornecedoresConsultaInsert( Fornecedor paramFornecedor )
        {
            InitializeComponent();

            objFornecedor = paramFornecedor;

            ListaComponentes();
        }

        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (Componente_cbb.Text != "" && Preco_tbx.Text != "")
                OK_btn.Enabled = true;
            else
                OK_btn.Enabled = false;
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            FornecedorComponente objFornComp = new FornecedorComponente(
                objFornecedor,
                Componente_cbb.SelectedItem as Componente,
                Convert.ToDouble(Preco_tbx.Text)
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "(ʘ ʖ̯ ʘ) " + objFornComp.componente + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                FornecedorComponenteDAO objFornCompDAO = new FornecedorComponenteDAO();
                objFornCompDAO.Insert(objFornComp);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
