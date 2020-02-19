using System;

namespace CHALLENGER32
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, SOMA;
            Console.WriteLine("Digite um valor :");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor :");
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
