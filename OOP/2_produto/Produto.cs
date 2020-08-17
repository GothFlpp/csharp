using System;

namespace _2_produto
{
    class Produto {
        public string Nome;
        public double Preço;
        public int Quantidade;

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
