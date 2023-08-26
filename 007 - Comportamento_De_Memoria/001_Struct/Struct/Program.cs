using System;
using ExemploDeStruct;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não é preciso instanciar usando new
            Point ponto;

            ponto.X = 10;
            ponto.Y = 10;
            Console.WriteLine(ponto);

            ponto = new Point();
            Console.WriteLine(ponto);
        }
    }
}