using CalculoDeArea;
using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área sem orientação a objetos");

            /* Não será mais útil
            double xA,xB, xC, yA, yB, yC;
            */

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine();

            Console.WriteLine("Entre com as medidas do triângulo X:");

            /* Subistituindo
            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            */
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            /* Subistituindo
            yA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            */
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de x: {areaX.ToString("F4",CultureInfo.InvariantCulture)} m2");
            Console.WriteLine($"Área de y: {areaY.ToString("F4", CultureInfo.InvariantCulture)} m2");


            if(areaX > areaY)
            {
                Console.WriteLine("X é a área maior");
            } else if (areaX < areaY)
            {
                Console.WriteLine("Y é a área maior");
            } else
            {
                Console.WriteLine("Ambas áreas são iguais");
            }
        }
    }
}
