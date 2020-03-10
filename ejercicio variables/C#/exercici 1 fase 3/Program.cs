using System;

namespace exercici_1_fase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var any = 1948;
            var traspas = 4;
            var naixement = 1996;
            string si = "El teu any de naixement era de traspas";
            string no = "El teu any de naixement no era de traspas";
            bool coincide = true;
            for (any; any <= naixement; any = any + traspas)
            {
                Console.WriteLine(any);
                var coincide = (any == naixement);
                if (coincide)
                {
                    Console.WriteLine(si);
                }
                else
                {
                    Console.WriteLine(no);
                }
            }
        }
    }
}
