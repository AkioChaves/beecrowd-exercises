using System;
class Program
{
    static void Main(string[] args)
    {
        int novoGrenal = 1;
        int vGremio = 0;
        int vInter = 0;
        int empate = 0;
        int grenais = 0;

        while (novoGrenal == 1)
        {
            int inter, gremio;
            string[] vet = Console.ReadLine().Split(' ');
            inter = int.Parse(vet[0]);
            gremio = int.Parse(vet[1]);

            grenais++;
            if (inter > gremio)
            {
                vInter++;
            }
            else if (inter < gremio)
            {
                vGremio++;
            }
            else
            {
                empate++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoGrenal = int.Parse(Console.ReadLine());

            while (novoGrenal != 1 && novoGrenal != 2)
            {
                novoGrenal = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine($"{grenais} grenais");
        Console.WriteLine($"Inter:{vInter}");
        Console.WriteLine($"Gremio:{vGremio}");
        Console.WriteLine($"Empates:{empate}");
        if (vInter > vGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vInter < vGremio)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}