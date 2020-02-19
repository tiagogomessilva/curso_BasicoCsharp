using System;
using System.Globalization;

namespace Challenger12
{
    class Program
    {
        static void Main(string [] args)
        {
            double Area, Base, Altura;

            Console.WriteLine("Digite a base do retangulo");
            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do retangulo");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Base * Altura;

            Console.WriteLine(" A area é = " + Area.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
