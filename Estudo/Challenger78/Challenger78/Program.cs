using System;

namespace Challenger78
{
    class Program
    {
        static void Main(string [] args)
        {
            int n1, n2, n3,resultadoNumero;

            Console.WriteLine("Digite um numero por favor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero por favor");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite terceiro numero por favor");
            n3 = int.Parse(Console.ReadLine());


            

            if (n1==n2 || n1==n3 || n2 == n1 || n2 == n3 || n3==n1 || n3==n2)
            {
                Console.WriteLine("Por favor nao colocar numeros repetidos");

            }
            
            else if(n1>n2|| n1>n3 && n1 !=n2 && n1!=n3)
            {
                Console.WriteLine("numero1 é maior");
            }
            else if (n2 > n1 || n2 > n3 && n2 != n1 && n2 != n3)
            {
                Console.WriteLine("numero2 é maior");
            }

            else if (n3 > n1 || n3 > n2 && n3 != n1 && n3 != n2)
            {
                Console.WriteLine("numero 3 é maior");
            }
            
        }


    }
    }



