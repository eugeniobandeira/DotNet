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
            /*A quanntidade está como public no construtor, logo, podemos alterar o valor em outra classe
            Produto product = new Produto("Tv", 600.15, 10);
            product.Quantidade = 2145;
            */

            Produto product = new Produto("Tv", 600.15, 10);
            Console.WriteLine(product.Nome);

            //O nome não será alterado, pois não atende o critério definido SetNome()
            product.Nome = "J";
            Console.WriteLine(product.Nome);
            Console.WriteLine(product.GetPreco);
            Console.WriteLine(product.GetQuantidade);
        }
    }
}

