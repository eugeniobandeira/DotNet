using System;
using System.Globalization;
using RetanguloCalc;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rentangulo rentangulo = new Rentangulo();

            Console.WriteLine("Calculando - Rentângulo");
            Console.WriteLine();
            Console.Write("Informe a altura: ");
            rentangulo.Altura = double.Parse(Console.ReadLine());
            Console.Write("Informe a largura: ");
            rentangulo.Largura = double.Parse(Console.ReadLine());

            double area = rentangulo.Area();
            double perimetro = rentangulo.Perimetro();
            double diagonal = rentangulo.Diagonal();

            Console.WriteLine($"Área: {area.ToString("F2",CultureInfo.InvariantCulture)} m2");
            Console.WriteLine($"Perimetro: {perimetro.ToString("F2", CultureInfo.InvariantCulture)} m");
            Console.WriteLine($"Diagonal: {diagonal.ToString("F2", CultureInfo.InvariantCulture)} m");
        }
    }
}