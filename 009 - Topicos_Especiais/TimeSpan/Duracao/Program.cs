using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan representa uma duração entre dois instantes
            //Um objeto TimeSpan internamente armazena uma duração na forma de ticks

            TimeSpan t1 = new TimeSpan(0, 1, 30); //Hora, Minuto, Segundos
            Console.WriteLine("T1: " + t1);
            Console.WriteLine("T1.Ticks: " + t1.Ticks);

            TimeSpan t2 = new TimeSpan(); //Vai resultar em 00:00:00
            Console.WriteLine("Construtor vazio: " + t2);

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine("Convertendo ticks para duração: " + t3);

            TimeSpan t4 = new TimeSpan(2, 11, 20);
            Console.WriteLine("Construtor com 3 argumentos: " + t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine("Construtor com 4 argumentos: " + t5);

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine("Construtor com 5 argumentos: " + t6);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine($"1 dia e meio: {t7}");

            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine($"1 hora e meia: {t8}");

            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine($"1 minuto e meio: {t9}");

            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine($"1 segundo e meio: {10}");

            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine($"1 milisegundo e meio: {t11}");
        }
    }
}