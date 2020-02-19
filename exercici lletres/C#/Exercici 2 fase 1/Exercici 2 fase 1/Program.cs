using System;

namespace Exercici_2_fase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriu el teu nom");
            string nom = Console.ReadLine();
            char[] desglossat_nom = nom.ToCharArray();
            int i;
            for (i=0; i< desglossat_nom.Length; i++)
            {
                Console.WriteLine(desglossat_nom[i]);
            }
        }
    }
}
