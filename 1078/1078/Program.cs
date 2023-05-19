using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

       for (int i = 1; i <= 10; i++)
        {
            int x = N * i;
            Console.WriteLine($"{i} x {N} = {x}");
        }
    }
}