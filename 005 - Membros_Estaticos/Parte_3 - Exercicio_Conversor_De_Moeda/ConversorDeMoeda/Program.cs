using System;
using System.Globalization;
using Conversor;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Moeda");
            Console.WriteLine();

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double valorCompra = double.Parse(Console.ReadLine());

            //Basta chamar pelo nome da classe e colocar o ponto (.) para ver os métodos disponíveis
            double resultado = ConversorDeMoeda.Conversor(cotacao, valorCompra);

            Console.WriteLine($"Valor a ser pago em reais: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
