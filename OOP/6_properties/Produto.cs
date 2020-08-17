using System;

namespace _6_properties
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
        //Usando a propertie Nome para acionar set e get por meio de uma sintaxe mais amigavel
        public string Nome {
            get {return _nome;}
            set{
                if (value != null && value.Length > 1){
                    _nome = value;
                }
                else{
                    System.Console.WriteLine("Nome inválido");
                }
            }

        }

        public double Preço {
            get {return _preço;}
        }

        public int Quantidade {
            get {return _quantidade;}
        }

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
