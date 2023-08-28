
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); //Apaga os espaços em branco
            int n1 = original.IndexOf("bc"); //Primeira ocorrência (índice) de "bc"
            int n2 = original.LastIndexOf("bc"); //Última ocorrência (índice) de "bc"
            string s4 = original.Substring(3); //Corta a partir do índice 3
            string s5 = original.Substring(3, 5); //Corta 5 caracteres a partir do índice 3
            string s6 = original.Replace('a', 'x'); //Troca o 'a' pelo 'x'
            string s7 = original.Replace("abc", "xy"); //Troca as ocorrências de 'abc' por 'xy'
            bool b1 = String.IsNullOrEmpty(original); //Testa se a strig está em branco ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //Testa se é nula ou um monte de espaço em branco
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
     