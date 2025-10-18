using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Estatico_v1
{
    internal class ConversorDeMoesdas
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = quantia * cotacao;
            return total += total * IOF / 100.0;
        }
    }
}
