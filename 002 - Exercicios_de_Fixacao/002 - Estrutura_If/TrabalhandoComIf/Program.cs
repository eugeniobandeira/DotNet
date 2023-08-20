using System.Globalization;
namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Operadores comparativos");

            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"O número {num1} é maior que {num2}!");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"Ambos valores são iguais!");
            }
            else
            {
                Console.WriteLine($"O número {num1} é menor que {num2}!");
            }

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"O número {num1} é par!");
            }
            else
            {
                Console.WriteLine($"O número {num1} é impar!");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine($"O número {num2} é par!");
            }
            else
            {
                Console.WriteLine($"O número {num2} é impar!");
            }

        }
    }
}
