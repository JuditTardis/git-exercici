using System;
using System.Collections.Generic;
namespace Exercici_4_fase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneda1 = 1;
            int moneda2 = 2;
            int billet5 = 5;
            int billet10 = 10;
            int billet20 = 20;
            int billet50 = 50;
            int billet100 = 100;
            int billet200 = 200;
            int billet500 = 500;
            int PreuTotal = 0;
            string[] Menu = new string[5];
            int[] Preus = new int[5];
            List<string> MenuPreus = new List<string>();
            for (var i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine($"Digues el nom del plat {i + 1}");
                Menu[i] = Console.ReadLine();
                Console.WriteLine($"Digues el preu del plat {i + 1}");
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
                if (si == 0)
                {
                        factura = false;
                }
                Console.WriteLine("El menu escollit es el següent:");
                MenuEs.ForEach(Console.WriteLine);
                bool comparació = true;
                foreach ( var chose in MenuEs)
                {
                    for(var i = 0; i<Preus.Length; i++)
                    {
                        if (chose == Menu[i])
                        {
                            PreuTotal += Preus[i];
                            comparació = true;
                        }
                    }
                    if(comparació != true)
                    {
                        Console.WriteLine($"El plat demanat no existex: {chose}"); 
                    }
                }
                Console.WriteLine($"El preu total es {PreuTotal}");
                int x1 = PreuTotal / billet500;
                if (x1 > 0)
                {
                    PreuTotal = PreuTotal - billet500 * x1;
                }
                else x1 = 0;
                int x2 = PreuTotal / billet200;
                if (x2 > 0)
                {
                    PreuTotal = PreuTotal - billet200 * x2;
                }
                else x2 = 0;
                int x3 = PreuTotal / billet100;
                if (x3 > 0)
                {
                    PreuTotal = PreuTotal - billet100 * x3;
                }
                else x3 = 0;
                int x4 = PreuTotal / billet50;
                if (x4 > 0)
                {
                    PreuTotal = PreuTotal - billet50 * x4;
                }
                else x4 = 0;
                int x5 = PreuTotal / billet20;
                if (x5 > 0)
                {
                    PreuTotal = PreuTotal - billet20 * x5;
                }
                else x5 = 0;
                int x6 = PreuTotal / billet10;
                if (x6 > 0)
                {
                    PreuTotal = PreuTotal - billet10 * x6;
                }
                else x6 = 0;
                int x7 = PreuTotal / billet5;
                if (x7 > 0)
                {
                    PreuTotal = PreuTotal - billet5 * x7;
                }
                else x7 = 0;
                int x8 = PreuTotal / moneda2;
                if (x8 > 0)
                {
                    PreuTotal = PreuTotal - moneda2 * x8;
                }
                else x8 = 0;
                int x9 = PreuTotal / moneda1;
                if (x9 > 0)
                {
                    PreuTotal = PreuTotal - moneda1 * x9;
                }
                else x9 = 0;
                Console.WriteLine($"Has de pagar amb:");
                Console.WriteLine(x1 + " billets de 500");
                Console.WriteLine(x2 + " billets de 200");
                Console.WriteLine(x3 + " billets de 100");
                Console.WriteLine(x4 + " billets de 50");
                Console.WriteLine(x5 + " billets de 20");
                Console.WriteLine(x6 + " billets de 10");
                Console.WriteLine(x7 + " billets de 5");
                Console.WriteLine(x8 + " monedes de 2");
                Console.WriteLine(x9 + " monedes de 1");
                // m'agradaria que lo dels billets sortis quant ja no es vol demanar mes i no cada vegada que demanes

            }
        }
    }
}
