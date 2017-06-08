using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrikampioKrastines
{
    // parasyti programa kuri nustato ar imanoma is 3 krastiniu ilgiu sudaryti trikampi
    // (a + b) > c
    // (a + c) > b
    // (b + c) > a
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Si programa nustatys ar is jusu ivestu krastiniu ilgiu imanoma sudaryti trikampi");
            Console.WriteLine();

            Console.WriteLine("Iveskite pirmos krastines ilgi");
            int Krastine1 = Convert.ToInt32(Console.ReadLine());
            if (Krastine1 <= 0)
            {
                Console.WriteLine("Krastine negali buti neigiama");
            }

            Console.WriteLine("Iveskite antros krastines ilgi");
            int Krastine2 = Convert.ToInt32(Console.ReadLine());
            if (Krastine2 <= 0)
            {
                Console.WriteLine("Krastine negali buti neigiama");
            }

            Console.WriteLine("Iveskite trecios krastines ilgi");
            int Krastine3 = Convert.ToInt32(Console.ReadLine());
            if (Krastine3 <= 0)
            {
                Console.WriteLine("Krastine negali buti neigiama");
            }

            if (((Krastine1 + Krastine2) > Krastine3) && ((Krastine1 + Krastine3) > Krastine2) && ((Krastine2 + Krastine3) > Krastine1))
            {
                Console.WriteLine("Galima sudaryti trikampi is siu skaiciu");
            }

            Console.ReadKey();

        }
    }
}
