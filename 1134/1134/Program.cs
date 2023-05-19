using System;
class Program
{
    static void Main(string[] args)
    {
        int produto, gasolina, alcool, diesel;
        gasolina = 0;
        alcool = 0;
        diesel = 0;

        produto = int.Parse(Console.ReadLine());
         while (produto != 4)
        {
            if (produto == 1)
            {
                alcool++;
            }
            else if (produto == 2)
            {
                gasolina++;
            }
            else if (produto == 3)
            {
                diesel++;
            }
            produto = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasoline: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}