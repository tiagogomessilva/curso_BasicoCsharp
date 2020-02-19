using System;
using System.Globalization;


namespace Challenger21
{
    class Program
    {
        static void Main(string [] args)
        {
            string x;
            int y;
            double z;
            char w;

            Console.WriteLine(" Por favor digite o seu nome ");
            x = Console.ReadLine();
            Console.WriteLine(" Por favor digite um numero inteiro ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(" Por favor digite um numero real ");
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Por favor digite uma letra ");
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(w);
            Console.ReadLine();

          }
    }
}
