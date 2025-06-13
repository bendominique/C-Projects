using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        public string nomeProduto { get; set; }
        public double precoProduto { get; set; }
        public int quantidadeProduto { get; set; }

        public Produto(string nomeProduto, double precoProduto, int quantidadeProduto)
        {
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
            this.quantidadeProduto = quantidadeProduto;
        }
    }
}
