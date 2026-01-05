using System;

class Aula10
{
    enum DiasSemana{Domingo,Segunda,Terca,Quarta,Quinta,Sexta,Sabado}

    static  void Main()
    {
        DiasSemana dia;

        dia = DiasSemana.Domingo;

        Console.WriteLine("Dia escolhido: " + dia);
        Console.WriteLine("Valor do dia: " + (int)dia);
    }
}