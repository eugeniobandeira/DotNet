using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            /* Propriedades:
                - Date (DateTime)
                - Day (int)
                - DayOfWeek(DayOfWeek)
                - DayOfYear(int)
                - Hour (int)
                - Kind (DateTimeKind)
                - Miliseconds (int)
                - Minute (int)
                - Month (int)
                - Second (int)
                - Ticks (long)
                - TimeOfDay (TimeSpan)
                - Year (int)
            */
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Formatação (DateTime -> string)");
            DateTime data = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = data.ToLongDateString();
            string s2 = data.ToLongTimeString();
            string s3 = data.ToShortDateString();
            string s4 = data.ToShortTimeString();
            string s5 = data.ToString();
            string s6 = data.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = data.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine("data.ToLongDateString() :" + s1);
            Console.WriteLine("data.ToLongTimeString() :" + s2);
            Console.WriteLine("data.ToShortDateString() :" + s3);
            Console.WriteLine("data.ToShortTimeString() :" + s4);
            Console.WriteLine("s5 = data.ToString() :" + s5);
            Console.WriteLine("data.ToString(\"yyyy-MM-dd HH:mm:ss )" + s6);
            Console.WriteLine("data.ToString(\"yyyy-MM-dd HH:mm:ss.fff ) :" + s7);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            
            /* Operações com Datetime
            DateTime x = new DateTime(08, 26, 2023, 24, 15);
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */

        }
    }
}
