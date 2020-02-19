using System;

namespace CHALLENGER35
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, DIVIDIR;
            Console.WriteLine("Digite um valor :");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor :");
            B = int.Parse(Console.ReadLine());

            DIVIDIR = A / B;

            Console.WriteLine("DIVIDIR = " + DIVIDIR);
        }
    }
}
