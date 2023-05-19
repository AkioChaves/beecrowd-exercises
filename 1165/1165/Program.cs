using System;
class Program
{
    static void Main(string[] args)
    {
        int N, X, soma;
        N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            soma = 0;
            X = int.Parse(Console.ReadLine());

            for (int j = 2; j < X; j++)
            {
                if (X % j == 0)
                {
                    soma++;
                }
            }
            if (soma == 0)
            {
                Console.WriteLine($"{X} eh primo");
            }
            else
            {
                Console.WriteLine($"{X} nao eh primo");
            }
        }
    }
}