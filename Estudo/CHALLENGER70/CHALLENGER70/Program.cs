using System;

namespace CHALLENGER70
{
    class Program
    {
        static void Main(string [] args)
        {
            int anoAtual, anoNascimento, resultado;


            Console.WriteLine("Digite o ano que nasceu");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            anoAtual = int.Parse(Console.ReadLine());



            resultado = anoAtual - anoNascimento;

            if (resultado >= 18 && resultado <= 69)
            {
                Console.WriteLine("A pessoa pode votar");
            }
            else if (resultado >=70)
            {
                Console.WriteLine("Voto Facultativo você pode votar se quiser");
            }
            else
            {
                Console.WriteLine("Voce ainda não pode votar");
            }
            }

         }
    }

