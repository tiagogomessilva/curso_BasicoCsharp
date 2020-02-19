using System;

namespace Challenger79
{
    class Program
    {
        static void Main(string [] args)
        {
            int n1, n2, n3,resultado;

            Console.WriteLine("Digite o primeiro numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero ");
            n3 = int.Parse(Console.ReadLine());

            

            
            if(n1==n2|| n1==n3||n2==n1||n2==n3||n2==n1||n2==n3||n3==n1||n1==n2)
            {
                Console.WriteLine(" Por favor não digitar numeros repetidos ");
                return;
            }
            else
            {
                Console.WriteLine("Somar dois numeros maiores");
            }
            

            if (n1 > n2 && n2 > n3)
            {
                Console.WriteLine("primeiro numero é maior " + n1);
                Console.WriteLine("segundo numero é maior " + n2);
                resultado = n1 + n2;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }
            else if (n2 > n1 && n1 > n3)
            {
                Console.WriteLine("primeiro numero é maior " + n2);
                Console.WriteLine("segundo numero é maior " + n1);
                resultado = n2 + n1;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }
            else if (n2 > n3 && n3 > n1)
            {
                Console.WriteLine("primeiro numero é maior " + n2);
                Console.WriteLine("segundo numero é maior " + n3);
                resultado = n2 + n3;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }
            else if (n3 > n2 && n2 > n3)
            {
                Console.WriteLine("primeiro numero é maior " + n3);
                Console.WriteLine("segundo numero é maior " + n2);
                resultado = n3 + n2;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }  else if (n3 > n1 && n1 > n2)
            {
                Console.WriteLine("primeiro numero é maior " + n3);
                Console.WriteLine("segundo numero é maior " + n1);
                resultado = n3 + n1;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }
            else
            {
                Console.WriteLine("primeiro numero é maior " + n1);
                Console.WriteLine("segundo numero é maior " + n3);
                resultado = n1 + n3;
                Console.WriteLine("A soma dos dois numeros maiores é " + resultado);

            }
            

                    


        }
    }
}
