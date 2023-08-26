using System.Globalization;

namespace Construtor
{
    class Produto
    {
        /*Sempre que for um atributo private, o nome começa com underline + letras em caixa baixa
        public string Nome;
        public double Preco;
        public int Quantidade;
        */
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        /*Para permitir usar esses métodos em outra classe, é preciso do Get e Set
        public string GetNome()
        {
            return _nome;
        }
        Para alterar o nome
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1) {
                _nome = nome;
                //Só vai aceitar se o nome não for nulo e maior que 1 caractere
            } 
        }
        */


        //Para obter o preço
         
        public double GetPreco
        {
            get { return _preco; }
        }
        public int GetQuantidade
        {
            get { return _quantidade; }
        }
       
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        //Quando usa o void, não tem return
        public void AdicionarProduto(int  quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return $"{_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades. \n" +
                $"Total: $ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
