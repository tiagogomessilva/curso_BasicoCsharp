using System;
using System.Globalization;

namespace Challenger20
{
    class Program
    {
        static void Main(string [] args)
        {
            double nota1, nota2, nota3,mediaPonderada;
            string aluno;
            Console.WriteLine("Digite o nome do aluno");
            aluno = Console.ReadLine();

            
            Console.WriteLine("Digite a primeira nota do aluno");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota do aluno");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota do aluno");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            Console.WriteLine("A media do aluno é " + mediaPonderada);
            Console.ReadLine();

           
        }
    }
}
