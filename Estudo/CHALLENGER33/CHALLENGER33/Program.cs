using System;

namespace CHALLENGER33
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, SUBTRAIR;
            Console.WriteLine("Digite um valor :");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor :");
            B = int.Parse(Console.ReadLine());

            SUBTRAIR = A - B;

            Console.WriteLine("SUBTRAIR = " + SUBTRAIR);
        }
    }
}
