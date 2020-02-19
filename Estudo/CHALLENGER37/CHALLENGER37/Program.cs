using System;
using System.Globalization;

namespace CHALLENGER37
{
    class Program
    {
        static void Main(string [] args)
        {
            double A, B, media;

            Console.WriteLine("Digite a 1 nota");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5",CultureInfo.InvariantCulture));
        }
    }
}
