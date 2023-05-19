using System;
class Program
{
    static void Main(string[] args)
    {
        int N = 5;
        int par = 0;

        for (int i = 0; i < N; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                par++;
            }
        }
        Console.WriteLine($"{par} valores pares");
    }
}