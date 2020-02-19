using System;
using System.Globalization;

namespace Challenger31
{
    class Program
    {
        static void Main(string [] args)
        {
            double RAIO, AREA, PI;

            PI = 3.14159;
            Console.WriteLine("Digite o raio da circunferencia");
            RAIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AREA = PI * RAIO * RAIO;

            Console.WriteLine("AREA = " + AREA.ToString("F4", CultureInfo.InvariantCulture));
            
        }
    }
}
