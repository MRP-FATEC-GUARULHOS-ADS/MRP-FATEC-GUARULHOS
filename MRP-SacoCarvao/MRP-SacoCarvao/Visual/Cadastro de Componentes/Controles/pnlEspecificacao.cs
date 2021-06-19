using System.Drawing;
using System.Windows.Forms;

namespace MRP_SacoCarvao.Cadastro_de_Componentes.Controles
{
    public partial class pnlEspecificacao : Control
    {
        public Label nomeCampo = new Label()
        {
            Location = new Point(0, 0),
            Height = 17,
            Dock = DockStyle.Top,
            Padding = new Padding(0, 0, 0, 4),
            TabIndex = 0
        };
        public TextBox textbox = new TextBox()
        {
            Location = new Point(0, 0),
            Dock = DockStyle.Top,
            ForeColor = SystemColors.ControlText,
            TabIndex = 1
        };

        public pnlEspecificacao()
        {
            this.Height = 48;
            this.Dock = DockStyle.Top;
            this.Text = null;
            this.TabStop = false;

            this.textbox.Parent = this;
            this.nomeCampo.Parent = this;

            base.Controls.Add(this.textbox);
            base.Controls.Add(this.nomeCampo);
        }
    }
}
