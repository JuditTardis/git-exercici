using System;
using System.Collections.Generic;
namespace exercici_2_fase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriu el teu nom");
            string nom = Console.ReadLine().ToLower();
            List<char> list_nom = new List<char>();
            list_nom.AddRange(nom.ToCharArray());
            for (var i =0; i< list_nom.Count; i++)
            {
                Console.WriteLine(list_nom[i]);
                if ((list_nom[i] == 'a') || (list_nom[i] == 'e') || (list_nom[i] == 'i') || (list_nom[i] == 'o') || (list_nom[i] == 'u'))
                {
                    Console.WriteLine("Vocal");
                }
                else if ((list_nom[i] == '0') || (list_nom[i] == '1') || (list_nom[i] == '2') || (list_nom[i] == '3') || (list_nom[i] == '4') || (list_nom[i] == '5') || (list_nom[i] == '6') || (list_nom[i] == '7') || (list_nom[i] == '8') || (list_nom[i] == '9')){
                    Console.WriteLine("Els noms de les persones no contenen numeros");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }

            }
        }
    }
}
