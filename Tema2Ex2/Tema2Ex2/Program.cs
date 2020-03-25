using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,i = 0;
            a = b = i;
            string[][] cuvinted = new string[5][];
            cuvinted[0] = new string[2];
            cuvinted[1] = new string[3];
            cuvinted[2] = new string[4];
            cuvinted[3] = new string[5];
            cuvinted[4] = new string[6];
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                // afisarea argumentelor liniei de comanda
                foreach (string param in args)
                {
                    //luam paramteru cu parametru si verificam cu litera incepe sipunem in tablou
                    if (param[0] == 'a')
                    {
                        cuvinted[0][a] = param;
                        a++;
                    }
                    if (param[1] == 'b')
                    {
                        cuvinted[1][b] = param;
                        b++;
                    }
                    //... tot asa pana la z
                }
                // exemplu utilizare instructiune switch
                Console.WriteLine(cuvinted);
            }
            Console.ReadKey();
        }
    }
}
