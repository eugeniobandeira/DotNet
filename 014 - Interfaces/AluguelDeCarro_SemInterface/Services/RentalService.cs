using Course.Entities;
using System;

namespace Course.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        //Dependency
        private CountryTaxService _countryTaxService = new CountryTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
        public void ProcessInvoice(CarRental carRental) 
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours < 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _countryTaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
