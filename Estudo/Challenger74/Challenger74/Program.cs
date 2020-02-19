using System;
using System.Globalization;

namespace Challenger74
{
    class Program
    {
        static void Main(string [] args)
        {
            string nome;
            char sexo;
            double altura, pesoIdeal;

            Console.WriteLine("Digite seu nome: ");
            nome = (Console.ReadLine());
            Console.WriteLine("Digite sua altura ");
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu sexo: M ou F");
            sexo = char.Parse(Console.ReadLine());
            if (sexo=='M'||sexo=='m')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine(nome + " a sua altura é  " + altura + " e o peso ideal é : " + pesoIdeal.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (sexo=='F' || sexo =='f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine(nome + " a sua altura é  " + altura + " e o peso deal é : " + pesoIdeal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Por favor digite o sexo corretamente se é  M de masculino ou F de feminino");
            }
            Console.ReadLine();
        }
    }
}
