using System;
using System.Globalization;

using System.Runtime.InteropServices;

namespace AnaliseDeNota
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;


        public double Nota()
        {
            return N1 + N2 + N3;
        }

        public override string ToString()
        {
            return $"Aluno: {Nome}, Nota final {Nota().ToString("F2",CultureInfo.InvariantCulture)}";
            
        }
    }
}
