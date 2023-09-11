
using Course.Entities;
using Course.Entities.Exceptions;
using System;
using System.Linq.Expressions;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Enter account data");
            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation booking = new Reservation(room, checkin, checkout);
            booking.Duration();

            Console.WriteLine();
            Console.WriteLine("Reservation: " + booking);
            Console.WriteLine();

            Console.WriteLine("Enter the data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());
            booking.UpdateDates(checkin, checkout);

            Console.WriteLine("Reservation: " + booking);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
         
        }

    }
}

