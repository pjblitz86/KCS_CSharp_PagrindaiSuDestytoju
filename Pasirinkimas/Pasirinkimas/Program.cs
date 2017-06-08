using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasirinkimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite viena is siu:\n" +
                                "1 - limonadas\n" +
                                "2 - arbata\n" +
                                "3 - kakava\n" +
                                "4 - kava\n" +
                                "5 - nieko\n");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote kakava");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 5:
                    Console.WriteLine("Jus pasirinkote nieko");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas");
                    break;
            }
            Console.ReadKey();
        }
    }
}
