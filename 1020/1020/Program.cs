using System;
class Program
{
    static void Main(string[] args)
    {
        int idade, anos, meses, dias;
        idade = int.Parse(Console.ReadLine());

        anos = idade / 365;
        idade = idade % 365;
        meses = idade / 30;
        dias = idade % 30;

        Console.WriteLine($"{anos} ano (s)");
        Console.WriteLine($"{meses} mes (es)");
        Console.WriteLine($"{dias} dia (s)");
    }
}