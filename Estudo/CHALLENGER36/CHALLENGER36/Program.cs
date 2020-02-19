using System;

namespace CHALLENGER36
{
    class Program
    {
        static void Main(string [] args)
        {
            int x, y, prod;

            Console.WriteLine("Digite o valor de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y");
            y = int.Parse(Console.ReadLine());
            prod = x * y;
            Console.WriteLine("PROD = " + prod);
        }
    }
}
