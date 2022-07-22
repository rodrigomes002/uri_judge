using System;
using System.Globalization;

namespace uri_judge
{
    public class _1045
    {
        public static void TipoDeTriangulo()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            var a = Convert.ToDecimal(entrada[0], CultureInfo.InvariantCulture);
            var b = Convert.ToDecimal(entrada[1], CultureInfo.InvariantCulture);
            var c = Convert.ToDecimal(entrada[2], CultureInfo.InvariantCulture);

            decimal[] lados = { a, b, c };
            Array.Sort(lados);

            var maior = lados[2];
            var meio = lados[1];
            var menor = lados[0];

            var naoFormaTriangulo = maior >= meio + menor;
            var trianguloRetangulo = (maior * maior) == (meio * meio) + (menor * menor);
            var trianguloObtusangulo = (maior * maior) > (meio * meio) + (menor * menor);
            var trianguloAcutangulo = (maior * maior) < (meio * meio) + (menor * menor);
            var trianguloEquilatero = maior == meio && meio == menor;           
            var trianguloIsosceles = (maior == meio && maior != menor) || (maior == menor && maior != meio) || (meio == menor && meio != maior);


            if (naoFormaTriangulo)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (trianguloRetangulo) Console.WriteLine("TRIANGULO RETANGULO");
                if (trianguloObtusangulo) Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (trianguloAcutangulo) Console.WriteLine("TRIANGULO ACUTANGULO");
                if (trianguloEquilatero) Console.WriteLine("TRIANGULO EQUILATERO");
                if (trianguloIsosceles) Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
