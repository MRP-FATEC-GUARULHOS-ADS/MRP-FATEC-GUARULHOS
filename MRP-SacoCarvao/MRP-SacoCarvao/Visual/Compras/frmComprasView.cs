using System.Windows.Forms;

namespace MRP_SacoCarvao.Compras
{
    public partial class frmComprasView : Form
    {
        //funcoes
        private void SetCampos(MovimentacaoEstoque paramMovi)
        {
            H1_lbl.Text = paramMovi.idMovimentacaoComponente.ToString();

            Data_tbx.Text = paramMovi.dataMovimentacao.ToString("dd/MM/yyyy");
            Data_tbx.ReadOnly = true;

            TipoDoc_tbx.Text = paramMovi.tipoDocumento;
            TipoDoc_tbx.ReadOnly = true;

            Numero_tbx.Text = paramMovi.nrDocumento;
            Numero_tbx.ReadOnly = true;

            TipoMov_tbx.Text = paramMovi.tipoMovimentacao.ToString();
            TipoMov_tbx.ReadOnly = true;

            Qtde_tbx.Text = paramMovi.qtde.ToString();
            Qtde_tbx.ReadOnly = true;

            Componente_tbx.Text = paramMovi.componente.modeloComponente.ToString();
            Componente_tbx.ReadOnly = true;
        }

        // funcoes dos controles
        public frmComprasView( MovimentacaoEstoque paramMovimentacao )
        {
            InitializeComponent();
            SetCampos( paramMovimentacao );
        }

        private void OK_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
