using System;
class Program
{
    static void Main(string[] args)
    {
        int somaIn, somaOut, N, X;
        somaIn = 0;
        somaOut = 0;
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            X = int.Parse(Console.ReadLine());
            
            if (X >= 10 && X <= 20)
            {
                somaIn++;
            }
            else
            {
                somaOut++;
            }
        }
        Console.WriteLine($"{somaIn} in");
        Console.WriteLine($"{somaOut} out");
    }
}