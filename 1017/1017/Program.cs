using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int horas, kmh, distancia;
        horas = int.Parse(Console.ReadLine());
        kmh= int.Parse(Console.ReadLine());

        distancia = horas * kmh;
        double gasolina = distancia / 12.0;

        Console.WriteLine(gasolina.ToString("F3", CultureInfo.InvariantCulture));
    }
}