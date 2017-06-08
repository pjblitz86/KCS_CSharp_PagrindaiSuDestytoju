using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 sveikus skaicius");
            int ivestasSkaicius1 = Convert.ToInt32(Console.ReadLine());
            int ivestasSkaicius2 = Convert.ToInt32(Console.ReadLine());
            int ivestasSkaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (ivestasSkaicius1)
            {
                case 1:
                    int suma = ivestasSkaicius1 + ivestasSkaicius2 + ivestasSkaicius3;
                    Console.WriteLine("{0}+{1}+{2}={3}", ivestasSkaicius1, ivestasSkaicius2, ivestasSkaicius3, suma);
                    break;
                case 2:
                    int pirmoIrTrecioSkirtumas = ivestasSkaicius1 - ivestasSkaicius3;
                    Console.WriteLine("{0}-{1}={2}", ivestasSkaicius1, ivestasSkaicius3, pirmoIrTrecioSkirtumas);
                    break;
                case 3:
                    int antroIrTrecioSandauga = ivestasSkaicius2 * ivestasSkaicius3;
                    Console.WriteLine("{0}*{1}={2}", ivestasSkaicius2, ivestasSkaicius3, antroIrTrecioSandauga);
                    break;
                default:
                    Console.WriteLine("Pirmas skaicius nera 1, 2 ar 3");
                    break;
            }
            Console.ReadKey();

        }
    }
}
