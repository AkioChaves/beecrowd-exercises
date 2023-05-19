using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int cem, cinquenta, vinte, dez, cinco, dois, um, cents50, cents25, cents10, cents5, cents1;

        decimal dinheiro = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        cem = (int) dinheiro / 100;
        dinheiro = dinheiro % 100;
        cinquenta = (int) dinheiro / 50;
        dinheiro = dinheiro % 50;
        vinte = (int) dinheiro / 20;
        dinheiro = dinheiro % 20;
        dez = (int) dinheiro / 10;
        dinheiro = dinheiro % 10;
        cinco = (int) dinheiro / 5;
        dinheiro = dinheiro % 5;
        dois = (int) dinheiro / 2;
        um = (int) dinheiro % 2;
        dinheiro = dinheiro * 100 % 100;
        cents50 = (int) dinheiro / 50;
        dinheiro = dinheiro % 50;
        cents25 = (int) dinheiro / 25;
        dinheiro = dinheiro % 25;
        cents10 = (int) dinheiro / 10;
        dinheiro = dinheiro % 10;
        cents5 = (int) dinheiro / 5;
        cents1 = (int) dinheiro % 5;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{cem} nota (s) de R$ 100.00");
        Console.WriteLine($"{cinquenta} nota (s) de R$ 50.00");
        Console.WriteLine($"{vinte} nota (s) de R$ 20.00");
        Console.WriteLine($"{dez} nota (s) de R$ 10.00");
        Console.WriteLine($"{cinco} nota (s) de R$ 5.00");
        Console.WriteLine($"{dois} nota (s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{um} moeda (s) de R$ 1.00");
        Console.WriteLine($"{cents50} moeda (s) de R$ 0.50");
        Console.WriteLine($"{cents25} moeda (s) de R$ 0.25");
        Console.WriteLine($"{cents10} moeda (s) de R$ 0.10");
        Console.WriteLine($"{cents5} moeda (s) de R$ 0.05");
        Console.WriteLine($"{cents1} moeda (s) de R$ 0.01");
    }
}