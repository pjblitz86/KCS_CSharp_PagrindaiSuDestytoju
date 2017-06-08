using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaiciaiIRaides
{
    // MS Excel naudoja specialu formata pavadinti savo stulpeliams. Pirmi 26 stulpeliai naudoja raides
    // nuo A iki Z savo hederiams pavadinti. Tuomet Excel pradeda naudoti 2 raides savo hederio 
    // pavadinime taip kad 27 ir 28 stulpeliai yra AA ir AB, dar sekantis prasides nuo BA. Po ZZ Excel naudoja jau 3 raides.
    
    // *UZDUOTIS. Parasyti programa kuri priimtu stulpelio numeri ir isvestu jo hederi.
    // Iejimo parametras nebus didesnis nei ZZZ.
    class Program
    {
        static void Main(string[] args)
        {
            // visas skaicius 26*26*26 nuo A iki ZZZ, nes nuo A iki Z yra 26.
            // A...Z     A...Z      A...Z
            //  26         26         26
            // SKR1 = SK/(26*26)
            // SKR2 = SK%(26*26)
            // SKR3 = SK/26

            int skaiciusIsVisoVar = 26 * 26 * 26;
          
            

            Console.WriteLine("RAIDZIU KONVERTAVIMAS I SKAICIUS EXCEL STULPELIUOSE");
            Console.WriteLine();

            Console.Write("Pasirinkite kiek norite ivesti raidziu:\n" + 
                            "1 - viena\n"+
                            "2 - dvi\n"+
                            "3 - tris\n");
            int kiekRaidziu = Convert.ToInt32(Console.ReadLine());

            switch (kiekRaidziu)
            {
                case 1:
                    Console.Write("Iveskite viena angliska raide nuo A iki Z imtinai: ");
                    int i;
                    for (i = 1; i <= 26; i++)
                    {
                        char ivesta1Raide = Convert.ToChar(Console.ReadLine().ToUpper());
                        Console.WriteLine(i);
                    }
                    int skaicius1Raidei = (skaiciusIsVisoVar / (26 * 26);
                    Console.WriteLine("Jusu ivesta raide {0} atitinka {1} skaiciu", ivesta1Raide, skaicius1Raidei);
                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    Console.WriteLine("Kazka blogai ivedete, reikia pasirinkt 1, 2 arba 3");
                    break;
            }

           
            Console.ReadKey();


        }
    }
}
