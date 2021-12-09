using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosExe
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double Converter(double cotacao, double dolares)
        {
            double reais = (dolares * cotacao);
            reais = reais + (IOF * reais);
            return reais;
        }

    }
}
