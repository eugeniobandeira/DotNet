using System;

namespace TrabalhandoComLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Junior", "Alexia" };

            List<string> atletas = new List<string>(); //Cria uma lista vazia
            atletas.Add("Cristiano");
            atletas.Add("Messi");
            atletas.Add("Bruno Fernandes");
            atletas.Add("Lebron");
            atletas.Add("Formiga");
            atletas.Add("Marcela");
            atletas.Add("Cássio");
            atletas.Add("Marta");
            atletas.Add("Bruna");
            atletas.Insert(3, "Vini Jr");

            foreach (string esportista in atletas)
            {
                Console.WriteLine(esportista);
            }
            Console.WriteLine();

            Console.WriteLine($"Tamanho da lista: {atletas.Count}");

            string primeiroNomeComM = atletas.Find(x => x[0] == 'M');
            Console.WriteLine($"Primeiro nome com 'M': {primeiroNomeComM}");

            string ultimoNomeComM = atletas.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Último nome com 'M': {ultimoNomeComM}");

            int posicao1 = atletas.FindIndex(x => x[0] == 'M');
            Console.WriteLine($"Primeira posicão começando com M: {posicao1}");
            int posicao2 = atletas.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine($"Última posicão começando com M: {posicao2}");

            Console.WriteLine();
            Console.WriteLine("********************************");
            List<string> ListaFiltrada = atletas.FindAll(x => x.Length > 5);
            foreach (string obj in  ListaFiltrada)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("********************************");

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            atletas.Remove("Messi");
            foreach (string esportista in atletas)
            {
                Console.WriteLine(esportista);
            }
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Console.WriteLine("----------------------");
            atletas.RemoveAll(x => x[0] == 'B');
            foreach (string esportista in atletas)
            {
                Console.WriteLine(esportista);
            }
            Console.WriteLine("----------------------");
            atletas.RemoveAt(0);
            foreach (string esportista in atletas)
            {
                Console.WriteLine(esportista);
            }
            Console.WriteLine("#######################");
            atletas.RemoveRange(2,3);
            foreach (string esportista in atletas)
            {
                Console.WriteLine(esportista);
            }
            Console.WriteLine("#######################");

        }
    }
}
