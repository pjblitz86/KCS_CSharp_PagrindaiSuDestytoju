using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvedimasSujungimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda:");
            string Vardas = Console.ReadLine();

            Console.WriteLine("Iveskite megstamiausios spalvos pirma raide: ");
            char SpalvosPirmaRaide = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Iveskite 2 atsitiktinius skaicius:");
            int PirmasAtsitiktinisSkaicius = Convert.ToInt32(Console.ReadLine());
            int AntrasAtsitiktinisSkaicius = Convert.ToInt32(Console.ReadLine());

            int Suma = PirmasAtsitiktinisSkaicius + AntrasAtsitiktinisSkaicius;
            int Skirtumas = PirmasAtsitiktinisSkaicius - AntrasAtsitiktinisSkaicius;
            int Daugyba = PirmasAtsitiktinisSkaicius * AntrasAtsitiktinisSkaicius;
            double Dalyba = (double) PirmasAtsitiktinisSkaicius / AntrasAtsitiktinisSkaicius;

            Console.WriteLine("Jusu vardas: {0}\nMegstamiausios spalvos pirma raide yra {1}\nIvesti atsitiktiniai skaiciai: {2} {3}"
                 , Vardas, SpalvosPirmaRaide, PirmasAtsitiktinisSkaicius, AntrasAtsitiktinisSkaicius);
            Console.WriteLine("Skaiciu suma: {0}\nSkaiciu skirtumas: {1}\nSkaiciu daugyba: {2}\nSkaiciu dalyba {3}"
                                , Suma, Skirtumas, Daugyba, Dalyba);

            Console.ReadKey();

        }
    }
}
