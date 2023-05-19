using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, hora, min;
        string[] tempo = Console.ReadLine().Split(' ');

        a = int.Parse(tempo[0]);
        b = int.Parse(tempo[1]);
        c = int.Parse(tempo[2]);
        d = int.Parse(tempo[3]);

        a = a * 60 + b;
        c = c * 60 + d;

        if (a < c)
        {
            hora = c - a;
        }
        else
        {
            hora = (24 * 60 - a) + c;
        }
        min = hora % 60;
        hora = hora / 60;
        Console.WriteLine($"O JOGO DUROU {hora} HORA (S) E {min} MINUTO (S)");
    }
}