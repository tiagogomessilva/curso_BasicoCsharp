using System;

namespace Challenger30
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, X;
            Console.WriteLine("Digite  o valor de A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite  o valor de B");
            B = int.Parse(Console.ReadLine());

            X = A + B;
            Console.WriteLine("X = " + X);
            Console.ReadLine();
        }
    }
}
