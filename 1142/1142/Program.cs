using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int pum = 1;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{pum++} {pum++} {pum++} PUM");
            pum++;
        }
    }
}