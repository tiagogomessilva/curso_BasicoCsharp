using System;
using System.Globalization;

namespace CHALLENGER44
{
    class Program
    {
        static void Main(string [] args)
        {
            int tempo, velocidade, distancia;
            double litros;

            Console.WriteLine("Digite o tempo da viagem");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade");
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            litros = distancia / 12.0;
            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
