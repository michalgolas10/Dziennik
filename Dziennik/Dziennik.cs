using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{

    public class Dziennik
    { 
        public string name { get; set; }
        public string surname { get; set; }

        public List<int> marks = new();

        public Dziennik(string Imie, string nazwisko)
        {
            name = Imie;
            surname = nazwisko;
        }


        public void DodajOcene(int ocena)
        {
            marks.Add(ocena);
        }

    }
}
