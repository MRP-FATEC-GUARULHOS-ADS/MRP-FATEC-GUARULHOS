using System.Collections.Generic;

namespace MRP_SacoCarvao
{
    public class FornecedorComponente
    {
        // Atributos
        public Fornecedor fornecedor { get; set; }
        public Componente componente { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }

        // Construtores
        public FornecedorComponente() {
            
        }

        public FornecedorComponente(
            Fornecedor forn,
            Componente comp,
            double p
        ) {
            this.fornecedor = forn;
            this.componente = comp;
            this.quantidade = comp.qtdeAtualEstoque;
            this.preco = p;
        }

    }
}
