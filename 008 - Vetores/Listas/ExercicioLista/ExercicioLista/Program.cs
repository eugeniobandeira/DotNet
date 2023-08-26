

using ExercicioLista;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());
            
            Employee idReceiveIncrease = employees.Find(x => x.Id == idSalaryIncrease);
            if (idReceiveIncrease != null)
            {
                Console.Write("What is the percentage you´d like to increase? ");
                double percentage = double.Parse(Console.ReadLine());

                idReceiveIncrease.IncreasySalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}