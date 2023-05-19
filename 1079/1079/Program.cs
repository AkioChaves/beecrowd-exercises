using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double a, b, c, media;
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            media = a * 0.2 + b * 0.3 + c * 0.5;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}