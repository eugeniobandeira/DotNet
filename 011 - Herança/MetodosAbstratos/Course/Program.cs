
using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (option == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, width, height));
                } else if (option == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                }   
            }
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
