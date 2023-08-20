using System.Globalization;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minha primeira função");

            Console.Write("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite mais um valor: ");
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine();

            Console.WriteLine($"O maior número é {resultado}");

        }
        static int Maior(int a, int b, int c)
        {
            int maior = 0;
            if ((a > b) && (a > c))
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }
    }
}