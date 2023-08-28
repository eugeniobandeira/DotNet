using Course.Entities.Enums;
using Course.Entities;
using System;
using System.Diagnostics.Contracts;


namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Associamos a classe Departamento à classe Worker
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Instanciando para garantir que não seja nula

        public Worker() { 
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) //Não adicione no contrutor o que tem relação um para muitos (Contracts)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract )
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }


    }
}
