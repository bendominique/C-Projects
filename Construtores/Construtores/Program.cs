using Pessoa = Construtores.Pessoa;
using CadastroFilme = Construtores.CadastroFilme;

class Program
{
    static void Main(string[] args)
    {
        //// Criação de um objeto da classe Pessoa
        //Pessoa pessoa = new Pessoa("João", 30);
        //// Exibindo os dados da pessoa
        //Console.WriteLine($"Nome: {pessoa.nome}, Idade: {pessoa.idade}");

        Console.WriteLine("Seja Bem - Vindo a LocaMovies \n");

        Console.WriteLine("Você é: ");
        Console.WriteLine("1 - Cliente \n2 - Funcionário \n3 - Administrador \n4 - Gerente \n");

        string funcaoPessoa = Console.ReadLine();

        string nome = "";
        int idade = 0;


        switch (funcaoPessoa)
        {
            case "1":
            funcaoPessoa = "Cliente";
            Console.WriteLine("Digite o seu Nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("\nDigite a sua Idade: ");
            idade = int.Parse(Console.ReadLine());


            Console.WriteLine($"\n{nome} Você deseja: ");
            Console.WriteLine("\n1 - Alugar Filme \n2 - Comprar Filme \n3 - Sair \n");

            string AcaoCliente = Console.ReadLine();

                switch (AcaoCliente)
                {
                    case "1":
                        Console.WriteLine("Você escolheu Alugar Filme.");
                        Console.WriteLine("\nDigite o Título do Filme que deseja alugar: ");
                        string tituloFilme = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Você escolheu Comprar Filme.");
                        Console.WriteLine("\nDigite o Título do Filme que deseja comprar: ");
                        tituloFilme = Console.ReadLine();
                        

                        break;

                    case "3":
                        Console.WriteLine("Você escolheu Sair.");
                        Console.WriteLine("Obrigado por usar a LocaMovies!");
                        return; // Encerra o programa
                }

                break;
            case "2":
            funcaoPessoa = "Funcionário";
                Console.WriteLine("Digite o seu Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine($"\n{nome} Você deseja: ");
                Console.WriteLine("\n1 - Cadastrar Filme \n2 - Remover Filme \n3 - Hospedar Filme \n4 - Exibir Filmes \n5 - Sair");

                string AcaoFuncionario = Console.ReadLine();

                    switch (AcaoFuncionario)
                    {
                    case "1":

                        Console.WriteLine("Você escolheu Cadastrar Filme.");
                        CadastroFilme.CadastroManual();

                        CadastroFilme.ExibirFilmes();
                        return AcaoFuncionario;

                    case "2":
                        Console.WriteLine("Você escolheu Remover Filme.");
                        Console.WriteLine("\nDigite o Título do Filme que deseja remover: ");
                        string TituloFilme = Console.ReadLine();

                        CadastroFilme.RemoverFilme(TituloFilme);
                        break;

                    //case "3":
                    //    Console.WriteLine("Você escolheu Hospedar Filme.");
                    //    Console.WriteLine("\nDigite o Título do Filme que deseja hospedar: ");
                    //    string TituloFilme = Console.ReadLine();
                    //    break;

                    case "4":
                        CadastroFilme.ExibirFilmes();
                        break;

                }

                //Console.WriteLine("Digite O Título do Filme que será cadastrado");
                //string tituloFilme = Console.ReadLine();

                //Console.WriteLine("\nDigite o Gênero do Filme");
                //string generoFilme = Console.ReadLine();

                //Console.WriteLine("\nDigite a Duração do Filme (em minutos)");
                //decimal duracaoFilme = decimal.Parse(Console.ReadLine());

                //Console.WriteLine("\nDigite a Classificação do Filme");
                //string classificacaoFilme = Console.ReadLine();

                //Console.WriteLine("\nDigite o Valor do Filme");
                //double valorFilme = double.Parse(Console.ReadLine());
                //break;



                break;
            case "3":
            funcaoPessoa = "Administrador";
            break;
            case "4":
            funcaoPessoa = "Gerente";
            break;

        }

       
    }
}