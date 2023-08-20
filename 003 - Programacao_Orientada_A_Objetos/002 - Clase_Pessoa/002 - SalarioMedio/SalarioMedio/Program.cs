using System;
using System.Globalization;
using FuncionarioSalario;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários");
            Console.WriteLine();

            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nome do outro funcionário: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (func1.Salario + func2.Salario) / 2.0;

            Console.WriteLine();

            Console.WriteLine($"O salário médio é {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
