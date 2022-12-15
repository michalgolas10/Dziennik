using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dziennik
{
    internal class Startdziennika
    {
        public static void startdziennika()
        {
            WriteLine("Witaj w aplikacji Dziennik wybierz co chcesz zrobić");
            WriteLine("1. Dodaj ocene uczniowi");
            WriteLine("2. Wyświetl oceny ucznia");
            WriteLine("3. Zapisz oceny do pliku csv");
            WriteLine("4. Zczytaj oceny z pliku csv");
            int h = int.Parse(ReadLine()); 
            switch (h)
            {
                case 1: StartDziennik.DodajOceneUczniowi(); break;
                case 2: break;
                case 3: break;
                case 4: break;
            }
        }
    }
}
