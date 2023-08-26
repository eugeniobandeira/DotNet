using System.Globalization;

namespace Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        //Palavra this para referenciar outro construtor em um construtor
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade= quantidade;
        }
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        //Quando usa o void, não tem return
        public void AdicionarProduto(int  quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades. \n" +
                $"Total: $ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
