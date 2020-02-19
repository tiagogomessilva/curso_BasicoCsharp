using System;
using System.Globalization;

namespace CHALLENGER40
{
    class Program
    {
        static void Main(string [] args)
        {
            double valorHora, salario;
            int numero, horas;

            Console.WriteLine("Digite o numero do funcionario");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor hora do funcionario");
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("Numero do funcionario = " + numero);
            Console.WriteLine("O salario =  R$ " +salario.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
