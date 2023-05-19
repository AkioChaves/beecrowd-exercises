using System;
class Program
{
    static void Main(string[] args)
    {
        int duracao, seg, min, horas;

        duracao = int.Parse(Console.ReadLine());

        horas = duracao / 3600;
        duracao = duracao % 3600;
        min = duracao / 60;
        seg = duracao % 60;

        Console.WriteLine($"{horas}:{min}:{seg}");
    }
}