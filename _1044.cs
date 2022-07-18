using System;
using System.Globalization;

namespace uri_judge
{
    public class _1044
    {
        public static void Multiplo()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(entrada[0], CultureInfo.InvariantCulture);
            var b = Convert.ToInt32(entrada[1], CultureInfo.InvariantCulture);
            bool ehMultiplo = false;
            var menor = a;
            var maior = b;

            if (a > b)
            {
                maior = a;
                menor = b;
            }

            for (int i = 0; i <= maior; i++)
            {
                if (menor * i == maior)
                {
                    ehMultiplo = true;
                    break;
                }
            }

            if(ehMultiplo)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
