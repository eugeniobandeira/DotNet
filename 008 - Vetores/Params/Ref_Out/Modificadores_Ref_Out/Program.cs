
using ModificadorRef;

namespace Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //A palavra ref exige que a variável seja iniciada
            Console.WriteLine("Triplo");
            int a = 10;
            Calculator.Triple(ref a); //Vale 30
            Console.WriteLine(a);

            Console.WriteLine();

            Console.WriteLine("Dobro");
            int dobro;
            Calculator.Doublee(a, out dobro); //Vale 60
            Console.WriteLine(dobro);
            //O valor de origem será a variável "a" e o resultado será guardado na var dobro
        }
    }
}
