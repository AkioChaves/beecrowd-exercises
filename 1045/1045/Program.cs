using System;
using System.Globalization;
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)
    {
        double v1, v2, v3, a, b, c;
        string[] valores = Console.ReadLine().Split(' ');

        v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if (v1 > v2 && v1 > v3)
        {
            a = v1;
            if (v2 > v3)
            {
                b = v2;
                c = v3;
            }
            else
            {
                b = v3;
                c = v2;
            }
        }
        else if (v2 > v3 && v2 > v1)
        {
            a = v2;
            if (v3 > v1)
            {
                b = v3;
                c = v1;
            }
            else
            {
                b = v1;
                c = v3;
            }
        }
        else
        {
            a = v3;
            if (v1 > v2)
            {
                b = v1;
                c = v2;
            }
            else
            {
                b = v2;
                c = v1;
            }
        }

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }    
    }
}