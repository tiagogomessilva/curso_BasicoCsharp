using System;
using System.Globalization;

namespace challenger15
{
    class Program
    {
        static void Main(string [] args)
        {
            double salario,salarioAtual,percreajust,novoSalario;
            Console.WriteLine("Por favor digite o salario atual");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o reajuste");
            percreajust = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioAtual = salario * percreajust  / 100;

            novoSalario = salarioAtual + salario;
                

            Console.WriteLine("Voce passara a ganhar " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));

         }
    }
}
