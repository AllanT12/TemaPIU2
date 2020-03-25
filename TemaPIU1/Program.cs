using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 4);//1->3
            Sejur T1 = new Sejur("Romania", "Bucurest", 500);
            Sejur T2 = new Sejur("Italia", "Roma", 1000);
            Sejur T3 = new Sejur("Spania", "Madrid", 1500);
            Utilizator U = new Utilizator("Tanasa", "Alin", 1000);
            Console.WriteLine("Felicitari!");
            Console.WriteLine(U);
            Console.WriteLine("Ati castigat un sejur la:");
            if (i == 1)
            { string s1 = T1.Afisare(); Console.WriteLine(s1); }
            else if(i==2)
            { string s1 = T2.Afisare(); Console.WriteLine(s1); }
            else
            { string s1 = T3.Afisare(); Console.WriteLine(s1); }
            //lab 3 ex 1
            string[] randuri = System.IO.File.ReadAllLines(@"C:\Users\Alin\Desktop\TemaPIU1\TemaPIU1\input.txt");
            foreach(string rand in randuri)
            {
                string[] cuvinte=rand.Split(' ');
                Sejur T4 = new Sejur(cuvinte[0],cuvinte[1],cuvinte[2]);
                //daca punem mai multe randuri ar trebuii sa creeam un vector de de obiecte de tipul Sejur
                string s2 = T4.Afisare(); Console.WriteLine(s2);//in mod normal nu pun afisare aici
            }

            

            Console.ReadKey();
        }
    }
}
