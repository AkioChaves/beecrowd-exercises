using System;
class Program
{
    static void Main(string[] args)
    {
        int inicio, fim, total;
        string[] horas = Console.ReadLine().Split(' ');

        inicio = int.Parse(horas[0]);
        fim = int.Parse(horas[1]);

        if (inicio >= fim)
        {
            total = (24 - inicio) + fim;
        }
        else
        {
            total = fim - inicio;
        }
        Console.WriteLine($"O JOGO DUROU {total} HORA (S)");
    }
}