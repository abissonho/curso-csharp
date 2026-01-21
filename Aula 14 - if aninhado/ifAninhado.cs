using System;

class IfAninhado
{
    static void Main()
    {
        int nota1, nota2, nota3, res;
        Console.Write("Digite a 1ª nota: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 2ª nota: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a 3ª nota: ");
        nota3 = int.Parse(Console.ReadLine());
        res = nota1 + nota2 + nota3;
        string resultado;

        if (res >= 60)
        {
            if (res >= 90)
            {
                resultado = "Aprovado com Louvor";
                if (res >= 99) { resultado = "Aprovado com Honra"; }
            }
            else { resultado = "Aprovado"; }
        }
        else
        {
            if (res >= 40) { resultado = "Recuperação"; }
            else { resultado = "Reprovado"; }
        }

        Console.WriteLine("Resultado: {0}", resultado);
    }
}
