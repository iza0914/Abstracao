using Abstracao;

namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO O OBJETO (INSTANCIAÇÃO)
            Carro meuJetta = new Carro();
            meuJetta.Marca = "Volkswagen";
            meuJetta.Modelo = " Jetta GT MK3";
            meuJetta.Ano = 1992;
            meuJetta.Cor = "Chumbo";

            Carro carroVizinho = new Carro();
            carroVizinho.Marca = "Fiat";
            carroVizinho.Modelo = "Uno";
            carroVizinho.Ano = 2010;
            carroVizinho.Cor = "Prata";

            Console.WriteLine("Informaçãoes do meu carro:");
            meuJetta.ExibirInformacoes();

            Console.WriteLine("Informaçãoes do carro do vizinho:");
            carroVizinho.ExibirInformacoes();

            Console.ReadKey();


        }

    }
}

//Exercício 1:

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO O OBJETO (INSTANCIAÇÃO)

            Produto meuProduto = new Produto();
            meuProduto.Nome = "Moletom";
            meuProduto.Preco = 29.99;
            meuProduto.QtdEmEstoque = 95;

            Console.WriteLine("Informaçãoes do meu carro:");
            meuProduto.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}



