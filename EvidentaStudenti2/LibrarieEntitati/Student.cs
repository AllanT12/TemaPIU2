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

        public void SetNote()
        {
            Console.WriteLine("Cate note doriti pentru anul 1:");
            int n =Convert.ToInt32(Console.ReadLine());
                 for(int i=0;i<n;i++)
                    {
                      note[0][i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cate note doriti pentru anul 2:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cate note doriti pentru anul 3:");
             n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cate note doriti pentru anul 4:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[3][i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void Setnote()
        {
            note = new int[4][];
            note[0] = new int[15];
            note[1] = new int[15];
            note[2] = new int[15];
            note[3] = new int[15];
            int i = 0,j=0;
            string sir = Console.ReadLine();
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
