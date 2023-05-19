using System;
class Program
{
    static void Main(string[] args)
    {
        int N, X, Y, cont, soma;
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);
            cont = 0;
            soma = 0;
            
            for (int j = X; cont < Y; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                    cont++;
                }
            }
            Console.WriteLine(soma);
        }
    }
}