using System;
using System.Globalization;

namespace Challenger75
{
    class Program
    {
        static void Main(string [] args)
        {
            double contaCliente, saldo, debito, credito, saldoAtual;
            string cliente;
            Console.WriteLine("Por favor digite o seu nome");
            cliente = Console.ReadLine();
            Console.WriteLine("Por favor digite o seu saldo");
            saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Por favor digite o seu debito");
            debito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Por favor digite o seu credito");
            credito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldoAtual = saldo - debito + credito;

            if (saldoAtual <= 0)
            {
                Console.WriteLine(cliente + "  seu saldo está " + saldoAtual + " negativo ");
            }
            else
            {
                Console.WriteLine(cliente + "  seu saldo está " + saldoAtual + " positivo ");
            }

           
               


        }
    }
}
