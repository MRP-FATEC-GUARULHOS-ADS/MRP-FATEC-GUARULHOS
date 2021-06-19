using System;

namespace MRP_SacoCarvao
{
    public class MovimentacaoEstoque
    {
        // Atributos
        public int idMovimentacaoComponente { get; set; }
        public DateTime dataMovimentacao { get; set; }
        public string tipoDocumento { get; set; }
        public string nrDocumento { get; set; }
        public char tipoMovimentacao { get; set; }
        public int qtde { get; set; }
        public Componente componente { get; set; }

        // Construtores
        public MovimentacaoEstoque() {
            
        }

        public MovimentacaoEstoque (
            int idMovComp, DateTime data,
            string tipoDoc, string nr,
            char tipoMov, int qnt,
            int idComp
        ) {
            this.idMovimentacaoComponente = idMovComp;
            this.dataMovimentacao = data;
            this.tipoDocumento = tipoDoc;
            this.nrDocumento = nr;
            this.tipoMovimentacao = tipoMov;
            this.qtde = qnt;

            ComponenteDAO compDAO = new ComponenteDAO();
            this.componente = compDAO.Get(idComp);

        }

    }
}
