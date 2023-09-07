using System;
using System.Collections.Generic;

namespace Course.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax(); //Sem as {chaves}

    }
}
