using System;
using System.Globalization;

namespace Challenger73
{
    class Program
    {
        static void Main(string [] args)
        {
            
            double  salarioExtra, salarioInicial, salarioFinal, salarioHora , extra;
            int horaTrabalhada, horaExtra;


            Console.WriteLine("Digite a quantidade de horas trabalhadas no mes");
            horaTrabalhada = int.Parse(Console.ReadLine());
                  
            
            Console.WriteLine("Digite  a hora do seu salario");
            salarioHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            salarioInicial = (160 * salarioHora);
            horaExtra = horaTrabalhada - 40;
            extra = (salarioHora * 50) / 100;
            salarioExtra = horaExtra * extra;
            salarioFinal = salarioExtra + salarioInicial;
            

            if (horaTrabalhada == 40)
            {
                Console.WriteLine("O seu salario é " + salarioInicial.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (horaTrabalhada >40)
            {
                Console.WriteLine("O seu salario sera " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
