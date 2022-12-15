using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dziennik
{
    internal class StartDziennik
    {
        public static List<Dziennik> Uczniowie { get; set; } = new List<Dziennik>();

        public static void DodajUcznia(string imie, string nazwisko)
        {
            Dziennik uczen = new Dziennik(imie, nazwisko);
            Uczniowie.Add(uczen);
        }

        public static void DodajOcene(string imie, string nazwisko, int ocena)
        {
            Uczniowie.Find(x => x.name == imie && x.surname == nazwisko)?.DodajOcene(ocena);
        }
       
        public static void DodajOceneUczniowi()
        {
            WriteLine("Podaj Imie i nazwisko ucznia któremu chcesz dodać ocene");
            Write("Imie:");
            string imie = ReadLine();
            Write("Nazwisko:");
            string nazwisko = ReadLine();
            DodajUcznia(imie, nazwisko);
            Write("Wpisz ocene:");
            int ocena = int.Parse(Console.ReadLine());
            DodajOcene(imie, nazwisko, ocena);
        }   
        public static void Wyswietlocenyucznia()
        {
            WriteLine("Podaj Imie i Nazwisko którego oceny chcesz wypisać");
            Write("Imie:"); string imie = ReadLine();
            Write("Nazwisko:"); string Nazwisko = ReadLine();
            
        }


    }
}
    
    

