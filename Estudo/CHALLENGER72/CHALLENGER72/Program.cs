using System;
using System.Globalization;

namespace CHALLENGER72
{
    class Program
    {
        static void Main(string [] args)
        {
            double horaInicial, horaFinal, tempo, dia;

            Console.WriteLine("Digite o tempo que iniciou a partida");
            horaInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o tempo final");
            horaFinal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            tempo = horaFinal - horaInicial;

            

            if (tempo >= 1 &&  tempo == 24)
            {
                Console.WriteLine("A partida teve duração " + tempo + " horas " );
            }
            else if ( tempo > 24)
            {
                dia = tempo / 24;
                Console.WriteLine("A partida " + dia + " dia com duração ou seja " + tempo + " horas " );
            }
            else
            {
                Console.WriteLine("Partida rapida durou menos de uma hora " + tempo.ToString("F2",CultureInfo.InvariantCulture));
            }
            
        }
    }
}
