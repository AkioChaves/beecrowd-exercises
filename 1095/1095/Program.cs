using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int I = 1;

        for (int J = 60; J >= 0; J -= 5)
        {
            Console.WriteLine($"I={I} J={J}");
            I += 3;
        }
    }
}