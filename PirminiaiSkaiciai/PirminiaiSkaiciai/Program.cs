using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirminiaiSkaiciai
{
    // isvesti pirminius skaicius (dalijasi is 1 ir is saves) nuo 1 iki 1000. 1 ne pirminis.
    // reikalingas for nested.
    class Program
    {
        static void Main(string[] args)
        {
            // lokaliai pasirasom i ir j
            int i, j;
            int suma = 0;
            Console.WriteLine("Pirminiai skaiciai:");
            for (i = 2; i <= 1000; i++)
            {
                int veliava = 0;
                for (j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        veliava++; // jei rasta dalyba be liekanos - ne pirminis
                    }
                }
                if (veliava == 0) // tik jei veliava 0 tada itrauks 
                {
                    suma += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Suma: " + suma);
           
            Console.ReadKey();
                 
        }
    }
}
