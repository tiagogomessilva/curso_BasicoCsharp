using System;
using System.Globalization;

class MyClass
{
    static void Main(string [] args)
    {
        int totalEleitor,votoBranco, votoNulo,votoValido ,votoEleitores,porcentBranco,porcentNulo,porcentValido,porcentTotal;


        Console.WriteLine("Digite a quantidade total de eleitores que votaram");
        votoEleitores = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de votos nulos");
        votoNulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de votos brancos");
        votoBranco = int.Parse(Console.ReadLine());


        votoValido = votoEleitores - (votoBranco + votoNulo);

        Console.WriteLine("O total de votos brancos foram = " + votoBranco);
        Console.WriteLine("O total de votos nulo foram = " + votoNulo);
        Console.WriteLine("O total de votos validos foram = " + votoValido);
        Console.WriteLine("O total de votos foi = " + votoEleitores);
        

        
        Console.WriteLine("Aperte uma tecla para continuar");
        Console.ReadLine();

        porcentBranco = votoBranco * 100 / votoEleitores;
        porcentNulo   = votoNulo  * 100 / votoEleitores;
        porcentValido = votoValido * 100 / votoEleitores;

        Console.WriteLine(" A porcentagem de brancos foi " + porcentBranco + "%");
        Console.WriteLine("A porcentagem de nulos foi "+ porcentNulo + "%");
        Console.WriteLine("A porcentagem de validos foi "+ porcentValido + "%");

        Console.ReadLine();
        


        
        



    }
}

