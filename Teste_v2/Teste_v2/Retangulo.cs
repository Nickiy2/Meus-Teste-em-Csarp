using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_v2
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return "AREA = "
               + Area().ToString("F2", CultureInfo.InvariantCulture)
               + "\nPERIMETRO = "
               + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
               + "\nDIAGONAL = "
               + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
