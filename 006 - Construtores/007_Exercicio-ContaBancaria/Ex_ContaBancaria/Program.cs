using Ex_ContaBancaria;
using System;
using System.Drawing;
using System.Globalization;

namespace Agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente = new ContaBancaria();
            
            Console.WriteLine("Olá, bem vindo ao banco Genius Ltd.");
            Console.WriteLine();

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                cliente = new ContaBancaria(conta, nome, depositoInicial);
                
            } else
            {
                cliente = new ContaBancaria(conta, nome);
            }
            Console.WriteLine();
            Console.WriteLine($"{cliente}");
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            cliente.Depositar(valor);

            Console.WriteLine($"******************* Extrato ******************* \n" +
                $"{cliente}");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            cliente.Sacar(valor);
            Console.WriteLine($"******************* Extrato ******************* \n" +
                $"{cliente}");
            Console.WriteLine("************************************************");

            Console.ReadLine();

        }
    }
}