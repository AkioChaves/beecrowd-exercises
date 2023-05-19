using System;
class Program
{
    static void Main(string[] args)
    {
        string palavra = Console.ReadLine();

        if (palavra == "vertebrado")
        {
            palavra = Console.ReadLine();
            if (palavra == "ave")
            {
                palavra = Console.ReadLine();
                if (palavra == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else if (palavra == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
            else if (palavra == "mamifero")
            {
                palavra= Console.ReadLine();
                if (palavra == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else if (palavra == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else if (palavra == "invertebrado")
        {
            palavra= Console.ReadLine();
            if (palavra == "inseto")
            {
                palavra = Console.ReadLine();
                if (palavra == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (palavra == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
            else if (palavra == "anelideo")
            {
                palavra = Console.ReadLine();
                if (palavra == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (palavra == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}