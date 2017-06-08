using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuSkaiciai
{
    class Program
        // ivesti du skaicius. Isvesti suma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 sveikus skaicius");
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int suma = pirmasSkaicius + antrasSkaicius;

            Console.WriteLine("Ivestu skaiciu {0} ir {1} suma yra lygi {2}", 
                pirmasSkaicius, antrasSkaicius, suma);
            Console.ReadKey();

        }
    }
}
