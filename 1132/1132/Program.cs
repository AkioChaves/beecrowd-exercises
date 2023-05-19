using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y, max, min, soma = 0;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        
        if (x > y)
        {
            max = x;
            min = y;
        }
        else
        {
            max = y;
            min = x;
        }
        
        for (int i = min; i <= max; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}