using System.Collections.Concurrent;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double height;
            char gender;

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Tell us your height: ");
            height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("What is your gender? 'M - Male / F - Female' ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Your name is {name} and you are {age} years old. \n" +
                $"Your height is {height.ToString("F2", CultureInfo.InvariantCulture)} and your gender is {gender} ");
        }
    }
}
