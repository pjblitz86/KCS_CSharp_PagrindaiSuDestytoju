using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki1000SalygaSuFor
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveika skaiciu nuo 1 iki 1000: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            for (int i = skaicius; skaicius < 1000; skaicius++)
            {
                if((skaicius % 3 ==0) && (skaicius % 5 == 0))
                {
                    Console.WriteLine(skaicius);
                }
            }
            Console.ReadKey();
        }
    }
}
