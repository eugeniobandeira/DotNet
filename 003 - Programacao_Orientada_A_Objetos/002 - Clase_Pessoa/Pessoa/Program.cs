using System.Globalization;
using Curso;
using System;

namespace ExercicioPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha");
            Console.WriteLine();

            Pessoa cliente1, cliente2;
            cliente1 = new Pessoa();
            cliente2 = new Pessoa();

            Console.Write("Nome: ");
            cliente1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            cliente1.idade = int.Parse(Console.ReadLine());

            Console.Write("Nome da outra pessoa: ");
            cliente1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            cliente1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (cliente1.idade > cliente2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {cliente1.nome}");
            } else if (cliente1.idade < cliente2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {cliente2.nome}");
            } else
            {
                Console.WriteLine("Ambos tem a mesma idade");
            }
        }
    }
}
