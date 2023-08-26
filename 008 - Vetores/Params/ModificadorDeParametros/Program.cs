
using ModificadorDeParametros;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem o params na fuñção, é preciso instanciar o vetor
            int result = Calculator.Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Console.WriteLine($"Resultado: {result}");

            //Com o params, não é preciso instaciar o vetor
            int res = Calculator.Sum(15, 20, 58, 32);
            Console.WriteLine($"Resultado: {res}");

        }
    }
}