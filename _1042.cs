using System;

namespace uri_judge
{
    public class _1042
    {
        public static void SortSimples()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int valor1 = Int32.Parse(entrada[0]);
            int valor2 = Int32.Parse(entrada[1]);
            int valor3 = Int32.Parse(entrada[2]);
            string resultado = null;

            if (valor1 < valor2 && valor1 < valor3)
            {
                if (valor2 < valor3)
                {
                    resultado = $"{valor1}\n" +
                                $"{valor2}\n" +
                                $"{valor3}\n";
                }
                else
                {
                    resultado = $"{valor1}\n" +
                                $"{valor3}\n" +
                                $"{valor2}\n";
                }
            }
            else if (valor2 < valor1 & valor2 < valor3)
            {
                if (valor1 < valor3)
                {
                    resultado = $"{valor2}\n" +
                                $"{valor1}\n" +
                                $"{valor3}\n";
                }
                else
                {
                    resultado = $"{valor2}\n" +
                                $"{valor3}\n" +
                                $"{valor1}\n";
                }

            }
            else
            {
                if (valor1 < valor2)
                {
                    resultado = $"{valor3}\n" +
                                $"{valor1}\n" +
                                $"{valor2}\n";
                }
                else
                {
                    resultado = $"{valor3}\n" +
                                $"{valor2}\n" +
                                $"{valor1}\n";
                }

            }

            resultado += $"\n" +
                         $"{valor1}\n" +
                         $"{valor2}\n" +
                         $"{valor3}";

            Console.WriteLine(resultado);
        }
    }
}
