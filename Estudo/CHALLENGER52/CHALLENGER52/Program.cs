using System;

namespace CHALLENGER52
{
    class Program
    {
        static void Main(string [] args)
        {
            int n, resto, horas, minutos, segundos;

            Console.WriteLine("Digite a quantidade em horas para ser convertido em minutos");
            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n / 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ": " + minutos + ": " +  segundos );

            Console.ReadLine();

        }
    }
}
