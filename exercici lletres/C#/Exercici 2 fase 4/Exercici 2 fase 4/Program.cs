using System;
using System.Collections.Generic;
namespace Exercici_2_fase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriu el teu nom");
            string nom = Console.ReadLine().ToLower();
            List<char> list_nom = new List<char>();
            list_nom.AddRange(nom.ToCharArray());
            Console.WriteLine("escriu el teu cognom");
            string cognom = Console.ReadLine().ToLower();
            List<char> list_cognom = new List<char>();
            list_cognom.AddRange(cognom.ToCharArray());
            List<char> list_FullName = new List<char>();
            list_FullName.AddRange(list_nom.ToArray());
            list_FullName.Add(' ');
            list_FullName.AddRange(list_cognom.ToArray());
            for (var i = 0; i < list_FullName.Count; i++)
            {
                Console.WriteLine(list_FullName[i]);
            }
        }
    }
}
