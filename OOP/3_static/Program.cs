using System;

namespace _3_static
{
    class Program
    {

        static void Main(string[] args)
        {            
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            System.Console.WriteLine($"Circunferencia : {circ.ToString("F3")}");
         
            double vol = Calculadora.Volume(raio);
            System.Console.WriteLine($"Volume : {vol.ToString("F3")}");
        }  

    }
}
