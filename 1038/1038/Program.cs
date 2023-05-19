using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int id, quant;
        double total = 0;
        string[] pedido = Console.ReadLine().Split(' ');

        id = int.Parse(pedido[0]);
        quant= int.Parse(pedido[1]);

        if (id == 1)
        {
            total = 4.00 * quant;
        }
        else if (id == 2)
        {
            total = 4.50 * quant;
        }
        else if (id == 3)
        {
            total = 5.00 * quant;
        }
        else if (id == 4)
        {
            total = 2.00 * quant;
        }
        else if (id == 5)
        {
            total = 1.50 * quant;
        }
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}