
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numTaxPayers = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 1;  i <= numTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                if(option == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome,healthExpenditures));

                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Company(name, anualIncome,numberOfEmployees));

                }
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID");

            double totalTax = 0.00;
            foreach(TaxPayer employeer in list)
            {
                totalTax += employeer.Tax();
            }
            foreach (TaxPayer emp in list)
            {
                Console.WriteLine($"{emp.Name} $ {emp.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine($"Total Tax $ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
