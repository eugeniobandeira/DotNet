using System;
using System.Globalization;
using System.Reflection.Metadata;
using Construtor;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto product = new Produto("Tv", 600.15, 10);
            Console.WriteLine(product.Nome);

            product.Nome = "J";
            Console.WriteLine(product.Nome);
            Console.WriteLine(product.Preco);
            Console.WriteLine(product.Quantidade);
        }
    }
}

