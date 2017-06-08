using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 10 skaiciu: ");
            int[] skaiciai = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //int[] skaiciai = new int [10];
            /*for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }*/

            Program minMax = new Program();

            Console.WriteLine("Max: " + minMax.Didziausias(skaiciai));
            Console.WriteLine("Min: " + minMax.Maziausias(skaiciai));
            Console.WriteLine("Vidurkis: " + minMax.Vidurkis(skaiciai));
            Console.WriteLine("Kiek sk maziau uz nuli: " + minMax.kiekMaziauUzNuli(skaiciai));
            Console.ReadKey();
        }
        /// <summary>
        /// Paieskos funkcija didziausiai reiksmei is masyvo
        /// </summary>
        /// <param name="masyvas"></param>
        /// <returns></returns>
        private int Didziausias (int[] masyvas)
        {
            int MaxValue = int.MinValue;
            int MaxValueIndex = -1;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] >= MaxValue)
                {
                    MaxValue = masyvas[i];
                    MaxValueIndex = i;
                }
            }
            return MaxValue;
        }
        private int Maziausias(int[] masyvas)
        {
            int MinValue = int.MaxValue;
            int MinValueIndex = -1;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] < MinValue)
                {
                    MinValue = masyvas[i];
                    MinValueIndex = i;
                }
            }
            return MinValue;
        }
        // vidurkis
        private double Vidurkis(int[] masyvas)
        {
            int masyvoSuma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvoSuma+= masyvas[i];
            }

            double vidurkis = (double)masyvoSuma / masyvas.Length;
            return vidurkis;
        }
        // kiek skaiciu < 0
        private int kiekMaziauUzNuli(int[] masyvas)
        {
            int kiekMaziauUz0 = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] < 0)
                {
                    kiekMaziauUz0++;
                }
            }
            return kiekMaziauUz0;
        }
    }
}
