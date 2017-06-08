using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSkaiciuokle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC SKAICIUOKLE");
            Console.WriteLine("*****************");

            Console.WriteLine("Iveskite pirma sveika skaiciu");
            int Sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Pasirinkite veiksma\n+ sudeciai\n- atimciai\n* daugybai\n/ dalybai");
            char Veiksmas = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Iveskite antra sveika skaiciu");
            int Sk2 = Convert.ToInt32(Console.ReadLine());

            int suma = Sk1 + Sk2;
            int atimtis = Sk1 - Sk2;
            int sandauga = Sk1 * Sk2;
            //int dalyba = Sk1 / Sk2; ikelta i nested if

            if (Veiksmas == '+')
            {
                Console.WriteLine();
                Console.WriteLine("{0}{1}{2}={3}", Sk1, Veiksmas, Sk2, suma);
            }
            else if (Veiksmas == '-')
            {
                Console.WriteLine();
                Console.WriteLine("{0}{1}{2}={3}", Sk1, Veiksmas, Sk2, atimtis);
            }
            else if (Veiksmas == '*')
            {
                Console.WriteLine();
                Console.WriteLine("{0}{1}{2}={3}", Sk1, Veiksmas, Sk2, sandauga);
            }
            else if ((Veiksmas == '/'))
            {
                Console.WriteLine();
                if (Sk2 !=0)
                {
                  int dalyba = Sk1 / Sk2;
                  Console.WriteLine("{0}{1}{2}={3}", Sk1, Veiksmas, Sk2, dalyba);
                } 
                else
                {
                    Console.WriteLine("Dalyba is nulio negalima");
                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ivestas neatpazintas zenklas");
            }
    
                Console.ReadKey();

        }
    }
}
