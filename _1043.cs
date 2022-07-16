using System;
using System.Globalization;

namespace uri_judge
{
    public class _1043
    {
        public static void CalcularTriangulo()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            var a = Convert.ToDecimal(entrada[0], CultureInfo.InvariantCulture);
            var b = Convert.ToDecimal(entrada[1], CultureInfo.InvariantCulture);
            var c = Convert.ToDecimal(entrada[2], CultureInfo.InvariantCulture);

            var ehTriangulo = (b - c) < a && a < (b + c) && (a - c) < b && b < (a + c) && (a - b) < c && c < (a + b);
            if (ehTriangulo)
            {
                var perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + Decimal.Round(perimetro, 1).ToString().Replace(",", "."));
            }
            else
            {
                var area = ((a + b) * c) / 2;

                Console.WriteLine("Area = " + Decimal.Round(area, 1).ToString().Replace(",", "."));
            }
        }
    }
}
