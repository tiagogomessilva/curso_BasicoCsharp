using System;

namespace Challenger77
{
    class Program
    {
        static void Main(string [] args)
        {
            int numero;

            Console.WriteLine("Digite um numero por favor");
            numero = int.Parse(Console.ReadLine());

            if (numero >=1)
            {
                Console.WriteLine(" O numero é positivo " + numero);
            }
            else if (numero < 0)
            {
                Console.WriteLine("numero é negativo " + numero);
            }
            else
            {
                Console.WriteLine(" numero é zero " + numero);
            }

Console.ReadLine();

        }
    }
}
