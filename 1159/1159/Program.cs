using System;
class Program
{
    static void Main(string[] args)
    {
        int X, soma, cont;
        X = int.Parse(Console.ReadLine());

        while (X != 0)
        {
            soma = 0;
            cont = 0;

            for (int i = X; cont < 5; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                    cont++;
                }
            }
            Console.WriteLine(soma);
            X = int.Parse(Console.ReadLine());
        }
    }
}