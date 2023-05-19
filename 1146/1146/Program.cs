using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        while (N != 0)
        {
            string s = "";
            for (int i = 1; i < N; i++)
            {
                s += i + " ";
            }
            s += N;
            Console.WriteLine(s);

            N = int.Parse(Console.ReadLine());
        }
    }
}