using System.Globalization;

namespace Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //O construtor tem o mesmo nome que a classe
        //O nome do parâmetro recebido é escrito com letra em caixa baixa
        //No momento que iniciar um produto, será obrigatório informar o nome, preco e quantidade
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
