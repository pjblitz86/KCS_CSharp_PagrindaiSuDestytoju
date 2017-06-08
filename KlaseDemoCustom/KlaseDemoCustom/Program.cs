using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseDemoCustom
{
    class Filmai
    {
        public string Pavadinimas;
        public string Zanras;
        public double TavoIvertinimas; // nuo 0 iki 10
        public double IMDB_reitingas;
        public string kiekGeras;
        public double vidutinisIvertinimas;
        private bool ArJumsVirs18 = false;
        private int slaptazodis = 18;

        public Filmai(string pavadinimas, string zanras, double tavoIvertinimas, double imdbReitingas)
        {
            Pavadinimas = pavadinimas;
            Zanras = zanras;
            TavoIvertinimas = tavoIvertinimas;
            IMDB_reitingas = imdbReitingas;
        }

        public void kiekGerasFilmas()
        {
            if ((TavoIvertinimas + IMDB_reitingas) / 2 >= 8.5)
            {
                kiekGeras = "Ziauriai geras filmas";
                vidutinisIvertinimas = (TavoIvertinimas + IMDB_reitingas) / 2;
            }
            else if ((TavoIvertinimas + IMDB_reitingas) / 2 >= 7 && (TavoIvertinimas + IMDB_reitingas) / 2 < 8.5)
            {
                kiekGeras = "Geras";
                vidutinisIvertinimas = (TavoIvertinimas + IMDB_reitingas) / 2;
            }
            else if ((TavoIvertinimas + IMDB_reitingas) / 2 >= 0 && (TavoIvertinimas + IMDB_reitingas) / 2 < 7)
            {
                kiekGeras = "Nieko gero";
                vidutinisIvertinimas = (TavoIvertinimas + IMDB_reitingas) / 2;
            }
            else
            {
                Console.WriteLine("Kazka blogai ivedete");
            }
        }
        public void Atrakinti(int PSW, int keisti)

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite slaptazodi:")
            private string slaptazodis = "18";

            Console.WriteLine("Iveskite filmo pavadinima");
            string pavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite filmo zanra");
            string zanras = Console.ReadLine();

            Console.WriteLine("Kiek balu nuo 1 iki 10 ji vertintumete?");
            double userIvertinimas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Koks filmo IMDB reitingas?");
            double imdbReitingas = Convert.ToDouble(Console.ReadLine());

            Filmai manoFilmas = new Filmai(pavadinimas, zanras, userIvertinimas, imdbReitingas);

            Console.WriteLine();
            Console.WriteLine("Pavadinimas: {0}\nZanras: {1}\nJusu ivertinimas: {2}\nIMDB ivertinimas: {3}\nVidutinis ivertinimas: {4}",
            manoFilmas.Pavadinimas, manoFilmas.Zanras, manoFilmas.TavoIvertinimas, 
            manoFilmas.IMDB_reitingas, manoFilmas.vidutinisIvertinimas);

            manoFilmas.kiekGerasFilmas();
            Console.WriteLine();
            Console.WriteLine(manoFilmas.kiekGeras);

            

            Console.ReadKey();
            /* susikurti objektu masyva, kad issaugotu filmus, ka suvede vartotojas
            
            Filmai[] manoFimai = new Filmai[10];
            for ciklas paskui su update funkcija
            */

            
        }
    }
}
