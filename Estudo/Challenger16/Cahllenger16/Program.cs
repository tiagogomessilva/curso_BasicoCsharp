using System;
using System.Globalization;

namespace Cahllenger16
{
    class Program
    {
        static void Main(string [] args)
        {
            double imposto, custoFabrica, percentualDistribuidor, custoConsumidor;

            Console.WriteLine("Por favor digite o custo para fabricar o carro : ");
            custoFabrica = double.Parse(Console.ReadLine());
                        
            percentualDistribuidor = (custoFabrica * 0.28) + custoFabrica;
            imposto = (custoFabrica * 0.45) + custoFabrica;

            custoConsumidor = percentualDistribuidor + imposto + custoFabrica;

            Console.WriteLine("O carro custara = " + custoConsumidor.ToString("F2" , CultureInfo.InvariantCulture));

            Console.ReadLine();
            



        }
    }
}
