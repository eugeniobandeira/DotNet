using Course.Entity;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i): ");
                char option = char.Parse(Console.ReadLine());

                
                if (option == 'i')
                {
                    
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customFee));

                } else if (option == 'c')
                {
                   
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));

                } else if (option == 'u')
                {
                    
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Manufature date: ");
                    DateTime manDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manDate));

                } else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price tags:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
