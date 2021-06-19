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
    public partial class frmCadastroGrupos : Form
    {
        public frmCadastroGrupos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GrupoDAO grupoDAO = new GrupoDAO();
            List<Grupo> grupos = new List<Grupo>();
            grupos = grupoDAO.GetGrupos();

            var list = new BindingList<Grupo>(grupos);
            dataGridView1.DataSource = list;  
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            GrupoDAO grupoDAO = new GrupoDAO();
            grupoDAO.Delete(int.Parse(textBox1.Text));
        }
    }
}
