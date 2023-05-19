using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (y > x)
        {
            int aux = y;
            y = x;
            x = aux;
        }
        
        for (int i = y; i < x; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}