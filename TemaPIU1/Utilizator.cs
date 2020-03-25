using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Utilizator
    {
        string Nume;
        string Prenume;
        int Buget;
        public Utilizator(string _Nume,string _Prenume,int _Buget)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            Buget = _Buget;
        }
        public string Afisare()
        {
            return "Nimic";
        }
    }
}
