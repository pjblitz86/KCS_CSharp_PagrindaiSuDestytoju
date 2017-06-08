using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello world arba labas pasauli
            Console.WriteLine("hello world");

            string Vardas = "Paulius";
            string Pavarde = "Juknis";
            int Amzius = 31;
            double Ugis = 1.75; // metrai
            double Svoris = 90.00;
            string AukstojiMokykla = "KTU";
            string AkademinesGrupesKodas = "EV2014";
            int Kursas = 3;
            string StudijuProgramosPavadinimas = "Verslo Ekonomika";
            int AtsiskaitytuKredituSkaicius = 120;

            Console.WriteLine();
            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine("{0} {1} ({2}m.)\nJo ugis yra {3}m, o svoris {4}kg\nJis mokosi aukstojoje mokykloje: {5}\nAkademine grupe kuriai jis priklauso yra {6}\nJau yra baiges {7} kursus, siuo metu mokosi {8}\nPer studiju laikotarpi atsiskaite uz {9} kreditu"
                ,Vardas, Pavarde, Amzius, Ugis, Svoris, AukstojiMokykla, AkademinesGrupesKodas, Kursas, StudijuProgramosPavadinimas, AtsiskaitytuKredituSkaicius);
       
            Console.ReadKey();
        }
    }
}
