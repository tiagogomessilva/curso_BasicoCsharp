using System;

namespace CHALLENGER71
{
    class Program
    {
        static void Main(string [] args)
        {
            int numero1,numero2;

            Console.WriteLine("Digite um numero 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero 2");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 >  numero2)
            {
                Console.WriteLine(" O primeiro numero é maior que o segundo = " + numero1 + " O segundo numero é menor = " + numero2);
                
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine( " O segundo numero é maior que o primeiro = " + numero2 + " O primeiro é numero é menor = " + numero1);
            }
            else
            {
                Console.WriteLine("Esse exercicio é de comparação os dois numeros não podem ser iguais");
            }


            Console.ReadLine();

        
        }
    }
}
