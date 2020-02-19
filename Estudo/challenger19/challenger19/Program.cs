using System;
using System.Globalization;


namespace challenger19
{
    class Program
    {
        static void Main(string [] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Por favor digite a quantidade de graus em fahrenheit");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8 ;

            Console.WriteLine(" A temperatura em graus celsius é " + celsius.ToString("F1",CultureInfo.InvariantCulture)+ "°C" );




        }
    }
}
