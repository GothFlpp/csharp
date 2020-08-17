using System;

namespace _4_construtores
{
    class Produto {
        public string Nome;
        public double Preço;
        public int Quantidade;

        public Produto(string nome, double preço, int quantidade){
            Nome = nome;
            Preço = preço;
            Quantidade = quantidade;

        }
        public Produto(string nome, double preço){
            Nome = nome;
            Preço = preço;

        }

        public double ValorTotalEmEstoque()
        {
            return Preço * Quantidade;
        }
        public void AdicionarProdutos(int qtd){
            Quantidade = Quantidade + qtd;

        }
        public void RemoverProdutos(int qtd){
            Quantidade = Quantidade - qtd;

        }

    }
}
