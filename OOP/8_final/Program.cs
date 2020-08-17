using System;

namespace _8_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o nome do titular: ");
            string titular = Console.ReadLine();

            System.Console.WriteLine("Haverá depósito inicial? (S / N)");
            char resposta = char.Parse(Console.ReadLine());

            Conta conta;


            if (resposta.Equals('S')){
                System.Console.WriteLine("Entre o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                conta = new Conta(numero, titular, saldo);                             
                
            }
            else{
                conta = new Conta(numero, titular);
            }

            System.Console.WriteLine($"Dados da conta: ");
            System.Console.WriteLine($"Conta : {conta.Numero}, Titular : {conta.Titular}, Saldo : R$ {conta.Saldo}");

            System.Console.WriteLine("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);

            System.Console.WriteLine($"Dados da conta atualizados: ");
            System.Console.WriteLine($"Conta : {conta.Numero}, Titular : {conta.Titular}, Saldo : R$ {conta.Saldo}");

            System.Console.WriteLine("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            System.Console.WriteLine($"Conta : {conta.Numero}, Titular : {conta.Titular}, Saldo : R$ {conta.Saldo}");



        }
    }
}
