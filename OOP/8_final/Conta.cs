using System;

namespace _8_final
{
    class Conta {

        public int Numero { get; private set; }

        public string Titular { get; set;}

        public double Saldo { get; private set;}
        public Conta (int numero, string titular, double saldo){
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta (int numero, string titular){
            Numero = numero;
            Titular = titular;
        }

        public void Deposito(double valor){
            Saldo += valor;
        }

        public void Saque(double valor){
            Saldo -= (valor + 5);
        }

    }
}
