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
            Console.WriteLine(product.GetNome());

            //O nome não será alterado, pois não atende o critério definido SetNome()
            product.SetNome("T");
            Console.WriteLine(product.GetNome());
            Console.WriteLine(product.GetPreco());
            Console.WriteLine(product.GetQuantidade());
        }
    }
}

