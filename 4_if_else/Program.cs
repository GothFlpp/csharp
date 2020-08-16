using System;

namespace _4_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Iniciando condicional");

            string comida = Console.ReadLine().ToLower();

            if (comida == "bacon"){
                System.Console.WriteLine("Hello Bacon!");
            }
            else if (comida == "eggs"){
                System.Console.WriteLine("Hello Eggs!");
            }
            else if (comida == "coffee"){
                System.Console.WriteLine("Hello Coffee!");
            }
            else{
                System.Console.WriteLine("Wait a minute... WHERE'S MY BREAKFEAST????");
            }

        }
    }
}
