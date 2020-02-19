using System;
using System.Collections.Generic;
namespace exercici_4_fase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int billet5 = 5;
            int billet10 = 10;
            int billet20 = 20;
            int billet50 = 50;
            int billet100 = 100;
            int billet200 = 200;
            int billet500 = 500;
            int PreuTotal;
            string[] Menu = new string[5];
            int[] Preus = new int[5];
            List<string> MenuPreus = new List<string>();
            for (var i = 0; i<Menu.Length; i++)
            {
                Console.WriteLine($"Digues el nom del plat {i+1}");
                Menu[i] = Console.ReadLine();
                Console.WriteLine($"Digues el preu del plat {i+1}");
                Preus[i] = Convert.ToInt32(Console.ReadLine());
                MenuPreus.Add($"{Menu[i]}{Preus[i]}");
            }
            List<string> MenuEs = new List<string>();
            bool factura = true;
            while (factura)
            {
                Console.WriteLine("Quin plat vols escollir?");
                Console.WriteLine($"{Menu[0]} {Preus[0]}");
                Console.WriteLine($"{Menu[1]} {Preus[1]}");
                Console.WriteLine($"{Menu[2]} {Preus[2]}");
                Console.WriteLine($"{Menu[3]} {Preus[3]}");
                Console.WriteLine($"{Menu[4]} {Preus[4]}");
                MenuEs.Add(Console.ReadLine());
                Console.WriteLine("Vols seguir demanant? 1:Si 0:No");
                int si = Int32.Parse(Console.ReadLine());
                if ( si == 0)
                {
                    factura = false;
                }
                Console.WriteLine("El menu escollit es el següent:");
                MenuEs.ForEach(Console.WriteLine);
               
            }
            
        }
    }
}
