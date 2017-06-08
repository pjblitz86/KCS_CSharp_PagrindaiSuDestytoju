using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("******");

            for (var i = 0; i < 20; i+=3)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
