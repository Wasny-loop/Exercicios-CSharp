using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double BaseRetangulo, AlturaRetangulo, area, perimetro, diagonal;

            BaseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AlturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = BaseRetangulo * AlturaRetangulo;
            perimetro = (2 * BaseRetangulo) + (2 * AlturaRetangulo);
            diagonal = Math.Sqrt(Math.Pow(BaseRetangulo, 2) + Math.Pow(AlturaRetangulo, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}