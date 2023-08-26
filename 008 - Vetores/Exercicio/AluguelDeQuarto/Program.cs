using AluguelDeQuarto;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int nQuartos = int.Parse(Console.ReadLine());

            Aluguel[] reserva = new Aluguel[10];

            for (int i = 1; i <= nQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                reserva[quarto] = new Aluguel(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (reserva[i] != null)
                {
                    Console.WriteLine($"{i}: {reserva[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
