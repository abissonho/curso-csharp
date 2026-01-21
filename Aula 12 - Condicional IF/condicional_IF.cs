using System;

class Aula12CondicionalIF
{
    static void Main()
    {
         // > < >= <= == !=
        int nota, n1, n2, n3, n4, res;
        res=n1=n2=n3=n4=0;
        string resultado = "Reprovado";

        Console.Write("Digite a 1ª nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 2ª nota: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 3ª nota: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 4ª nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        nota = res / 4;

        if (nota >= 60)
        {
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota {0} - Resultado: {1}", nota,resultado);

    }
}