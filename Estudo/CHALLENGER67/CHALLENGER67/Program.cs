using System;

namespace CHALLENGER67
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Digite um valor");
            int valor;

            valor = int.Parse(Console.ReadLine());
            if (valor < 0)
            {
                Console.WriteLine("Valor negativo");
            }
            else
            {
                Console.WriteLine("Valor positivo");
            }

            Console.ReadLine();
            Console.Clear();

         }
    }
}
