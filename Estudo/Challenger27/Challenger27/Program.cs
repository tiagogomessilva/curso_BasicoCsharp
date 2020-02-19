using System;
using System.Globalization;

namespace Challenger27
{
    class Program
    {
        static void Main(string [] args)
        {
            string x;
            int y;
            double z;

            Console.WriteLine("Por favor digite o palavra , seguido de numero inteiro e r");
            string [] vet = Console.ReadLine().Split(' ');

            x = vet [0];
            y = int.Parse(vet [1]);
            z = double.Parse(vet [2], CultureInfo.InvariantCulture);
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
