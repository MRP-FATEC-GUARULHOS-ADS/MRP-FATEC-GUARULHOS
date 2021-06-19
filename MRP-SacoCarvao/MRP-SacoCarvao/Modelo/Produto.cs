using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP_SacoCarvao
{
    class Produto
    {
        // Atributos
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descrProduto { get; set; }
        public int qtdeMinEstoque { get; set; }
        public int qtdeMaxEstoque { get; set; }
        public int qtdeAtualEstoque { get; set; }
        public double altura { get; set; }
        public double comprimento { get; set; }
        public double largura { get; set; }
        public double peso { get; set; }
        public string especificacao { get; set; }
        public Grupo grupo;

        // Construtores
        public Produto(){}

        public Produto(int idProduto, string nomeProduto, 
            string descrProduto, 
            int qtdeMinEstoque, int qtdeMaxEstoque, 
            int qtdeAtualEstoque, double altura, 
            double comprimento,double largura, double peso, string 
            especificacao, Grupo grupo)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.descrProduto = descrProduto;
            this.qtdeMinEstoque = qtdeMinEstoque;
            this.qtdeMaxEstoque = qtdeMaxEstoque;
            this.qtdeAtualEstoque = qtdeAtualEstoque;
            this.altura = altura;
            this.comprimento = comprimento;
            this.largura = largura;
            this.peso = peso;
            this.especificacao = especificacao;
            this.grupo = grupo;
        }

    }
}
