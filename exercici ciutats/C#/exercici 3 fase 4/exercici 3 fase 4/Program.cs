using System;

namespace exercici_3_fase_4
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
            Console.WriteLine("Les Ciutats al reves es veuran a continuació:");
            char[] ciutat1 = arrayCiutats[0].ToCharArray();
            foreach(char i in ciutat1)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat1);
            Console.Write(" - ");
            foreach (char i in ciutat1)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            char[] ciutat2 = arrayCiutats[1].ToCharArray();
            foreach (char i in ciutat2)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat2);
            Console.Write(" - ");
            foreach (char i in ciutat2)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            char[] ciutat3 = arrayCiutats[2].ToCharArray();
            foreach (char i in ciutat3)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat3);
            Console.Write(" - ");
            foreach (char i in ciutat3)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            char[] ciutat4 = arrayCiutats[3].ToCharArray();
            foreach (char i in ciutat4)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat4);
            Console.Write(" - ");
            foreach (char i in ciutat4)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            char[] ciutat5 = arrayCiutats[4].ToCharArray();
            foreach (char i in ciutat5)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat5);
            Console.Write(" - ");
            foreach (char i in ciutat5)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            char[] ciutat6 = arrayCiutats[5].ToCharArray();
            foreach (char i in ciutat6)
            {
                Console.Write(i);
            }
            Array.Reverse(ciutat6);
            Console.Write(" - ");
            foreach (char i in ciutat6)
            {
                Console.Write(i);
            }
        }
    }
}
