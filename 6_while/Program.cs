using System;

namespace _6_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número, por favor");
            int number = int.Parse(Console.ReadLine());

            if (number < 10){
                while (number < 10){
                    System.Console.WriteLine($"Number = {number}, ainda é menor que 10");
                    number++;
                }
            System.Console.WriteLine($"Number = {number}, Fim do while");
            }
            else{
                System.Console.WriteLine($"Number = {number}, não passara pelo while");
            }
        }
    }
}
