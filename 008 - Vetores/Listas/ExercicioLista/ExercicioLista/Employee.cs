using System.Globalization;
namespace ExercicioLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreasySalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }
        public override string ToString()
        {
            return $"Updated list of employees: " +
                $"{Id}, {Name}, $ {Salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
