using System;

namespace _7_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros vc vai digitar?");

            int quantidade = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                if(i < quantidade)
                {
                    System.Console.WriteLine($"Digite o {i}º número:");
                    int number = int.Parse(Console.ReadLine());
                    soma = soma + number;
                    System.Console.WriteLine($"A soma parcial é igual : {soma} ");
                }
                else{
                    System.Console.WriteLine($"Digite o {i}º e último número:");
                    int number = int.Parse(Console.ReadLine());
                    soma = soma + number;
                    System.Console.WriteLine($"A soma final é igual : {soma} ");
                }
            }
        }
    }
}
