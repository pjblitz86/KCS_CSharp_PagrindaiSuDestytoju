using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.pasisveikinimas();
            programa.paklausti("Vardas?");
            string vardas = Console.ReadLine(); 
            programa.paklausti2();
            Console.ReadKey();
        }
        
        
        public void pasisveikinimas()
        {
            Console.WriteLine("Sveiki");
        }
        /// <summary>
        /// Funkcija kuri uzduoda klausima
        /// </summary>
        /// <param name="klausimas"></param>

        public void paklausti (string klausimas)
        {
            Console.WriteLine("Tuoj paklausiu");
        }
    
        public void paklausti2()
        {
            Console.WriteLine("Iveskite savo varda, amziu ir hobio pavadinima:");
            string vardas = Console.ReadLine();
            string amzius = Console.ReadLine();
            string hobis = Console.ReadLine();
            Console.WriteLine("Sveiki {0}. Jusu amzius {1} ir hobis {2}", vardas, amzius, hobis);
        }


        
    }
}
