using System;

class aula08
{
    static void Main()
    {
        //int v1, v2, soma;
        /*string nome;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Seu nome é " + nome);*/

    /*
        Console.Write("Digite o primeiro valor: ");
        //Parse converte string para int
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        //Convert converte string para int
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.Write("A soma de {0} e {1} é: {2}", v1, v2, soma); */

        //Testando conhecimento

        string nome;
        int cep, idade, cpf;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite seu CEP: ");
        cep = int.Parse(Console.ReadLine());
        Console.Write("Digite sua Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite seu CPF: ");
        cpf = int.Parse(Console.ReadLine());

        //Retorna os valores armazenados nas variáveis
        Console.WriteLine("Seu nome é: {0}", nome);
        Console.WriteLine("Seu CEP é: {0}", cep);
        Console.WriteLine("Sua Idade é: {0}", idade);
        Console.WriteLine("Seu CPF é: {0}", cpf);


    }
}