using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (A < 0.0 || A > 10.0)
        {
            Console.WriteLine("nota invalida");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (B < 0.0 || B > 10.0)
        {
            Console.WriteLine("nota invalida");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double media = (A + B) / 2;
        Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}