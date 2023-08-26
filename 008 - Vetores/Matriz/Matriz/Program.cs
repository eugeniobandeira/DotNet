
namespace AulaMatriz
{
    class Program
    {
           static void Main(string[] args)
        {
            /*
            double[,] matriz = new double[2, 3]; //double é o tipo, ela tem 2 linhas e 3 colunas
            Console.WriteLine(matriz.Length); //Número de elementos que a matriz tem no total
            Console.WriteLine(matriz.Rank); //Quanto é a primeira dimensão da matriz? 2 (que é a quantidade de linhas).
            Console.WriteLine(matriz.GetLongLength(0)); //A primeira dimensão que é 2
            Console.WriteLine(matriz.GetLongLength(1)); //A segunda dimensão que é 3, quantidade de colunas
            */

            Console.Write("Informe o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            Console.WriteLine(mat);
            for (int i = 0; i < n; i++) //Percorre as linhas
            {
                Console.Write($"Informes os valores na mesma linha, sepados por espacço: ");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) //Percorre as colunas
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Main diagonal");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"{mat[i,i]} ");
            }
            Console.WriteLine("Negative numbers");
            int count = 0;
            for(int i = 0;i < n;i++)
            {
                for (int j = 0;j < n;j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}