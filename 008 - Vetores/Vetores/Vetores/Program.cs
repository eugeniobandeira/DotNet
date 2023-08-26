using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler um número inteiro N e altura de N pessoas.\n" +
                "Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.");
            Console.WriteLine();

            Console.Write("Número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] lista = new double[n];

            /*double: tipo de dados que o vetor vai conter
             []: indica que é um vetor 
             lista: nome do vetor
             
             new double: instancia o vetor
             [n]: é o tamanho, que será de acordo com o que usuário escolher.
            */

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Altura nº #{i + 1}: ");
                lista[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for(int i = 0; i < n;i++)
            {
                soma+= lista[i];
            }
            double media = soma / n;
            Console.WriteLine($"Média: {media.ToString("F2", CultureInfo.InvariantCulture)} cm");

        }
    }
}
