using System;
using System.Globalization;

namespace CHALLENGER38
{
    class Program
    {
        static void Main(string [] args)
        {
            double A, B, C, media;

            Console.WriteLine("Digite a primeira nota");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                     
            Console.WriteLine("Digite a segunda  nota");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;
            Console.WriteLine("MEDIA = " + media.ToString("F1",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
