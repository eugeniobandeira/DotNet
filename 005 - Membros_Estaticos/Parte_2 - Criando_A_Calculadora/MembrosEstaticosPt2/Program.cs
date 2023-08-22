/* Membros estáticos
   Também chamados de membros de classe (em oposição a membros e instância)
 
  São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados.
  São chamados chamados a partir do próprio nome da classe.

  Aplicações comuns:
    - Classes utilitárias: fornecem operações simples, que podem ser chamadas de forma isolada;
        Ex.: Math.Sqrt(double)
    - Declarações de constantes;

  Uma classe que possui somente membros estáticos pode ser uma classe estática também. Essa classe não poderá ser instânciada.

 */

using System;
using System.Globalization;
using MembrosEstaticosPt2;

namespace MembrosEstaticosPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculadora calc = new Calculadora();
            /*Mesmo se criar diversos objetos (calc1, calc2 etc) e o valor de entrada for o mesmo em todos, o resultado será
            igual */

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            // circ = calc.Circunferencia(raio);
            double circ = Calculadora.Circunferencia(raio);
            //double volume = calc.Volume(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

            //As operações não dependem do objeto
        }

    }
}
