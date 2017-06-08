using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program skaiciavimai = new Program();
            skaiciavimai.paklausimas();
            double a = Convert.ToDouble(Console.ReadLine());
            char zenklas = Convert.ToChar(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double veiksmai = 0;

            while (zenklas != '=')
            {
                switch (zenklas)
                {
                    case '+':
                        veiksmai = skaiciavimai.sudetis(a, b);
                        Console.WriteLine("Suma:" + skaiciavimai.sudetis(a,b));
                        break;

                    case '-':
                        veiksmai = skaiciavimai.atimtis(a, b);
                        Console.WriteLine("Atimtis:" + skaiciavimai.atimtis(a, b));
                        break;

                    case '*':
                        veiksmai = skaiciavimai.daugyba(a, b);
                        Console.WriteLine("Sandauga:" + skaiciavimai.daugyba(a, b));
                        break;

                    case '/':

                        if (b != 0)
                        {
                            veiksmai = skaiciavimai.dalyba(a, b);
                            Console.WriteLine("Dalyba:" + skaiciavimai.dalyba(a, b));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Dalyba is nulio negalima");
                        }
                        break;

                    default:
                        Console.WriteLine("Ivestas neatpazintas zenklas");
                        break;
                }
                a = veiksmai;
                Console.WriteLine("Iveskite zenkla: ");
                zenklas = Convert.ToChar(Console.ReadLine());
                if (zenklas != '=')
                {
                    Console.WriteLine("Iveskite skaiciu: ");
                    b = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Paprasome ivesti skaiciu1, zenkla ir skaiciu2
        /// </summary>
        public void paklausimas()
        {
            Console.WriteLine("Iveskite skaiciu, zenkla ir skaiciu");
        }
        /// <summary>
        /// atliekame sudeti
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double sudetis(double a, double b)
        {
            return (double)a + b;
        }
        /// <summary>
        /// atimame
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double atimtis(double a, double b)
        {
            return (double)a - b;
        }

        public double daugyba(double a, double b)
        {
            return (double)a * b;
        }
        /// <summary>
        /// dalyba darome su double return
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double dalyba(double a, double b)
        {
            return a / b;
        }
    }
}
