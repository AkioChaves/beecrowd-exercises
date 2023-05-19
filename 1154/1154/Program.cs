using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int quant, idade;
        quant = 0;
        double media = 0;
        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            quant++;
            media += idade;
            idade = int.Parse(Console.ReadLine());
        }
        media = media / quant;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}