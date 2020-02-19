using System;

namespace CHALLENGER34
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, MULTIPLICAR;
            Console.WriteLine("Digite um valor :");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor :");
            B = int.Parse(Console.ReadLine());

            MULTIPLICAR = A * B;

            Console.WriteLine("SUBTRAIR = " + MULTIPLICAR);
        }
    }
}
