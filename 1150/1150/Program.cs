using System;
class Program
{
    static void Main(string[] args)
    {
        int X, Z, contagem;
        X = int.Parse(Console.ReadLine());
        Z = int.Parse(Console.ReadLine());
        contagem = 1;

        while (X >= Z)
        {
            Z = int.Parse(Console.ReadLine());
        }
        for (int i = X; X < Z; i++)
        {
            X += i;
            contagem++;
        }
        Console.WriteLine(contagem);
    }
}