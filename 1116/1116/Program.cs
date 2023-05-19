using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            double x, y, div;
            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                div = x / y;
                Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}