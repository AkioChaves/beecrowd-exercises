using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        double PI = 3.14159;

        double volume = (4.0 / 3) * PI * Math.Pow(r, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}