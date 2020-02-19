using System;
using System.Globalization;

namespace challenger17
{
    class Program
    {
        static void Main(string [] args)
        {
            string vendedor;
            double totalVendidos,  comissao, salario, salarioFinal;
            int numCarros;

            Console.WriteLine("Digite o nome do vendedor/a");
            vendedor = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de carros vendidos");
            numCarros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de carros vendidos");
            totalVendidos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o salario");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Comissão");
            comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFinal = salario + comissao + (totalVendidos * 5 / 100);
            Console.WriteLine("Funcionario (a ) " + vendedor + " vendeu " + numCarros + " e recebera " + salarioFinal.ToString("F2",CultureInfo.InvariantCulture));


            

            Console.WriteLine();

        }
    }
}
