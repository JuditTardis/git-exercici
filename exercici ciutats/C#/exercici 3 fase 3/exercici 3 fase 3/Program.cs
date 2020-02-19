using System;
using System.Linq;
namespace exercici_3_fase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix els noms de sis ciutats");
            string[] arrayCiutats = new string[6];
            arrayCiutats[0] = Console.ReadLine();
            arrayCiutats[1] = Console.ReadLine();
            arrayCiutats[2] = Console.ReadLine();
            arrayCiutats[3] = Console.ReadLine();
            arrayCiutats[4] = Console.ReadLine();
            arrayCiutats[5] = Console.ReadLine();
            string[] arrayCiutatsModificades = new string[arrayCiutats.Length];
            arrayCiutatsModificades = arrayCiutats.Select(s => s.Replace("a", "4")).ToArray();
            Array.Sort(arrayCiutatsModificades);
            foreach ( string i in arrayCiutatsModificades)
            {
                Console.WriteLine(i);
            }
        }
    }
}
