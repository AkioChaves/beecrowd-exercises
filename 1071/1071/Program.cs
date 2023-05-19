using System;
class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int maior, menor, impar = 0;

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

        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                impar += i;
            }
        }
        Console.WriteLine(impar);
    }
}