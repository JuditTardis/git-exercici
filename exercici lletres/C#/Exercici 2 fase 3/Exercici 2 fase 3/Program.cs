using System;
using System.Collections.Generic;
namespace Exercici_2_fase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> lletres = new Dictionary<char, int>();
            Console.WriteLine("Escriu el teu nom");
            string nom = Console.ReadLine();
            char[] desglossat_nom = nom.ToCharArray();
            int i;
            for (i = 0; i < desglossat_nom.Length; i++)
            {
                lletres.Add(desglossat_nom[i], 1);
                foreach (char x in lletres.Keys)
                {
                    Console.WriteLine("Lletra: " + x);
                    foreach(int y in lletres.Values)
                    {
                        Console.WriteLine("Nombre intents " + y);
                    }
                }
                
            }
            // A la hora de ejecutar la consola, algunas letras se me repiten y lo de poner las veces que una misma letra aparece, no acaba de funcionar.
            // Se me hacen diferentes lineas todas diciendo lo mismo diferentes veces.
        }
    }
}
