
namespace ParaCada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Laço for each
             Leitura: para cada 'obj' contido em vect, faça: 
            */
            string[] vect = new string[]
            {
                "Maria", "Bob", "John", "Bruna"
            };
            foreach (string pessoa in vect) { //pessoa é o apelido
            Console.WriteLine(pessoa);}
        }
    }
}
