using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Pasi = new Program();
            Pasi.pradeti();
            Pasi.Antras();
            Console.ReadKey();
        }

        public void pradeti()
        {
            Console.WriteLine("PROGRAMA PRADEJO DARBA");
        }
        public void Antras()
        {
            Console.WriteLine("Antras metodas");
            Suma(5, 6);
        }
        public void Suma(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        
    }
}
