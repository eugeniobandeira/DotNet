﻿
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTimeKind e padrão ISO 8601");
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());


            /*
             Tipo enumerado especial que define três valores possíveis para a 
             localidade da data:
                • Local [ fuso horário do sistema. Exemplo: São Paulo = GMT -3 ]
                • Utc [ fuso horário GMT (Greenwich Mean Time) ]
                • Unspecified

            Boa prática:
                 Instanciar e mostrar em formato Local 
            Para converter um DateTime para Local ou Utc, você deve usar:
                 • myDate.ToLocalTime()
                 • myDate.ToUniversalTime()

            */

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Padrão ISO 8601");
            Console.WriteLine();

            DateTime dt1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dt2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("dt1: " + dt1);
            Console.WriteLine("dt1 Kind: " + dt1.Kind);
            Console.WriteLine("dt1 to Local: " + dt1.ToLocalTime());
            Console.WriteLine("dt1 to Utc: " + dt1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dt2: " + dt2);
            Console.WriteLine("dt2 Kind: " + dt2.Kind);
            Console.WriteLine("dt2 to Local: " + dt2.ToLocalTime());
            Console.WriteLine("dt2 to Utc: " + dt2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dt2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //Isso não é bom, primeiro é preciso converter para universal e depois para string
            Console.WriteLine(dt2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            /*
            • Formato:
            yyyy-MM-ddTHH:mm:ssZ
            Z indica que a data/hora está em Utc
            */

        }
    }
}
