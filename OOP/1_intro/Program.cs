using System;

namespace _1_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double xArea = x.Area();
            double yArea = y.Area();

            System.Console.WriteLine($"Área de x: {xArea.ToString("F4")}");
            System.Console.WriteLine($"Área de y: {yArea.ToString("F4")}");

            if (xArea > yArea){System.Console.WriteLine("Área de X é maior");}
            else{System.Console.WriteLine("Área de Y é maior");}

        }
    }
}
