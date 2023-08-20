namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jogador = new string[] { "Cristiano", "Messi", "Haaland" };
            foreach (string atacante in jogador)
            {
                Console.WriteLine(atacante);

            }
        }
    }
}

