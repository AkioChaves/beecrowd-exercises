using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int N = 6;
        int positivo = 0;
        double media, soma = 0;

        for (int i = 0; i < N; i++)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (a > 0)
            {
                positivo++;
                soma += a;
            }
        }
        media = soma / positivo;

        Console.WriteLine($"{positivo} valores positivos");
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}