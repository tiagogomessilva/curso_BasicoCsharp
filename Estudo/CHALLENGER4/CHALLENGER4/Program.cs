using System;

namespace CHALLENGER4
{
    class Program
    {
        static void Main(string [] args)
        {
            int A = 10;
            int B;

            B = A + 1;
            A = B + 1;
            B = A + 1;

            Console.WriteLine("A variavel A é " + A);
            A = B + 1;
            Console.WriteLine(" A = " + A);
            Console.WriteLine(" B = " + B);

            Console.ReadKey();

            

         }
    }
}
