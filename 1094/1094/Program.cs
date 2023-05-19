using System;
using System.Globalization;
class program
{
    static void Main(string[] args)
    {
        int sapo, coelho, rato, N, total;
        double pSapo, pCoelho, pRato;
        string cobaia;
        total = 0;
        coelho = 0;
        rato = 0;
        sapo = 0;

        N= int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            total += int.Parse(vet[0]);
            cobaia = vet[1];

            if (vet[1] == "C")
            {
                coelho += int.Parse(vet[0]); 
            }
            else if (vet[1] == "R")
            {
                rato += int.Parse(vet[0]);
            }
            else if (vet[1] == "S")
            {
                sapo += int.Parse(vet[0]);
            }
        }
        pCoelho = (double) coelho / total * 100;
        pRato = (double) rato / total * 100;
        pSapo= (double) sapo / total * 100;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");
        Console.WriteLine($"Percentual de coelhos: {pCoelho.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {pRato.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {pSapo.ToString("F2",CultureInfo.InvariantCulture)} %");
    }
}