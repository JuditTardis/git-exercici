using System;

namespace exercici_3_fase_2
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
            Array.Sort(arrayCiutats);
            foreach(string i in arrayCiutats)
            {
                Console.WriteLine(i);
            }
        }
    }
}
