using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Componentes
{
    public partial class frmCadastroComponentes : Form
    {
        public frmCadastroComponentes()
        {
            InitializeComponent();
        }

        // funcoes personalizadas
        private void AtualizaLista ()
        {
            ComponenteDAO objCompDAO = new ComponenteDAO();
            List<Componente> listaComponentes = new List<Componente>();
            listaComponentes = objCompDAO.GetComponentes();

            var lista = new BindingList<Componente>(listaComponentes);
            ListaComps_dgv.DataSource = lista;
        }
        private void Pesquisar( string pesquisa)
        {
            ComponenteDAO objCompDAO = new ComponenteDAO();
            List<Componente> listaComponentes = new List<Componente>();

            if (pesquisa != "")
                listaComponentes = objCompDAO.PesquisaComponentes(pesquisa);
            else
                listaComponentes = objCompDAO.GetComponentes();

            var lista = new BindingList<Componente>(listaComponentes);
            ListaComps_dgv.DataSource = lista;
        }

        // funcoes do formulario
        private void FormCadastroComponentes_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void frmCadastroComponentes_SizeChanged(object sender, EventArgs e)
        {
            if (ListaComps_dgv.ColumnCount > 6)
            {
                if (ListaComps_dgv.Width > 760)
                    ListaComps_dgv.Columns[6].Width = ListaComps_dgv.Width - 660;
                else
                    ListaComps_dgv.Columns[6].Width = 100;
            }
        }

        // funcoes dos objetos
        private void DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                Editar_btn.Enabled = true;
                Excluir_btn.Enabled = true;
                /*
                DataGridViewRow row = ListaComps_dgv.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                Pesquisar_tbx.Text = row.Cells[1].Value.ToString();
                */
            }
        }

        private void DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                /*
                DataGridViewRow row = ListaComps_dgv.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                Pesquisar_tbx.Text = row.Cells[1].Value.ToString();
                */
            }
        }

        private void ListaComps_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Componente objCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as Componente;
            frmCadastroComponentesUpdate objFrmCadastroUpdate = new frmCadastroComponentesUpdate(objCompSelec);
            objFrmCadastroUpdate.ShowDialog();
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
            frmCadastroComponentesInsert objFrmCadastroInsert = new frmCadastroComponentesInsert();
            objFrmCadastroInsert.ShowDialog();
            AtualizaLista();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Componente objCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as Componente;
            frmCadastroComponentesUpdate objFrmCadastroUpdate = new frmCadastroComponentesUpdate( objCompSelec );
            objFrmCadastroUpdate.ShowDialog();
            AtualizaLista();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Componente objCompSelec = ListaComps_dgv.CurrentRow.DataBoundItem as Componente;
            DialogResult confirmarDelete = MessageBox.Show(
                "ಠ▃ಠ " + objCompSelec.modeloComponente + " ?!", "Confirmar Exclusão",
                MessageBoxButtons.YesNo
            );
            if (confirmarDelete == DialogResult.Yes) {
                ComponenteDAO objCompDAO = new ComponenteDAO();
                objCompDAO.Delete(objCompSelec.idComponente);
            }
            AtualizaLista();
        }

    }
}
