using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime representa um instante, é um tipo valor (struct)
            /*
            • Um objeto DateTime internamente armazena:
            • O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de
              janeiro do ano 1 da era comum
            */

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            /*
             Instanciação
             • Construtores
             • DateTime(ano, mes, dia)
             • DateTime(ano, mes, dia, hora, minuto, segundo) [opcional: kind]
             • DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) [opcional: kind]

             Builders
             • DateTime.Now
             • DateTime.UtcNow
             • DateTime.Today [time: 00:00:00]
             • DateTime.Parse(string)
             • DateTime.ParseExact(string, string)
            */


            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo - construtores");
            
            DateTime dt1 = new DateTime(2000, 8, 15);
            DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime dt3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo - Now, UtcNow, Today");
            DateTime d_1 = DateTime.Now;
            DateTime d_2 = DateTime.UtcNow;
            DateTime d_3 = DateTime.Today;
            Console.WriteLine(d_1);
            Console.WriteLine(d_2);
            Console.WriteLine(d_3);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo - Parse (texto para data)");
            DateTime d1_ = DateTime.Parse("2000-08-15");
            DateTime d2_ = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3_ = DateTime.Parse("15/08/2000");
            DateTime d4_ = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1_);
            Console.WriteLine(d2_);
            Console.WriteLine(d3_);
            Console.WriteLine(d4_);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo - ParseExact (Máscara de formatação)");
            DateTime teste1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime teste2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
        }
    }
}