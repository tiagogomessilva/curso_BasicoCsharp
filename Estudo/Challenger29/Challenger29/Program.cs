﻿using System;
using System.Globalization;

namespace curso
{
	class Program
	{
		static void Main(string [] args)
		{
			double largura, comprimento, precoMetroQuadrado,area,preco;
			
			Console.WriteLine("Digite a largura ");
			largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Digite o comprimento");
			comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Digite o metro quadrado ");
			precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			area = largura * comprimento;
			preco = area * precoMetroQuadrado;

			Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));


		}
	}
}