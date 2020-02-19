using System;
using System.Globalization;

namespace CHALLENGER47
{
    class Program
    {
        static void Main(string [] args)
        {
            string nome;
            double salarioFixo, totalVenda, salarioTotal;

            Console.WriteLine("Digite o seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salario fixo");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o total da venda");
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;

            Console.WriteLine("SALARIO TOTAL É = R$ " + salarioTotal.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }

    }
}
