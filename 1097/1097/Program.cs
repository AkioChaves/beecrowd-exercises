using System;
class Program
{
    static void Main(string[] args)
    {
        int J = 7;
        for (int I = 1; I <= 9; I+= 2, J+= 2)
        {
            Console.WriteLine($"I={I} J={J}");
            Console.WriteLine($"I={I} J={J - 1}");
            Console.WriteLine($"I={I} J={J - 2}");
        }
    }
}