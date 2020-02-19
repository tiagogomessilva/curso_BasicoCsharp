using System;

namespace CHALLENGER68
{
    class Program
    {
        static void Main(string [] args)
        {
            int numero;
            Console.WriteLine("Digite a quantidade de maças que deseja comprar");

            
            numero = int.Parse(Console.ReadLine());

            if (numero <=11)
            {
                Console.WriteLine("As maças custaram  1,30");
            }
            else if (numero==12)
            {
                Console.WriteLine("As maças custaram 1,00");
            }
            else
            {
                Console.WriteLine("As maças custaram 0,80");
            }
            Console.ReadLine();
        }
        
    }
}
