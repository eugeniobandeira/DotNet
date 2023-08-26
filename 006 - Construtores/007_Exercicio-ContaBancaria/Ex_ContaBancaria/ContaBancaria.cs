using System;
using System.Globalization;

namespace Ex_ContaBancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }
        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            //Saldo = depositoInicial;
            Depositar(depositoInicial);
        }
        public ContaBancaria()
        {

        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= (valor + 5.00);
        }
        public override string ToString()
        {
            return $"Dados da conta: \n" +
                $"Conta {NumeroConta}, titular: {NomeTitular}, saldo $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
    
}
