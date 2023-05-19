using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double salario, IR;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        if (salario <= 2000.0)
        {
            Console.WriteLine("Isento");
        }
        else if (salario > 2000.0 && salario <= 3000.0)
        {
            IR = (salario - 2000) * 0.08;
            Console.WriteLine($"R$ {IR.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if (salario > 3000.0 && salario <= 4500.0)
        {
            IR = 1000 * 0.08 + (salario - 3000)* 0.18;
            Console.WriteLine($"R$ {IR.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            IR = 1000 * 0.08 + 1500 * 0.18 + (salario - 4500) * 0.28;
            Console.WriteLine($"R$ {IR.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}