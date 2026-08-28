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