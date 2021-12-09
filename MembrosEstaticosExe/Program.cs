using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembrosEstaticosExe
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDolar = 0;
            double dolares = 0;
            double reais = 0;

            Console.WriteLine("Qual é a cotação do dólar?");
            cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            reais = ConversorDeMoeda.Converter(cotacaoDolar, dolares);

            Console.WriteLine("Valor a ser pago em reais: " + reais);

            Console.Read();
        }
    }
}
