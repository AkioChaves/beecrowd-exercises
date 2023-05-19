using System;
class Program
{
    static void Main(string[] args)
    {
        int N, a, b, aux;
        a = 0;
        b = 1;
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N - 1; i++)
        {
            Console.Write($"{a} ");
            aux = b;
            b += a;
            a = aux;
        }
        b += a;
        Console.WriteLine(a);
    }
}