﻿using System;
using System.Globalization;
using Construtor;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A instanciação será após capturar os dados
            Produto product = new Produto();
            */
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Instanciação
            Produto product = new Produto(nome, preco, quantidade);

            Console.WriteLine($"Dados do produto: {product}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            product.AdicionarProduto(qte);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {product}");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            product.RemoverProduto(qte);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados após a remoção: {product}");
        }
    }
}

