using System;

class ElseIF
{
    static void Main()
    {
        int nota1, nota2, nota3, media;
        Console.Write("Digite a 1ª nota: ");
        nota1 = int.Parse(Console.ReadLine());  
        Console.Write("Digite a 2ª nota: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 3ª nota: ");
        nota3 = int.Parse(Console.ReadLine());
        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 60)
        {
            Console.WriteLine("Média: {0}, Aprovado", media);
        }
        else if (media >= 40)
        {
            Console.WriteLine("Média: {0}, Recuperação", media);
        }
        else
        {
            Console.WriteLine("Média: {0}, Reprovado", media);
        }
    }
}