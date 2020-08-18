using System;

namespace _9_structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point ponto;

            ponto.X = 10;
            ponto.Y = 20;

            System.Console.WriteLine(ponto);

            Point ponto2 = new Point();
            System.Console.WriteLine(ponto2);


        }
    }
}
