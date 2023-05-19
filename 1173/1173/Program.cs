using System;
class Program
{
    static void Main(string[] args)
    {
        int[] A = new int[10];
        A[0] = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            A[i] = A[i - 1] * 2;
        }
        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine($"N[{i}] = {A[i]}");
        }
    }
}