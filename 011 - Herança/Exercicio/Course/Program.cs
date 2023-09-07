using Course.Entities;
using System.Globalization;
using System.Collections.Generic;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n;  i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());
                if(isOutsourced == 'n' || isOutsourced == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, hours, valuePerHour));
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hours: ");
                    double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
             
            }
            Console.WriteLine();
            Console.WriteLine("*************** PAYMENTS ***************");
            foreach (Employee employee in list)
            {
                Console.WriteLine($"{employee.Name}, $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine("*******************************************");

        }
    }
}