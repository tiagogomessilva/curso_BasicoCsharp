using System;
using System.Globalization;

namespace Challenger80
{
	class Program
	{
		static void Main(string [] args)
		{
		double litrosAlcool , litrosGasolina,desconto, resultadoAlcool,preco,resultadoGasolina;
		char Abastecer;

			Console.WriteLine("Escolha uma das opções abaixo ");
			Console.WriteLine("A = Alcool ");
			Console.WriteLine("G = Gasolina ");
			Console.WriteLine("Digite a opção: " );
		Abastecer = char.Parse(Console.ReadLine());
			Console.Clear();

		if (Abastecer =='A' || Abastecer == 'a')
		{
			Console.WriteLine("Por favor digite a quantidade de alcool ");
				litrosAlcool = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

				if (litrosAlcool <= 19)
				{
					Console.WriteLine("Voce abasteceu até 19  litros de alcool então ganhara desconto 3 por cento ao litro");
					preco = 2.99;
						desconto = (preco * 0.03);
						resultadoAlcool = (preco - desconto) * litrosAlcool;

					Console.WriteLine("Voce pagara " + resultadoAlcool.ToString("F2",CultureInfo.InvariantCulture));
				}
				else if (litrosAlcool >= 50 && litrosAlcool<=69)
				{
					Console.WriteLine("Voce abasteceu 50  litros de alcool ou mais  então ganhara desconto 5 por cento ao litro");
					preco = 2.99;
					desconto = (preco * 0.05);
					resultadoAlcool = (preco - desconto) * litrosAlcool;
					Console.WriteLine("Voce pagara " + resultadoAlcool.ToString("F2",CultureInfo.InvariantCulture));
				}
				else
				{
					Console.WriteLine("Voce abasteceu mais de 70 litros e o desconto será de 10 por centro");

					preco = 2.99;
					desconto = (preco * 0.10);
					resultadoAlcool = (preco - desconto) * litrosAlcool;
					Console.WriteLine("Voce pagara " + resultadoAlcool.ToString("F2", CultureInfo.InvariantCulture));
				}				
		}
			
		else if (Abastecer == 'G' || Abastecer == 'g')
		{
			Console.WriteLine("Por favor digite a quantidade de gasolina ");
			litrosGasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (litrosGasolina <=19)
				{
					Console.WriteLine("Voce abasteceu menos de 19 litros então ganharar 5 por cento de desconto");
					preco = 3.99;
					desconto = (preco * 0.05);
					resultadoGasolina = (preco - desconto) * litrosGasolina;
					Console.WriteLine("Voce pagara " + resultadoGasolina.ToString("F2", CultureInfo.InvariantCulture));
				}
				else if (litrosGasolina>= 20 && litrosGasolina <=50)
				{
					Console.WriteLine("Voce abasteceu entre 20  litros de alcool ee 50 litros então ganhara desconto 10 por cento ao litro");
					preco = 3.99;
					desconto = (preco * 0.10);
					resultadoGasolina = (preco - desconto) * litrosGasolina;
					Console.WriteLine("Voce pagara " + resultadoGasolina.ToString("F2", CultureInfo.InvariantCulture));
				}
				else
				{
					Console.WriteLine("Voce abasteceu 50  litros de gasolina ou mais  então ganhara desconto 20 por cento ao litro");
					preco = 3.99;
					desconto = (preco * 0.20);
					resultadoGasolina = (preco - desconto) * litrosGasolina;
					Console.WriteLine("Voce pagara " + resultadoGasolina.ToString("F2", CultureInfo.InvariantCulture));
				}
		 
		}
		else
		{
			Console.WriteLine("Comando invalido coloque alguma das opções abaixo");
		}
	}
	}
}

		
	









	
			



