using System;

namespace CHALLENGER66
{
    class Program
    {
        static void Main(string [] args)
        {
            var numero = 10;

            Console.WriteLine("Digite um numero ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 11)
            {
                Console.WriteLine("Esse numero é maior que 10");
            }
            else if (numero==10)            {
                Console.WriteLine("Numero é 10");
            }
            else
            {
                Console.WriteLine("numero menor 10 ");
            }
        }

    }
}
