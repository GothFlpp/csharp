using System;

namespace _11_mod_parm_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Calculator.Triple(ref number);
            System.Console.WriteLine(number);

            int number2;
            Calculator.Triple(number, out number2);
            System.Console.WriteLine(number2);
        }
    }
}
