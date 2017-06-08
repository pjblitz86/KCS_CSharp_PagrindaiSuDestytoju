using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma sveika skaiciu");
            int Sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra sveika skaiciu");
            int Sk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu ivesti skaiciai yra\n{0}\n{1}", Sk1, Sk2);
            Console.WriteLine();


            if (Sk1 > Sk2)
            {
                Console.WriteLine("Pirmas skaicius {0} yra didesnis uz {1} skaiciu", Sk1, Sk2);
                if (Sk1 % 3 == 0)
                {
                    Console.WriteLine("Skaicius {0} dalijasi is 3 be liekanos", Sk1);
                }
                else if (Sk2 % 3 == 0)
                {
                    Console.WriteLine("Skaicius {0} dalijasi is 3 be liekanos", Sk2);
                }
                else
                {
                    Console.WriteLine("Skaiciai {0) ir {1} nesidalija is 3 be liekanos", Sk1, Sk2);
                }
            }
            else if (Sk1 < Sk2)
            {
                Console.WriteLine("Pirmas skaicius {0} yra mazesnis uz {1} skaiciu", Sk1, Sk2);
            }
            else
            {
                Console.WriteLine("Pirmas skaicius {0} yra lygus {1} skaiciui", Sk1, Sk2);

            }

            // tikriname ar skaiciai lyginiai
            if (Sk1 % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", Sk1);
            }

            if (Sk2 % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", Sk2);
            }

            // tikriname ar skaiciai dalijasi is 3 ir is 5 ir yra mazesni nei 1000
            if ((Sk1 % 3 == 0) && (Sk1 % 5 == 0) && (Sk1 < 1000)) 
            {
                Console.WriteLine("Skaicius {0} dalijasi is 3 ir 5 be liekanos ir yra mazesnis uz 1000", Sk1);
            }

            if ((Sk2 % 3 == 0) && (Sk2 % 5 == 0) && (Sk2 < 1000))
            {
                Console.WriteLine("Skaicius {0} dalijasi is 3 ir 5 be liekanos ir yra mazesnis uz 1000", Sk2);
            }

            Console.ReadKey();
            }
        }
    }

