using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double a, b, c, med;
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        med = (a * 2 + b * 3 + c * 5) / 10;
        Console.WriteLine($"MEDIA = {med.ToString("F1", CultureInfo.InvariantCulture)}");
    }
}