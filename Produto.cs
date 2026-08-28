namespace Abstracao
{
    public class Produto
    {
        //ATRIBUTOS (CARACTERISICAS)

        public string Nome;
        public double Preco;
        public int QtdEmEstoque;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            QtdEmEstoque = quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O produto: {Nome} com valor {Preco} possue {QtdEmEstoque} unidades");
            Console.WriteLine("-----------------------------");

        }
    }
}
