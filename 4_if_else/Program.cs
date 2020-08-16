using System;

namespace _4_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Iniciando condicional");

            if (Console.ReadLine().ToLower() == "bacon"){
                System.Console.WriteLine("Hello Bacon");
            }
            else{
                System.Console.WriteLine("Wait a minute... WHERE'S THE BACON????");
            }

        }
    }
}
