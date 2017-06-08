using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuTaskai
{
    class Program
    {
        // Vidurio tasko formule: (x1+x2)/2; (y1+y2)/2;
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite A tasko x ir y koordinates - sveiki skaiciai");
            int Ax = Convert.ToInt32(Console.ReadLine());
            int Ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Iveskite B tasko x ir y koordinates - sveiki skaiciai");
            int Bx = Convert.ToInt32(Console.ReadLine());
            int By = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // pvz Bx = (Cx + Ax)/2 - vidurio taskas, ieskant Cx issireiskiame; analogiskai ir su Cy 
            double Cx = (double) ((2*Bx - Ax));
            double Cy = (double) ((2*By - Ay));

            // variantai testavimui:
            // a) A(0,0) B(1,1)
            // a) A(1,1) B(2,2)
            // a) A(5,3) B(5,4)
            // a) A(-5,1) B(1,2)

            Console.WriteLine("Tasko C koordinates yra x={0}, y={1}", Cx, Cy);
            Console.ReadKey();
            
        }
    }
}
