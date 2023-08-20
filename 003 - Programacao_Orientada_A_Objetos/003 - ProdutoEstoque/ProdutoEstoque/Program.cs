using System;
using System.Globalization;
using ProdutoEstoque;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            product.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            product.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            product.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Dados do produto: {product}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {product}");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            product.RemoverProdutos(qte);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados após a remoção: {product}");
        }
    }
}
