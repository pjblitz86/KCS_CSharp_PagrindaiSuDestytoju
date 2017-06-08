using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileUzduotis1Skaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHILE CIKLO PAVYZDYS");
            Console.Write("Iveskite pasirinkta skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            int lyginiuSkaiciuSuma = 0;

            while (skaicius > 0)
            {

                Console.Write(skaicius + "\t");
                if (skaicius % 2 == 0)
                {
                    lyginiuSkaiciuSuma += skaicius;
                }
                Console.WriteLine("Lyginiu skaiciu suma: {0}", lyginiuSkaiciuSuma);
                skaicius--;
            }
            Console.ReadKey();
        }
    }
}
