﻿using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S:Citire la tastatura\nT:Citire de la tastatura\nC:Citire note din linia de comanda\nA:Afisare note\nX:Iesire\n");
            int a = 1;
            Student s = new Student("Ionescu");
            string c;
            while (a != 0){
                {
                    switch (c = Console.ReadLine())
                    {
                        case "s":
                            string sir = Console.ReadLine();
                            s.Setnote(sir);
                            break;
                        case "t":
                            s.SetNote();
                            break;
                        case "c":s.SSetnote(args);
                            break;
                        case "a":
                            s.ConversieLaSir();
                            break;
                        case "x":
                            a = 0;
                            break;
                    }
                }
            }
        }
    }
}
