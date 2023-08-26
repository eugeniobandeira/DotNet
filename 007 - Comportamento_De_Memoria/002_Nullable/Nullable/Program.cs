using System;
using System.Xml;

namespace ValorNulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null; erro double é um valor não nulo

            // Nullable<double> x = null; isso ainda não é o ideal

            double? x = null; //O valor é opcional
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue());
            //Console.WriteLine(y.HasValue());

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X é nulo");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é nulo");
            }


            /*
            Métodos:
                GetValueOrDefault;
                HasValue;
                Value (lança uma exceção se não houver valor);

            Um nullable não pode ser atribuído para um struct comum
            */
            Console.WriteLine();
            Console.WriteLine("Teste de coalescência nula");
            //Operador de coalescência nula
            double? a = null;
            double? b = 10.00;
            double c = a ?? 5;
            double d = b ?? 5;
            Console.WriteLine("C " + c);
            Console.WriteLine("D " + d);
        }
    }
}
