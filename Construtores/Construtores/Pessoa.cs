using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string funcaoPessoa { get; set; }


        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.funcaoPessoa = funcaoPessoa;
        }
    }
}
