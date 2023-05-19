using System;
class Program
{
    static void Main(string[] args)
    {
        int maior, posi, N;
        N = int.Parse(Console.ReadLine());
        maior = N;
        posi = 1;

        for (int i = 2; i <= 100; i++)
        {
            N = int.Parse(Console.ReadLine());

            if (N > maior)
            {
                maior = N;
                posi = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posi);
    }
}