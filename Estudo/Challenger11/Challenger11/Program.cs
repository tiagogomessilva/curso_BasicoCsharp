using System;

namespace Challenger11
{
    class Program
    {
        static void Main(string [] args)
        {
            //Criar um programa que ao digitar no computador imprima um numeor anterior

            int numero;
            int resposta;
            
            Console.WriteLine();
            Console.WriteLine( "Digite qualquer numero por favor" );
            numero = int.Parse(Console.ReadLine());
            resposta = numero - 1;

            Console.WriteLine("O numero anterior ao digitado é " + resposta);
            Console.WriteLine("Aperte uma tecla para finalizar");
            Console.ReadKey();




        }
    }
}
