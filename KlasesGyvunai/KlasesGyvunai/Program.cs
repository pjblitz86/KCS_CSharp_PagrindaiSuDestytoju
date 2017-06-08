using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesGyvunai
{
    class Gyvunas
    {
        public string Pavadinimas;
        public string KraujoTemperatura;
        public int Plaukuotumas; // 0-100
        public bool DedaKiausinius;
        public string Zinduolis;

        // is 3 bent 2 salygos ivykdytos

        public Gyvunas(string pavadinimas, string kraujoTemperatura, int plaukuotumas, bool dedaKiausinius)
        {
            Pavadinimas = pavadinimas;
            KraujoTemperatura = kraujoTemperatura;
            Plaukuotumas = plaukuotumas;
            DedaKiausinius = dedaKiausinius;
        }

        public void ZinduolioPatikrinimas()
        {
            int temp = 0;
            if(KraujoTemperatura == "siltakraujis" || KraujoTemperatura == "Siltakraujis")
            {
                temp++;
            }
            if (Plaukuotumas > 20)
            {
                temp++;
            }
            if (!DedaKiausinius)
            {
                temp++;
            }
            if(temp >=2)
            {
                Zinduolis = "Zinduolis";
            }
            else
            {
                Zinduolis = "Nezinduolis";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AR GYVUNAS ZINDUOLIS?");
            Console.WriteLine();

            Console.WriteLine("Iveskite gyvuno pavadinima");
            string pavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite siltakraujis jei siltakraujis");
            string siltakraujis = Console.ReadLine();
            Console.WriteLine("Iveskite plaukuotuma nuo 0 iki 20");
            int plaukuotumas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ar deda kiausinius");
            string kiausiniai = Console.ReadLine();
            bool dedaKiausinius = false;
            if (kiausiniai == "Taip" || kiausiniai == "taip")
            {
                dedaKiausinius = true;
            }

            Gyvunas gyvunas = new Gyvunas(pavadinimas, siltakraujis, plaukuotumas, dedaKiausinius);

            gyvunas.ZinduolioPatikrinimas();
            Console.WriteLine();
            Console.WriteLine(gyvunas.Pavadinimas + " " + gyvunas.KraujoTemperatura + " " + gyvunas.Plaukuotumas 
                + " " + gyvunas.DedaKiausinius + " " + gyvunas.Zinduolis);
            Console.ReadKey();

        }
    }
}
