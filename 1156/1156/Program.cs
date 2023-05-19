using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double S = 0.0;
        double a = 1.0;

        for (int i = 1; i <= 39; i += 2)
        {
            S += i / a;
            a *= 2;
        }
        Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
    }
}