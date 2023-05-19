using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int x, y, maior, menor, soma = 0;
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}