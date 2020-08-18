using System;

namespace _10_vetores_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            string name;
            double price;

            for (int vetor = 0; vetor < n; vetor++){
                System.Console.WriteLine($"Insira o nome do {vetor + 1}º produto");
                name = Console.ReadLine();
                System.Console.WriteLine($"Insira o preço do produto {name}");
                price = double.Parse(Console.ReadLine());
                vect[vetor] = new Product(name, price);
            }

            double sum = 0;
            for (int vetor = 0; vetor < n; vetor++){
                System.Console.WriteLine($"Dados do {vetor + 1}º produto : ");
                System.Console.WriteLine($"Nome : {vect[vetor].Name}, Preço : {vect[vetor].Price}");

                sum += vect[vetor].Price;

            }

            double avg = sum / n;
            System.Console.WriteLine($"AVERAGE PRICE : {avg}");
        }
    }
}
