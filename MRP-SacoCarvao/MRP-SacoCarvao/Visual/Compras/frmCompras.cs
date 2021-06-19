using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Compras
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista ()
        {
            MovimentacaoEstoqueDAO objMoviDAO = new MovimentacaoEstoqueDAO();
            List<MovimentacaoEstoque> listaMovimentacoes = objMoviDAO.GetMovimentacoes();

            var lista = new BindingList<MovimentacaoEstoque>(listaMovimentacoes);
            ListaCompras_dgv.DataSource = lista;
        }
        private void Pesquisar( string pesquisa)
        {
            MovimentacaoEstoqueDAO objMoviDAO = new MovimentacaoEstoqueDAO();
            List<MovimentacaoEstoque> listaMovimentacoes = new List<MovimentacaoEstoque>();

            if (pesquisa != "")
                listaMovimentacoes = objMoviDAO.PesquisaMovimentacoes(pesquisa);
            else
                listaMovimentacoes = objMoviDAO.GetMovimentacoes();

            var lista = new BindingList<MovimentacaoEstoque>( listaMovimentacoes );
            ListaCompras_dgv.DataSource = lista;
        }

        // funcoes do formulario
        private void FormCompras_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void frmCompras_SizeChanged(object sender, EventArgs e)
        {
            if (ListaCompras_dgv.ColumnCount > 6)
            {
                if (ListaCompras_dgv.Width > 760)
                    ListaCompras_dgv.Columns[6].Width = ListaCompras_dgv.Width - 660;
                else
                    ListaCompras_dgv.Columns[6].Width = 100;
            }
        }

        // funcoes dos objetos
        private void DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                Visualizar_btn.Enabled = true;
            }
        }

        private void DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

            }
        }

        private void ListaCompras_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MovimentacaoEstoque objMoviSelec = ListaCompras_dgv.CurrentRow.DataBoundItem as MovimentacaoEstoque;
            frmComprasView objFrmComprasView = new frmComprasView( objMoviSelec );
            objFrmComprasView.ShowDialog();
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

        private void Registrar_btn_Click(object sender, EventArgs e)
        {
            frmComprasInsert objFrmComprasInsert = new frmComprasInsert();
            objFrmComprasInsert.ShowDialog();
            AtualizaLista();
        }

        private void Visualizar_btn_Click(object sender, EventArgs e)
        {
            MovimentacaoEstoque objMoviSelec = ListaCompras_dgv.CurrentRow.DataBoundItem as MovimentacaoEstoque;
            frmComprasView objFrmComprasView = new frmComprasView( objMoviSelec );
            objFrmComprasView.ShowDialog();
        }

        private void Estoque_btn_Click(object sender, EventArgs e)
        {
            Cadastro_de_Componentes.frmCadastroComponentes objFrmComponentes = 
                new Cadastro_de_Componentes.frmCadastroComponentes();
            objFrmComponentes.ShowDialog();
        }

        private void Fornecedores_btn_Click(object sender, EventArgs e)
        {
            Cadastro_de_Fornecedores.frmCadastroFornecedores objFrmFornecedores =
                new Cadastro_de_Fornecedores.frmCadastroFornecedores();
            objFrmFornecedores.ShowDialog();
        }

    }
}
