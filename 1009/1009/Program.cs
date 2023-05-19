using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double salarioFixo, vendas, comissao, total;
        string vendedor = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        comissao = vendas * 0.15;
        total = comissao + salarioFixo;

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");


    }
}