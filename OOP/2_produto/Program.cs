using System;

namespace _2_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();

            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.WriteLine("Nome: ");
            product.Nome = Console.ReadLine();

            System.Console.WriteLine("Preço: ");
            product.Preço = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantidade: ");
            product.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Dados do produto: {product.Nome}, R$ {product.Preço}, {product.Quantidade} unidades, Total : {product.ValorTotalEmEstoque()}");
            System.Console.WriteLine("Digite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            product.AdicionarProdutos(qtd);
            System.Console.WriteLine($"Dados atualizados: {product.Nome}, R$ {product.Preço}, {product.Quantidade} unidades, Total : {product.ValorTotalEmEstoque()}");

            System.Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());

            product.RemoverProdutos(qtd);
            System.Console.WriteLine($"Dados atualizados: {product.Nome}, R$ {product.Preço}, {product.Quantidade} unidades, Total : {product.ValorTotalEmEstoque()}");


        }
    }
}
