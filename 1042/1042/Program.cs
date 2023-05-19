using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        string[] valores = Console.ReadLine().Split(' ');

        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);

        if (c < b && c < a)
        {
            Console.WriteLine(c);
            if (b < a)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        else if (b < c && b < a)
        {
            Console.WriteLine(b);
            if (c < a)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
        }
        else
        {
            Console.WriteLine(a);
            if (b < c)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}