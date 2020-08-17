using System;

namespace _7_autoproperties
{
    class Produto {
        private string _nome;
        public double Preço{get; private set;}
        public int Quantidade {get; private set;}

        public Produto(){}

        public Produto(string nome, double preço, int quantidade){
            _nome = nome;
            Preço = preço;
            Quantidade = quantidade;

        }
        public Produto(string nome, double preço){
            _nome = nome;
            Preço = preço;

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
