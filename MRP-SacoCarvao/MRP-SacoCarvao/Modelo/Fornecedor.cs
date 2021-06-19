using System.Collections.Generic;

namespace MRP_SacoCarvao
{
    public class Fornecedor
    {
        // Atributos
        public int idFornecedor { get; set; }
        public string nomeFornecedor { get; set; }
        public string tipoLogradouro { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string urlSite { get; set; }
        public FornecedorComponente componentes { get; set; }

        // Construtores
        public Fornecedor() {
            
        }

        public Fornecedor(
            int idForn,
            string nomeForn, string tipoLogr, string logr,
            string n, string comp,
            string CEP, string b, string c, string UF,
            string tel, string cel,
            string e, string site
        ) {
            this.idFornecedor = idForn;
            this.nomeFornecedor = nomeForn;
            this.tipoLogradouro = tipoLogr;
            this.logradouro = logr;
            this.numero = n;
            this.complemento = comp;
            this.cep = CEP;
            this.bairro = b;
            this.cidade = c;
            this.uf = UF;
            this.telefone = tel;
            this.celular = cel;
            this.email = e;
            this.urlSite = site;
        }

    }
}
