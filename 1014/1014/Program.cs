using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int distancia = int.Parse(Console.ReadLine());
        double gasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double kml = distancia / gasolina;

        Console.WriteLine($"{kml.ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }
}