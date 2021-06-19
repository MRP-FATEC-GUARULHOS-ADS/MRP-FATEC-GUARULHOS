using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MRP_SacoCarvao
{
    public partial class frmCadastroProdutoFinal : Form
    {
        public frmCadastroProdutoFinal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            GrupoDAO grupodao = new GrupoDAO();
            grupo = grupodao.Get(int.Parse(txtGrupo.Text));
            Produto produto = new Produto(0, txtNomeProduto.Text, txtDescricao.Text,
            int.Parse(txtQtdeMinima.Text), int.Parse(txtQtdeMaxima.Text), int.Parse(txtQtdeAtual.Text), double.Parse(txtAltura.Text),
            double.Parse(txtComprimento.Text), double.Parse(txtLargura.Text), double.Parse(txtPeso.Text),
            txtEspecificacao.Text, grupo);            

            DialogResult confirmarInsert = MessageBox.Show(
                "( ﾉ ﾟｰﾟ)ﾉ " + produto.nomeProduto + " ?!", "Confirmar Inserção",
                MessageBoxButtons.YesNo
            );
            if (confirmarInsert == DialogResult.Yes)
            {
                ProdutoDAO objProdutoDAO = new ProdutoDAO();

                objProdutoDAO.Insert(produto);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtodao = new ProdutoDAO();
            produtodao.AtualizarLista(DGVTelaPrincipal);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtodao = new ProdutoDAO();
            Grupo grupo = new Grupo();
            GrupoDAO grupodao = new GrupoDAO();
            grupo = grupodao.Get(int.Parse(txtGrupo.Text));
            Produto produto = new Produto(int.Parse(txtIdProduto.Text), txtNomeProduto.Text, txtDescricao.Text,
            int.Parse(txtQtdeMinima.Text), int.Parse(txtQtdeMaxima.Text), int.Parse(txtQtdeAtual.Text), double.Parse(txtAltura.Text),
            double.Parse(txtComprimento.Text), double.Parse(txtLargura.Text), double.Parse(txtPeso.Text),
            txtEspecificacao.Text, grupo);
            produtodao.Update(produto);
            produtodao.AtualizarLista(DGVTelaPrincipal);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtodao = new ProdutoDAO();
            produtodao.Delete(int.Parse(txtIdProduto.Text));
        }
    }
}
