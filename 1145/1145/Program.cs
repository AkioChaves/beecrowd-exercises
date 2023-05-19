using System;
class Program
{
    static void Main(string[] args)
    {
        int X, Y;
        string[] vet = Console.ReadLine().Split(' ');
        X = int.Parse(vet[0]);
        Y = int.Parse(vet[1]);

        for (int i = 1; i <= Y; i++)
        {
            for (int j = 0; j < X - 1; j++)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine(i);
        }
    }
}