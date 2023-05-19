using System;
class Program
{
    static void Main(string[] args)
    {
        double x;
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                x = Math.Pow(i, 2);
                Console.WriteLine($"{i}^2 = {x}");
            }
        }
    }
}