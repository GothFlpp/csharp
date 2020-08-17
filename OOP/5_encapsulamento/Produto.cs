using System;

namespace _5_encapsulamento
{
    class Produto {
        private string _nome;
        private double _preço;
        private int _quantidade;

        public Produto(){}

        public Produto(string nome, double preço, int quantidade){
            _nome = nome;
            _preço = preço;
            _quantidade = quantidade;

        }
        public Produto(string nome, double preço){
            _nome = nome;
            _preço = preço;

        }

        public string GetNome(){return _nome;}

        public void SetNome(string nome){
            if (nome != null && nome.Length > 1){
                _nome = nome;
            }
            else{
                System.Console.WriteLine("Nome inválido");
            }
        }
        /* não serão implementados pois o usuário não deve poder alterar preço e quantidade do produto
        public void SetPreço(double preço){
            _preço = preço;
        }

        public void SetQuantidade(int quantidade){
            _quantidade = quantidade;
        }
        */
        
        public double GetPreço(){return _preço;}
        public int GetQuantidade(){return _quantidade;}

        public double ValorTotalEmEstoque()
        {
            return _preço * _quantidade;
        }
        public void AdicionarProdutos(int qtd){
            _quantidade = _quantidade + qtd;

        }
        public void RemoverProdutos(int qtd){
            _quantidade = _quantidade - qtd;

        }

    }
}
