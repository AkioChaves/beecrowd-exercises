using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int id1, id2, num1, num2;
        decimal valor1, valor2, total;

        string[] vet = Console.ReadLine().Split(' ');
        id1= int.Parse(vet[0]);
        num1= int.Parse(vet[1]);
        valor1= decimal.Parse(vet[2], CultureInfo.InvariantCulture);

        vet = Console.ReadLine().Split(' ');
        id2= int.Parse(vet[0]);
        num2= int.Parse(vet[1]);
        valor2= decimal.Parse(vet[2], CultureInfo.InvariantCulture);

        total = (num1 * valor1) + (num2 * valor2);

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString(CultureInfo.InvariantCulture)}");
    }
}