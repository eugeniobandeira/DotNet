using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products:");
            Console.Write("Item: ");
            string product1 = Console.ReadLine();
            Console.Write("Price: $ ");
            double price1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("item: ");
            string product2 = Console.ReadLine();
            Console.Write("Price: $ ");
            double price2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double sum = price1 + price2;
            double average = sum / 2;

            Console.WriteLine($"You bought one {product1} paying $ {price1.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                $"The second product is one {product2} at the price $ {price2.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"The total amount is {sum.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"The average is $ {average.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}





