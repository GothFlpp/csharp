using System;

namespace _10_vetores
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Entre com a quantidade de valores: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i=0;i<n;i++){
                System.Console.WriteLine($"Entre com a {i + 1}ª altura");
                vect[i] = double.Parse(Console.ReadLine());                
            }

            double sum = 0;

            for (int i=0;i<n;i++){
                sum += vect[i];
            }

            double mean = sum / n;

            System.Console.WriteLine($"A soma é {sum}");
            System.Console.WriteLine($"A média é {mean}");

        }
    }
}
