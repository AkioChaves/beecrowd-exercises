using System;
class Program
{
    static void Main(string[] args)
    {
        string[] initialDay = Console.ReadLine().Split(' ');
        string[] initialHour = Console.ReadLine().Split(' ');

        string[] finalDay = Console.ReadLine().Split(' ');
        string[] finalHour = Console.ReadLine().Split(' ');

        DateTime d1 = new DateTime(2023, 1, int.Parse(initialDay[1]), int.Parse(initialHour[0]), int.Parse(initialHour[2]), int.Parse(initialHour[4]));
        DateTime d2 = new DateTime(2023, 1, int.Parse(finalDay[1]), int.Parse(finalHour[0]), int.Parse(finalHour[2]), int.Parse(finalHour[4]));

        TimeSpan t1 = d2.Subtract(d1);

        Console.WriteLine($"{t1.Days} dia(s)");
        Console.WriteLine($"{t1.Hours} hora(s)");
        Console.WriteLine($"{t1.Minutes} minuto(s)");
        Console.WriteLine($"{t1.Seconds} segundo(s)");
    }
}