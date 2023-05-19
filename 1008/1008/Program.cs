using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int num, horas;
        decimal valor, salario;

        num = int.Parse(Console.ReadLine());
        horas= int.Parse(Console.ReadLine());
        valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = horas * valor;

        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SALARY = U$ {salario.ToString(CultureInfo.InvariantCulture)}");
    }
}