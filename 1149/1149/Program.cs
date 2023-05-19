using System;
class Program
{
    static void Main(string[] args)
    {
        int A, N, i, soma;
        soma = 0;
        string[] vet = Console.ReadLine().Split(' ');
        A = int.Parse(vet[0]);
        i = 1;
        N = int.Parse(vet[i]);

        while (N <= 0)
        {
            i++;
            N = int.Parse(vet[i]);
        }

        for (i = 0; i <= N -1; i++)
        {
            soma += A + i;
        }
        Console.WriteLine(soma);
    }
}