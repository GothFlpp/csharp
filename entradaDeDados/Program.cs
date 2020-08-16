using System;

namespace entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            //split
            System.Console.WriteLine("1º Split");
            string lista = Console.ReadLine();
            string[] vet = lista.Split(",");
            System.Console.WriteLine(vet[0]);
            System.Console.WriteLine(vet[2]);
            System.Console.WriteLine(vet[1]);

            System.Console.WriteLine("2º Parse int");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Você digitou o número : {number}");

            System.Console.WriteLine("3º parse char");
            char letra = char.Parse(Console.ReadLine());
            System.Console.WriteLine($"Você digitou a letra : {letra}");

        }
    }
}
