

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Expressão condicional ternária:
            Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.

            Sintaxe:
            (condição) ? valor_se_verdadeiro : valor_se_falso
            */

            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            string permissao = (idade >= 18) ? "Pode entrar" : "Não pode entrar, você é menor de idade.  ";
            Console.WriteLine(permissao);
        }
    }
}