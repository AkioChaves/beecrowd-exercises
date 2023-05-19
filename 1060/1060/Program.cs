using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int positivo = 0;
        int N = 6;

        for (int i = 0; i < N; i++)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0)
            {
                positivo++;

            }
        }
        Console.WriteLine($"{positivo} valores positivos");
    }
}