using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c, maiorAB, maior;
        string[] vet = Console.ReadLine().Split(' ');

        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        maior = (c + maiorAB + Math.Abs(c - maiorAB)) / 2;

        Console.WriteLine($"{maior} eh o maior");
    }
}