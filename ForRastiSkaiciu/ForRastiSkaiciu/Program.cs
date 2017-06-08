using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForRastiSkaiciu
{
    class Program
    {
        // Rasti skaiciu zemesni uz 100 ir kurie dalijasi is 7, sandauga
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(sandauga*= i);
                }
            }
            Console.ReadKey();
        }
    }
}
