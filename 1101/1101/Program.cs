using System;
class Program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int M = int.Parse(vet[0]);
        int N = int.Parse(vet[1]);

        while (M > 0 && N > 0)
        {
            int max, min, soma = 0;
            if (M > N)
            {
                max = M;
                min = N;
            }
            else
            {
                max = N;
                min = M;
            }

            for (int i = min; i <= max; i++)
            {
                Console.Write($"{i} ");
                soma += i;
            }
            Console.WriteLine($"Sum ={soma}");

            vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
        }
    }
}