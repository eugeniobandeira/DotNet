

namespace MembrosEstaticosPt2
{
    class Calculadora
    {
        /*Quando adicionamos o prefixo static após o public, neste contexto, não precisaremos mais instanciar o
        objeto na Program.cs. 
        Sem o static, seria preciso instanciar um objeto do tipo Calculadora*/

        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
