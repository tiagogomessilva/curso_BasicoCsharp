using System;

namespace Challenger13
{
    class Program
    {
        static void Main(string [] args)
        {
            int dias, meses, ano, idade;
            string pessoa;

            Console.WriteLine("Digite o seu nome");
            Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());

            dias = idade * 365;
            meses = idade * 12;
            

            Console.WriteLine("Voce possui " + idade + " anos " + " Que vive " + dias +" dias  e " +  meses + " meses " );

            Console.WriteLine("Aperte uma tecla para finalizar");
            Console.ReadKey();




            
        }
    }
}
