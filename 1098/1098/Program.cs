using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        for (double I = 0; I <= 2; I+= 0.2)
        {
            double J = 1 + I;
            Console.WriteLine($"I={I.ToString(CultureInfo.InvariantCulture)} J={J.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"I={I.ToString(CultureInfo.InvariantCulture)} J={(J + 1).ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"I={I.ToString(CultureInfo.InvariantCulture)} J={(J + 2).ToString(CultureInfo.InvariantCulture)}");
        }
    }
}