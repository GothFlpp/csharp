using System;

namespace _7_autoproperties
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Preço: ");
            double preço = double.Parse(Console.ReadLine());

            //System.Console.WriteLine("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto product = new Produto(nome, preço);
            //product.Quantidade = 10;

            product.Nome = "Nintendo Switch";
            //product.SetPreço(3900);
            //product.SetQuantidade(10);


            System.Console.WriteLine($"Dados atualizados: {product.Nome}, R$ {product.Preço}, {product.Quantidade} unidades, Total : {product.ValorTotalEmEstoque()}");
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
