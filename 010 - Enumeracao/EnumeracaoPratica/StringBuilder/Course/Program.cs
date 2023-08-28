
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wooow, that´s awesome!");

            Post p1 = new Post(
                DateTime.Now,"Traveling to Europe",
                "Visiting Rome is on the top of my list",
                3);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine("-------------------------------");
            
            Comment c3 = new Comment("They look amazing...");
            Comment c4 = new Comment("Surely they do");

            Post p2 = new Post(
                DateTime.Parse("28/08/2023 08:56:34"), "Tesla´s Super Truck Release",
                "One more astonishing release by the most valued car company in wrold",
                122);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

        }
    }
}