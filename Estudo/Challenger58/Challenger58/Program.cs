using System;
using System.Globalization;


namespace Challenger58
{
    class Program
    {
        static void Main(string [] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario<=2000.0)
            {
                percentual = 4.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;
            Console.Clear();
            Console.WriteLine("Novo Salario : " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste Ganho : " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em Percentual: " + percentual.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
