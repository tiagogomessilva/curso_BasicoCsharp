using System;

namespace CHALLENGER39
{
    class Program
    {
        static void Main(string [] args)
        {
            int A, B, C, D, DIFERENCA;

            Console.WriteLine("Digite o valor A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor D");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B) - (C * D);

            Console.WriteLine(" A diferença de resultados é = " + DIFERENCA);

        }
    }
}
