using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIBONACI SKAICIAI\n");
            Console.WriteLine("*******************");
            Console.Write("Iveskite kiek norite atvaizduoti fibonacio sekos skaiciu: ");
            
            int dydis = Convert.ToInt32(Console.ReadLine());

            int pirmasSkaicius = 1;
            int antrasSkaicius = 1;
            int treciasSkaiciusSuma = pirmasSkaicius + antrasSkaicius;

            Console.Write("1 1 ");
            for (int i = 2; i < dydis; i++)
            {
                Console.Write("{0} ", treciasSkaiciusSuma);
                pirmasSkaicius = antrasSkaicius;
                antrasSkaicius = treciasSkaiciusSuma;
                treciasSkaiciusSuma = pirmasSkaicius + antrasSkaicius;
            }

            Console.ReadKey();
        }
    }
}
