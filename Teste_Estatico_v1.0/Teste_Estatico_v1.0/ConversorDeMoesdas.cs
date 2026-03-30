using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Estatico_v1._0
{
    internal class ConversorDeMoesdas
    {
        public static double IOF = 6.0d;

        public static double ConverterDolarParaReal(double cotacao, double quantia) 
        {
            double total = quantia * cotacao;
            return total += total * IOF / 100.0;
        }
    }
}
