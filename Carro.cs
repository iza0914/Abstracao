namespace Abstracao
{
    public class Carro
    {
        //ATRIBUTOS (CARACTERISICAS)

        public string Marca = "Volkswagen";
        public string Modelo = "Jetta GT MK3";
        public int Ano = 1992;
        public string Cor = "Chumbo";

        //METODOS (COMPORTAMENTOS)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
            Console.WriteLine("-----------------------------");
        }
    }
}

//EXERCÍCIO 1:

namespace Produto
{
    public class Produto
    {
        //ATRIBUTOS (CARACTERISICAS)

        public string Nome = "Moletom";
        public double Preco = 29.99;
        public int QtdEmEstoque = 95;

        //METODOS (COMPORTAMENTOS)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Produto:" + Nome);
            Console.WriteLine($"Preco:" + Preco);
            Console.WriteLine("Quantidade em Estoque:" + QtdEmEstoque);
            Console.WriteLine("-----------------------------");

        }
    }
}






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