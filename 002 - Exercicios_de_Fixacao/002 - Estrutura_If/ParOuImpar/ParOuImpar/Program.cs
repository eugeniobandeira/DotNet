using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lógica Booleana");

            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            bool resultado = num1 > num2;
            Console.WriteLine($"O número {num1} é maior que {num2}? " + resultado);

            bool n1_impar = num1 % 2 != 0;
            Console.WriteLine($"O número {num1} é impar? " + n1_impar);

            bool n2_impar = num2 % 2 != 0;
            Console.WriteLine($"O número {num2} é impar? " + n2_impar);

            if ((n1_impar || n2_impar) == true)
            {
                Console.WriteLine("Há um valor ímpar aqui..");
            }
            else
            {
                Console.WriteLine("Ambos valores são par!");
            }

            if ((n1_impar && n2_impar) == true)
            {
                Console.WriteLine("Com certeza os dois valores são ímpares! Portanto, a condiçao é verdadeira");
            }
            else
            {
                Console.WriteLine("Condição inválida!");
            }
        }
    }
}
