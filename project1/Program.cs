using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Bacon";
            Console.WriteLine(x);
            System.Console.WriteLine(x + " and Eggs!");

            int number = 12;
            System.Console.WriteLine($"Estou com fome, gostaria de comer {number} {x}s");

            number -= 8;
            System.Console.WriteLine($"Ainda estou com fome, mais {number} {x}s, por favor");


            number--;
            System.Console.WriteLine($"Mais {number} {x}s");

            string resposta = Console.ReadLine();

            System.Console.WriteLine($"{resposta} por hoje");

        }
    }
}
