using System;

namespace exercici_1_fase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int year = 1948;
            int traspaso = 4;
            Console.WriteLine("Introduzce tu año de nacimiento");
            var nacimiento = Convert.ToInt32(Console.ReadLine());
            int resultado =((nacimiento - traspaso) / year);
            Console.WriteLine("Desde el año " + year + " hasta el año " + nacimiento + "ha habido " + resultado + "años de traspaso.");

        }
    }
}
