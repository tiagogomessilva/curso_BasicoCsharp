using System;

namespace Challenger76
{
    class Program
    {
        static void Main(string [] args)
        {
            int qtdeAtual, qtdeMaxima, qtdeMinima, qtdeMedia;
            string produto;
            Console.WriteLine("Por favor digite o nome produto");
            produto = Console.ReadLine();
            Console.WriteLine("Por favor digite a quantidade atual em estoque ");
            qtdeAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite a quantidade maxima ");
            qtdeMaxima = int.Parse(Console.ReadLine());
                      
            Console.WriteLine("Por favor digite a quantidade minima ");
            qtdeMinima = int.Parse(Console.ReadLine());
            
            qtdeMedia = (qtdeMaxima + qtdeMinima) / 2;

            Console.WriteLine("quantidade média é " + qtdeMedia);
            Console.WriteLine("quantidade em estoque é " + qtdeAtual);
            if (qtdeAtual >= qtdeMedia)
            {
                Console.WriteLine("Não efetuar a compra " );
            }
            else
            {
                Console.WriteLine("Efetuar a compra");
            }

        }
    }
}
