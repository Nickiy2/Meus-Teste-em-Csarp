using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_v2
{
    internal class Exercicio_3
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else if (Aprovado() == false)
            {
                return 60.0 - NotaFinal();
            }
            else
            {
                return 0.0;
            }
        }

        public override string ToString()
        {
            if (Aprovado() == true)
            {
                return "NOTA FINAL = "
                      + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                      + "\nAPROVADO";
            }
            else
            {
                return "NOTA FINAL = "
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO"
                    + "\nFALTARAM "
                    + NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }
        }
    }
}
