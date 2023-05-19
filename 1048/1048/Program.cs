using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double salario, novoSalario, aumento;
        int percentual = 0;
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario <= 400.0)
        {
            percentual = 15;
        }
        else if (salario > 400.0 && salario <= 800.0)
        {
            percentual = 12;
        }
        else if (salario > 800.0 && salario <= 1200.0)
        {
            percentual = 10;
        }
        else if (salario > 1200.0 && salario <= 2000.0)
        {
            percentual = 7;
        }
        else if (salario > 2000.0)
        {
            percentual = 4;
        }
        aumento = salario * percentual / 100;
        novoSalario = salario + aumento;

        Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {aumento.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {percentual} %");
    }
}