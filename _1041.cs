using System;

namespace uri_judge
{
    public class _1041
    {
        public static void CoordenadasDeUmPonto()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            decimal x = Convert.ToDecimal(entrada[0]);
            decimal y = Convert.ToDecimal(entrada[1]);

            if (x == 0 && y == 0) Console.WriteLine("Origem");
            if (x > 0 && y > 0) Console.WriteLine("Q1");
            if (x < 0 && y > 0) Console.WriteLine("Q2");
            if (x < 0 && y < 0) Console.WriteLine("Q3");
            if (x > 0 && y < 0) Console.WriteLine("Q4");
            if (x > 0 && y == 0) Console.WriteLine("Eixo X");
            if (x < 0 && y == 0) Console.WriteLine("Eixo X");
            if (x == 0 && y > 0) Console.WriteLine("Eixo Y");
            if (x == 0 && y < 0) Console.WriteLine("Eixo Y");
        }
    }
}
