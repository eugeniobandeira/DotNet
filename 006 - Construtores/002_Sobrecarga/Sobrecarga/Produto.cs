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
            //Nome = nome estamos dizendo que o atributo recebe o parâmetro de entrada
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Construtor que recebe somente o nome e o preço
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            //Mas nem precisa colocar porque o zero já padrão
            Quantidade = 0;
        }
        //Para instanciar sem valor nenhum, é só fazer o construtor vazio
        public Produto()
        {

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
