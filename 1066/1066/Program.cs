using System;
class Program
{
    static void Main(string[] args)
    {
        int N = 5;
        int par = 0;
        int impar = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i < N; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (valor > 0)
            {
                positivo++;
            }
            else if (valor < 0)
            {
                negativo++;
            }
        }
        Console.WriteLine($"{par} valor (es) par (es)");
        Console.WriteLine($"{impar} valor (es impar (es)");
        Console.WriteLine($"{positivo} valor (es) positivo (s)");
        Console.WriteLine($"{negativo} valor (es) negativo (s)");
    }
}