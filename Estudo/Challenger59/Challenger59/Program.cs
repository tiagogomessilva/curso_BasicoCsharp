using System;
using System.Globalization;

namespace Challenger59
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Digite um numero");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (numero < 0.0|| numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (true)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (true)
            {
                Console.WriteLine("Intervalo [25,75]");

            }
            else if (true)
            {
                Console.WriteLine("Intervalo [50,75]");

            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");

            }
        }
    }
}
