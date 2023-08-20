
using System.Runtime.CompilerServices;
using System;
using System.Globalization;


namespace FuncionarioDados
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double PercentualAumento;

        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }
        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    } 
}   
