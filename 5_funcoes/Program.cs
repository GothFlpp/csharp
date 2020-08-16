using System;

namespace _5_funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números, por favor!");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"1º número = {n1}");
            System.Console.WriteLine($"2º número = {n2}");
            System.Console.WriteLine($"3º número = {n3}");

            int big_number = Maior(n1, n2, n3);
            System.Console.WriteLine($"O maior número é : {big_number}");

        }

        static int Maior(int number1, int number2, int number3)
        {
            int number;
            if (number1 > number2 && number1 > number3){
                number = number1;
            }
            else if (number2 > number3){
                number = number2;
            }
            else{
                number = number3;
            }
            return number;
        }


    }
}
