using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S:Citire la tastatura\nA:Afisare note\nX:Iesire\n");
            int a = 1;
            Student s = new Student("Ionescu");
            string c;
            while (a != 0){
                {
                    switch (c = Console.ReadLine())
                    {
                        case "s":
                            Console.WriteLine("scrieti notele despartite prin splatiu, iar anii despartiti prin spatiu si virgula");
                            string sir = Console.ReadLine();
                            s.Setnote(sir);
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
