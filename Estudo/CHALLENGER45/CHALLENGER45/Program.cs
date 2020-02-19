using System;
using System.Globalization;

namespace CHALLENGER45
{
    class Program
    {
        static void Main(string [] args)
        {

            double area,b, a, perimetro, diagonal;
            
            Console.WriteLine("digite a base do retangulo");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite a altura do retangulo");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " +       
            area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
