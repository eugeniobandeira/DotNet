
namespace Conversor
{
    class ConversorDeMoeda
    {
        public static double CotacaoDolar;
        public static double ValorDeCompra;
        
        public static double Conversor(double cotacao, double qtd_dolar)
        {
            return cotacao * qtd_dolar + (qtd_dolar * 0.06 * cotacao);
        }
    }
}
