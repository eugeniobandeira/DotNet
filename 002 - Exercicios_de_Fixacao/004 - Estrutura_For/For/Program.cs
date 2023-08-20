using System.Globalization;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com o FOR");
            Console.WriteLine("----------------------");

            Console.Write("Quantos números você quer digitar? ");
            int valores = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= valores; i++)
            {
                Console.Write($"Digite #{i} valor: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"A soma dos valores digitados é {soma}");
        }
    }
}

