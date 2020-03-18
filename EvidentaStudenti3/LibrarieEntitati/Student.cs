using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[][] note;
        static int p=0;
        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }
        public void Setnote()
        {
            note = new int[4][];
            string sir = Console.ReadLine();
            note[0] = new int[sir.Length];
            sir = Console.ReadLine();
            note[1] = new int[sir.Length];
            sir = Console.ReadLine();
            note[2] = new int[sir.Length];
            sir = Console.ReadLine();
            note[3] = new int[sir.Length];
            int i = 0,j=0;
            
            string[] _note = sir.Split(' ');
            p = sir.Length;
            foreach(var nota in _note)
            {
                if (nota == ",")
                {
                    i++;
                    j = 0;
                    p -= 2;
                }
                else
                {
                    note[i][j] = Convert.ToInt32(nota);
                    j++;
                }
            }
        }
        public void ConversieLaSir()
        {
            Console.WriteLine(nume);
            for (int i = 0; i < 4; i++)
            {
                int n = i;
                n++;
                Console.Write("An{0}",n);
                for (int j = 0; j <p ; j++)
                    Console.Write("{0}",note[i][j]);
                Console.Write("\n");
            }
        }
    }
}
