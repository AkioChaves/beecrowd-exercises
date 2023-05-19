using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        float a, b, med;
        a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        med = (a * 3.5f + b * 7.5f) / 11;
        Console.WriteLine($"MEDIA = {med.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}