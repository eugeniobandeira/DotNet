using System;
using System.Globalization;
using FuncionarioDados;

namespace FuncionarioInformacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Programa que calcula o aumento do salário do funcionário");
            Console.WriteLine();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {funcionario}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentualAumento = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(percentualAumento);
            Console.WriteLine($"Dados atualizados: {funcionario}");

        }
    }
}
