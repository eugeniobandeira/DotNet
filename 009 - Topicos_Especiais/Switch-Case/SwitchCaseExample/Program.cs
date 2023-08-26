
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o dia da semana: ");
            int num = int.Parse(Console.ReadLine());
            string dia;
            
            switch (num)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
            }
            Console.WriteLine($"Dia: {dia}");
            /*
            Switch-case é uma estrutura opcional a vários if-else encadeados, quando a condição envolve o teste de 
            valor de uma variável.

            Sintaxe:
            var minhaVariavel = alguma coisa;
            switch (minhaVariavel) {
            case 1:
                Console.WriteLine("Caso 1");
                break;
            case 2:
                Console.WriteLine("Caso 2");
                break;
            default:
                Console.WriteLine("Caso padrão");
                break;
            }
             */
        }
    }
}
