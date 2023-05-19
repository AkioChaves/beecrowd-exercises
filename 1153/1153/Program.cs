using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int fatorial = N;

        for (int i = 1; i < N; i++)
        {
            fatorial *= N - i;
        }
        Console.WriteLine(fatorial);
    }
}