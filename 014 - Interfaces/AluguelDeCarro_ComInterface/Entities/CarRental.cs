using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        //Relationship
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
