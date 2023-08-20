
namespace RetanguloCalc
{
    class Rentangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2.0) + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt(((Altura * Altura) + (Largura * Largura)));
        }
    }
}
