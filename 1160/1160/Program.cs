using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int T, PA, PB, tempo;
        double GA, GB;
        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            PA = int.Parse(vet[0]);
            PB = int.Parse(vet[1]);
            GA = double.Parse(vet[2], CultureInfo.InvariantCulture);
            GB = double.Parse(vet[3], CultureInfo.InvariantCulture);

            tempo = 0;
            while (PA <= PB)
            {
                PA += (int) (PA * (GA / 100));
                PB += (int) (PB * (GB / 100));
                tempo++;
            }
            if (tempo > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine($"{tempo} anos.");
            }
        }
    }
}