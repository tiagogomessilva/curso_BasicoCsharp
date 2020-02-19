using System;
using System.Globalization;


namespace CHALLENGER7
{
    class Program
    {
        static void Main(string [] args)
        {
            var A = 10.5;
            var B = 20.6;

            Console.WriteLine("O Valor da Variavel B é " + B.ToString("F1",CultureInfo.InvariantCulture));

            B = 5;

            Console.WriteLine("O Valor da variavel B é " + B.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("O valor da variavel A é " + A.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
