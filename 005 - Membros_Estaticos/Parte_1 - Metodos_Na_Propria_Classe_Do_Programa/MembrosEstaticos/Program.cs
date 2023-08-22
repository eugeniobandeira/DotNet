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

namespace MembrosEstaticosPt1
{
    class Program
    {
        //O pi precisa ser declarado como static porque será utilizado na função que é static
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine($"Circunferência: {circ.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");

           
        }
        /*Como a função vai ser utilizada aqui mesmo, não precisa colocar o public, mas precisa colocar o static
         porque ainda está dentro da Main, que é uma função estática */

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
