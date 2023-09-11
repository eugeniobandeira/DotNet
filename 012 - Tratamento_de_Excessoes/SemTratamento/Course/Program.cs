
using Course.Entities;
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if(checkout < checkin)
            {
                Console.WriteLine("Error in reservation: check-out must be after check-in");
            }
            else
            {
                Reservation booking = new Reservation(room, checkin, checkout);
                booking.Duration();
                Console.WriteLine("Reservation: " + booking);

                Console.WriteLine();

                Console.WriteLine("Enter the data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(checkin < now || checkout < now) {
                    Console.WriteLine("Error in reservation: check-in date must be for future.");
                } else if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation: check-out must be after check-in.");
                } else
                {
                    booking.UpdateDates(checkin, checkout);
                    Console.WriteLine($"{booking}");
                }

            }
            
        }
    }
}
