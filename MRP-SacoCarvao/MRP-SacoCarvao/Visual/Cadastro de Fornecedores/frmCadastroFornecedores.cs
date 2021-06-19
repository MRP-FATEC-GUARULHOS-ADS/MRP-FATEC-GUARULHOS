using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedores : Form
    {
        public frmCadastroFornecedores()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista ()
        {
            FornecedorDAO objFornDAO = new FornecedorDAO();
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores = objFornDAO.GetFornecedores();

            var lista = new BindingList<Fornecedor>(listaFornecedores);
            ListaForns_dgv.DataSource = lista;
        }
        private void Pesquisar( string pesquisa)
        {
            FornecedorDAO objFornDAO = new FornecedorDAO();
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();

            if (pesquisa != "")
                listaFornecedores = objFornDAO.PesquisaFornecedores(pesquisa);
            else
                listaFornecedores = objFornDAO.GetFornecedores();

            var lista = new BindingList<Fornecedor>(listaFornecedores);
            ListaForns_dgv.DataSource = lista;
        }

        // funcoes do formulario
        private void FormCadastroFornecedores_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void frmCadastroFornecedores_SizeChanged(object sender, EventArgs e)
        {
            if (ListaForns_dgv.ColumnCount > 13)
            {
                if (ListaForns_dgv.Width > 1560)
                    ListaForns_dgv.Columns[1].Width = ListaForns_dgv.Width - 1460;
                else
                    ListaForns_dgv.Columns[1].Width = 100;
            }
        }

        // funcoes dos objetos
        private void DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                Consultar_btn.Enabled = true;
                Excluir_btn.Enabled = true;
            }
        }

        private void DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

            }
        }

        private void ListaForns_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fornecedor objFornSelec = ListaForns_dgv.CurrentRow.DataBoundItem as Fornecedor;
            frmCadastroFornecedoresConsulta objFrmCadastroConsulta = new frmCadastroFornecedoresConsulta(objFornSelec);
            objFrmCadastroConsulta.ShowDialog();
            AtualizaLista();
        }

        /// pesquisa
        private void Pesquisar_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar(Pesquisar_tbx.Text);
            }
        }
        private void Pesquisar_btn_Click(object sender, EventArgs e)
        {
            Pesquisar(Pesquisar_tbx.Text);
        }

        /// botoes de validacao
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedoresInsert objFrmCadastroInsert = new frmCadastroFornecedoresInsert();
            objFrmCadastroInsert.ShowDialog();
            AtualizaLista();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Fornecedor objFornSelec = ListaForns_dgv.CurrentRow.DataBoundItem as Fornecedor;
            frmCadastroFornecedoresConsulta objFrmCadastroConsulta = new frmCadastroFornecedoresConsulta( objFornSelec );
            objFrmCadastroConsulta.ShowDialog();
            AtualizaLista();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor objFornSelec = ListaForns_dgv.CurrentRow.DataBoundItem as Fornecedor;
            DialogResult confirmarDelete = MessageBox.Show(
                "╚(•⌂•)╝ " + objFornSelec.nomeFornecedor + " ?!", "Confirmar Exclusão",
                MessageBoxButtons.YesNo
            );
            if (confirmarDelete == DialogResult.Yes) {
                FornecedorDAO objFornDAO = new FornecedorDAO();
                objFornDAO.Delete(objFornSelec.idFornecedor);
            }
            AtualizaLista();
        }

    }
}
