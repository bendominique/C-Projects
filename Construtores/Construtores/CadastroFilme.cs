using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produto = Construtores.Produto;

namespace Construtores
{
    internal class CadastroFilme
    {



        public string ClassificacaoFilme { get; set; }
        public decimal DuracaoFilme { get; set; }
        public string GeneroFilme { get; set; }
        public string TituloFilme { get; set; }
        public double ValorFilme { get; set; }


        static List<CadastroFilme> filmes = new List<CadastroFilme>();

        public CadastroFilme(string ClassificacaoFilme, decimal DuracaoFilme, string GeneroFilme, string TituloFilme, double ValorFilme, double PrecoProduto, string nome)
        {

            this.ClassificacaoFilme = ClassificacaoFilme;
            this.ValorFilme = PrecoProduto;
            this.DuracaoFilme = DuracaoFilme;
            this.GeneroFilme = GeneroFilme;
            this.TituloFilme = TituloFilme;

            filmes.Add(this);

        }
        //Exibir os filmes que já foram cadastrados

        public static void ExibirFilmes()
        {
            Console.WriteLine("Filmes Cadastrados:");
            foreach (var filme in filmes)
            {
                Console.WriteLine($"Título: {filme.TituloFilme}, Duração: {filme.DuracaoFilme} minutos, Classificação: {filme.ClassificacaoFilme}, Gênero: {filme.GeneroFilme}, Valor: R${filme.ValorFilme}");
            }
        }

        public static CadastroFilme CadastroManual()
        {

            Console.WriteLine($"Digite o Título do Filme");
            string tituloFilme = Console.ReadLine();

            Console.WriteLine($"\n Digite a Duração do Filme (em minutos)");
            if (!decimal.TryParse(Console.ReadLine(), out decimal duracao)) //Realiza uma verificação booleana para TryParse, caso o número incluso não seja um número retorna erro;
            {
                Console.WriteLine("Duração inválida. Por favor, insira um número válido.");
                return null;
            }

            Console.WriteLine($"\n Digite a Classificação do Filme");
            string classificacaoFilme = Console.ReadLine();

            Console.WriteLine($"\n Digite o Gênero do Filme");
            string generoFilme = Console.ReadLine();

            Console.WriteLine($"\n Digite o Valor do Filme");
            if (!double.TryParse(Console.ReadLine(), out double valor)) //Realiza uma verificação booleana para TryParse, caso o número incluso não seja um número retorna erro;
            {
                Console.WriteLine("Duração inválida. Por favor, insira um valor válido.");
                return null;
            }

            // Cria uma nova instância de CadastroFilme com os dados fornecidos
            Console.WriteLine("Filme cadastrado com sucesso!");

            CadastroFilme novoFilme = new CadastroFilme(classificacaoFilme, duracao, generoFilme, tituloFilme, valor, valor, tituloFilme);

            return novoFilme;
        }

        public static void RemoverFilme(string TituloFilme)
        {
            CadastroFilme filmeRemovido = filmes.Find(filme => filme.TituloFilme.Equals(TituloFilme, StringComparison.OrdinalIgnoreCase));

            if (filmeRemovido != null)
            {
                filmes.Remove(filmeRemovido);
                Console.WriteLine($"O filme \"{TituloFilme}\" foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Filme não encontrado na lista.");
            }
        }


    }
}
