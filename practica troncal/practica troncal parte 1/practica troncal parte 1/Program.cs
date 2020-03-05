using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static string Escape { get; set; }
        static List<double> Marks { get; set; }

        static void Main(string[] args)
        {
            Marks = new List<double>();
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            ShowMainMenu();
            
            while (true)
            {
                
                var option = Console.ReadKey().KeyChar;

                if (option == 'm')
                {
                    ClearCurrentConsoleLine();
                    if (Escape != "m")
                    {
                        Console.WriteLine();
                        ShowMainMenu();
                    }
                }
                else if (option == 'n')
                {
                    ClearCurrentConsoleLine();
                    if (Escape != "n")
                    {
                        Console.WriteLine();
                        AddNotesMenu();
                    }
                }
                else if (option == 'c')
                {
                    ClearCurrentConsoleLine();
                    if (Escape != "c")
                    {
                        Console.WriteLine();
                        StaticsMenu();
                    }
                }
            }

             }
        static void ShowMainMenu()
        {
            Escape = "m";
            Console.WriteLine("Menu de opciones principal");
            Console.WriteLine("Opciones: m - para volver a este menu");
            Console.WriteLine("Opciones: n - añadir notas de alumnos");
            Console.WriteLine("Opciones: c - Estadísticas");
        }
        static void AddNotesMenu()
        {
            Escape = "n";
            Console.WriteLine("Menu para añadir notas. Añada las notas y presiona enter");
            Console.WriteLine("Presione m para acabar y volver al menú principal");
           while (true)
            {
                var nota = Console.ReadLine();
                if (nota == "m")
                {
                    break;
                }
                else
                {
                    double valorNota;
                    if (double.TryParse(nota.Replace(".",","), out valorNota))
                    {
                        Marks.Add(valorNota);
                    }
                    else
                    {
                        Console.WriteLine($"El valor introducidio [{nota}] no és válido");
                    }
                }
            }
            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();

        }
        static void StaticsMenu()
        {
            Escape = "c";
            Console.WriteLine("Opción de Estadísticas");
            Console.WriteLine("Presione m para acabar y volver al menú principal");
            Console.WriteLine("Opciones: avg - obtener la media de las notas de los alumnos");
            Console.WriteLine("Opciones: max - obtener la máxima nota de los alumnos");
            Console.WriteLine("Opciones: min - obtener la mínima nota de los alumnos");
            while (true)
            {
                var escoger = Console.ReadLine();
                if (escoger == "m")
                {
                    break;
                }
                else if (escoger == "avg")
                {
                    ShowMedia();
                }
                else if (escoger == "min")
                {
                    Minim();
                }
                else if (escoger == "max")
                {
                    Maxim();
                }
            }
            ClearCurrentConsoleLine();
            Console.WriteLine();
            ShowMainMenu();
        }
        static void ShowMedia()
        {
           // var avg = GetAverage();
            Console.WriteLine($"La media actual es: {Marks.Average()}");
            Console.WriteLine();
        }
        static void Minim()
        {
            // var avg = GetAverage();
            Console.WriteLine($"La nota mas baja es: {Marks.Min()}");
            Console.WriteLine();
        }
        static void Maxim()
        {
            // var avg = GetAverage();
            Console.WriteLine($"La nota mas alta es: {Marks.Max()}");
            Console.WriteLine();
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
     
    }
}
