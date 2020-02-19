using System;

namespace CHALLENGER_2
{
    class Program
    {
        static void Main(string [] args)
        {
            int A = 30;
            int B = 20;
            int C;

            C = A + B;

            Console.WriteLine("O resultado de C é " + C);

            B = 10;

            Console.WriteLine("As variaveis B tem o valor = " + B);
            Console.WriteLine("As variaveis B tem o valor = " + C);

            C = A + B;

            Console.WriteLine("A Variavel A tem o seguinte valor " + A);
            Console.WriteLine("A Variavel B tem o seguinte valor " + B);
            Console.WriteLine("A Variavel C tem o seguinte valor " + C);
            
            Console.ReadLine();


            

        }
    }
}
