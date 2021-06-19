using System;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Compras
{
    public partial class frmComprasInsert : Form
    {
        // funcoes
        public void ListaComponentes()
        {
            ComponenteDAO compDAO = new ComponenteDAO();
            BindingSource bs = new BindingSource();
            bs.DataSource = compDAO.GetComponentes();
            Componente_cbb.DataSource = bs;
        }

        // funcoes dos controles
        public frmComprasInsert()
        {
            InitializeComponent();

            ListaComponentes();
        }

        private void Required_TextChanged(object sender, System.EventArgs e)
        {
            if (Data_dtp.Value.ToString() != "" &&
                TipoDoc_cbb.Text != "" && Numero_tbx.Text != "" &&
                TipoMov_cbb.Text != "" && Qtde_tbx.Text != "" &&
                Componente_cbb.Text != "")
            {
                OK_btn.Enabled = true;
            }

        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            Componente comp = Componente_cbb.SelectedItem as Componente;

            MovimentacaoEstoque objMovi = new MovimentacaoEstoque(
                0, Data_dtp.Value, TipoDoc_cbb.Text, Numero_tbx.Text,
                char.Parse(TipoMov_cbb.Text), Int32.Parse(Qtde_tbx.Text), comp.idComponente
            );

            // confirmando insercao
            DialogResult confirmarInsert = MessageBox.Show(
                "(⓿_⓿) " + objMovi.dataMovimentacao + objMovi.nrDocumento + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                MovimentacaoEstoqueDAO objMoviDAO = new MovimentacaoEstoqueDAO();
                objMoviDAO.Insert( objMovi );
                objMoviDAO.UpdateEstoque(objMovi);
            }
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
