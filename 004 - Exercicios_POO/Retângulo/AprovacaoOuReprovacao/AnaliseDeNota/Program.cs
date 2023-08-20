using System;
using System.Globalization;
using AnaliseDeNota;


namespace Analise
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Análise de avaliação trimestral");
            Console.WriteLine();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota 1º tri: ");
            aluno.N1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2º tri: ");
            aluno.N2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3º tri: ");
            aluno.N3 = double.Parse(Console.ReadLine());

            aluno.Nota();
           
            Console.WriteLine(aluno);

            if (aluno.Nota() > 60)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine($"REPROVADO! \n" +
                    $"FALTARAM {60 - aluno.Nota()} PONTOS.");
            }
            Console.ReadLine();
        }
    }
}
