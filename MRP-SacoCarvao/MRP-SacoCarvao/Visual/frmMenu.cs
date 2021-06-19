using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_SacoCarvao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        // funcoes dos objetos
        private void ComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Componentes.frmCadastroComponentes objFrmCadastroComps = 
                new Cadastro_de_Componentes.frmCadastroComponentes
            {
                MdiParent = this
            };
            objFrmCadastroComps.Show();
        }

        private void ProdutosFinaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProdutoFinal objFrmCadastroProds =
                new frmCadastroProdutoFinal
                {
                    MdiParent = this
                };
            objFrmCadastroProds.Show();
        }

        private void GruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroGrupos frmCadastroGrupos = new frmCadastroGrupos
            {
                MdiParent = this
            };
            frmCadastroGrupos.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras.frmCompras objFrmCompras = new Compras.frmCompras
            {
                MdiParent = this
            };
            objFrmCompras.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Fornecedores.frmCadastroFornecedores objFrmFornecedores = 
                new Cadastro_de_Fornecedores.frmCadastroFornecedores
            {
                MdiParent = this
            };
            objFrmFornecedores.Show();
        }
    }
}
