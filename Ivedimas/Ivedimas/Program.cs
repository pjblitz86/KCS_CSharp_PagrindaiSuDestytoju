using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivedimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zodi arba sakini:");
            string IvestasTekstas = Console.ReadLine();
            Console.WriteLine("Jusu ivestas tekstas:\n" + IvestasTekstas);
            Console.ReadKey();

        }
    }
}
