using System;
class Program
{
    static void Main(string[] args)
    {
        int valor, cem, cinquenta, vinte, dez, cinco, dois, um;

        valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);

        cem = valor / 100;
        valor = valor % 100;
        cinquenta = valor / 50;
        valor = valor % 50;
        vinte = valor / 20;
        valor = valor % 20;
        dez = valor / 10;
        valor = valor % 10;
        cinco = valor / 5;
        valor = valor % 5;
        dois = valor / 2;
        um = valor % 2;

        Console.WriteLine($"{cem} nota (s) de R$ 100,00");
        Console.WriteLine($"{cinquenta} nota (s) de R$ 50,00");
        Console.WriteLine($"{vinte} nota (s) de R$ 20,00");
        Console.WriteLine($"{dez} nota (s) de R$ 10,00");
        Console.WriteLine($"{cinco} nota (s) de R$ 5,00");
        Console.WriteLine($"{dois} nota (s) de R$ 2,00");
        Console.WriteLine($"{um} nota (s) de R$ 1,00");
    }
}