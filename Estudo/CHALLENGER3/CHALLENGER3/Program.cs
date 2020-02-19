using System;

namespace CHALLENGER3
{
    class Program
    {
        static void Main(string [] args)
        {
            int A = 10;
            int B = 20;
            int C;

            C = A;
            B = C;
            A = B;

            Console.WriteLine("A = "+ A);
            Console.WriteLine("B = "+ B);
            Console.WriteLine("C = "+ C);

            Console.ReadLine();
        }
    }
}
