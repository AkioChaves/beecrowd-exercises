using System;
class Program
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int impar = 0;

        for (int i = X; impar < 6; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                impar++;
            }
        }
    }
}