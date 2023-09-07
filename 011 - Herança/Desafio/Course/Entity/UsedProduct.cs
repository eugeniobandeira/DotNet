using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course.Entity
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return 
                $"Name: {Name} (used) " +
                $"$ {Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Manufature date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
