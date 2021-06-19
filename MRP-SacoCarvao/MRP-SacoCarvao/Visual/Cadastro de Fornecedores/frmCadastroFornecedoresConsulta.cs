using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace MRP_SacoCarvao.Cadastro_de_Fornecedores
{
    public partial class frmCadastroFornecedoresConsulta : Form
    {
        //funcoes
        private void SetCampos()
        {
            H1_lbl.Text = objForn.nomeFornecedor;
        }

        private void AtualizaLista()
        {
            FornecedorComponenteDAO objFornCompDAO = new FornecedorComponenteDAO();
            List<FornecedorComponente> listaFornComps = new List<FornecedorComponente>();
            listaFornComps = objFornCompDAO.GetFornecedorComponentes( objForn );

            var lista = new BindingList<FornecedorComponente>(listaFornComps);
            ListaComps_dgv.DataSource = lista;
        }

        // variaveis
        Fornecedor objForn;

        public frmCadastroFornecedoresConsulta( Fornecedor paramFornecedor )
        {
            InitializeComponent();

            objForn = paramFornecedor;

            SetCampos();
        }

        // funcoes do formulario
        private void FormCadastroFornecedoresConsulta_Load(object sender, System.EventArgs e)
        {
            AtualizaLista();
        }

        private void FormCadastroFornecedoresConsulta_SizeChanged(object sender, System.EventArgs e)
        {
            if (ListaComps_dgv.ColumnCount > 3)
            {
                if (ListaComps_dgv.Width > 460)
                    ListaComps_dgv.Columns[1].Width = ListaComps_dgv.Width - 360;
                else
                    ListaComps_dgv.Columns[1].Width = 100;
            }
        }

        // funcoes dos controles
        /// lista
        private void DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AtualizarComp_btn.Enabled = true;
                ExcluirComp_btn.Enabled = true;
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FornecedorComponente objFornCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as FornecedorComponente;
            frmCadastroFornecedoresConsultaUpdate objFrmFornConUpdate = new frmCadastroFornecedoresConsultaUpdate(objFornCompSelec);
            objFrmFornConUpdate.ShowDialog();
            AtualizaLista();
        }

        /// botoes
        private void Cadastrar_btn_Click(object sender, System.EventArgs e)
        {
            frmCadastroFornecedoresConsultaInsert objFrmFornConInsert = new frmCadastroFornecedoresConsultaInsert( objForn );
            objFrmFornConInsert.ShowDialog();
            AtualizaLista();
        }
        private void Atualizar_btn_Click(object sender, System.EventArgs e)
        {
            FornecedorComponente objFornCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as FornecedorComponente;
            frmCadastroFornecedoresConsultaUpdate objFrmFornConUpdate = new frmCadastroFornecedoresConsultaUpdate(objFornCompSelec);
            objFrmFornConUpdate.ShowDialog();
            AtualizaLista();
        }
        private void Excluir_btn_Click(object sender, System.EventArgs e)
        {
            FornecedorComponente objFornCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as FornecedorComponente;
            DialogResult confirmarDelete = MessageBox.Show(
                "╚(•⌂•)╝ " + objFornCompSelec.componente + " ?!", "Confirmar Exclusão",
                MessageBoxButtons.YesNo
            );
            if (confirmarDelete == DialogResult.Yes)
            {
                FornecedorComponenteDAO objFornCompDAO = new FornecedorComponenteDAO();
                objFornCompDAO.Delete( objFornCompSelec );
            }
            AtualizaLista();
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Editar_btn_Click(object sender, System.EventArgs e)
        {
            frmCadastroFornecedoresUpdate objFrmCadastroUpdate = new frmCadastroFornecedoresUpdate(objForn);
            objFrmCadastroUpdate.ShowDialog();
        }

    }
}
