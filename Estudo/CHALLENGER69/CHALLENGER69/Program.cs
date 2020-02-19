using System;
using System.Globalization;

namespace CHALLENGER69
{
    class Program
    {
        static void Main(string [] args)
        {

            string nome;
            double nota1,nota2,nota3,media;
            

            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                      
            Console.WriteLine("Digite a nota 2");
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 3");
            nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno " + nome + " tirou média " + media.ToString("F1", CultureInfo.InvariantCulture) + " está aprovado ");
            }
            else if (media == 6.0)
            {
                Console.WriteLine("Aluno " + nome + " tirou média " + media.ToString("F1", CultureInfo.InvariantCulture) + " está de recuperação ");
            }
            else
            {
                Console.WriteLine("Aluno " + nome + " tirou média " + media.ToString("F1",CultureInfo.InvariantCulture)+ " está reprovado ");
            }
         
        }
        
    }
}
