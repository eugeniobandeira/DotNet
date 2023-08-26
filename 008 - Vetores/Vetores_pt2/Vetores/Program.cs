using System;
using System.Globalization;
using Vetores;

namespace Vetor
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N produtos.\n" +
                "Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos itens.");
            Console.WriteLine();

            Console.Write("Número de itens: ");
            int n = int.Parse(Console.ReadLine());

            Product[] lista = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome #{i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Preço #{i + 1}: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                lista[i] = new Product { Nome = nome, Preco = preco }; //Não tem o construtor na classe Product  
            }
            double soma = 0.0;
            for(int i = 0;i < n;i++)
            {
                soma += lista[i].Preco;
            }
            double media = soma / n;
            Console.WriteLine();
            Console.WriteLine($"Preço Médio  : $ {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
