using System;
class Program
{
    static void Main(string[] args)
    {
        int[] A = new int[10];

        for (int i = 0; i < 10; i++)
        {
            A[i] = int.Parse(Console.ReadLine());

            if (A[i] <= 0)
            {
                A[i] = 1;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {A[i]}");
        }
    }
}