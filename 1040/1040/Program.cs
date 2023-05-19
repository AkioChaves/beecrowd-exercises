using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, media, exame, mediaFinal;
        string[] nota = Console.ReadLine().Split(' ');

        n1 = double.Parse(nota[0], CultureInfo.InvariantCulture);
        n2 = double.Parse(nota[1], CultureInfo.InvariantCulture);
        n3 = double.Parse(nota[2], CultureInfo.InvariantCulture);
        n4 = double.Parse(nota[3], CultureInfo.InvariantCulture);

        media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
        Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media <= 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaFinal = (exame + media) / 2;
            Console.WriteLine($"Nota do exame: {exame.ToString("F1", CultureInfo.InvariantCulture)}");

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}