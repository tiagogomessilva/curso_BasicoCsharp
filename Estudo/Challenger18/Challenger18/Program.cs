using System;
using System.Globalization;

namespace Challenger18
{
    class Program
    {
        static void Main(string [] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Escreva a temperatura em graus celsius ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("A temperatura em fahrenheit é  = " + fahrenheit.ToString("F1" , CultureInfo.InvariantCulture  ) + " °F ");

            Console.ReadLine();

              

        }
    }
}
