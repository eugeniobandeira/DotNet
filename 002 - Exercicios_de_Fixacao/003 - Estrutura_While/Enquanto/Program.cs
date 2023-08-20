
using System.Globalization;

namespace Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com While");

            Console.Write("Digite um número: ");

            int x = int.Parse(Console.ReadLine());

            while (x > 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"A raiz de {x} é {raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.Write("Digite outro número: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Programa encerrado, não existe raiz negativa!");
        }
    }
}

