using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {

            return ((AnualIncome <= 20000.00) ? AnualIncome * 0.15 : AnualIncome * 0.25) -
                ((HealthExpenditures > 0) ? HealthExpenditures * 0.5 : 0.00);
                
        }
    }
}
