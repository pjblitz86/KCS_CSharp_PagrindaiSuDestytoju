using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesDemo
{

    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
        public int Rida;

        public Automobilis(string marke, string modelis, int gamybosMetai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;
        }

        public double kilometruPerMetus()
        {
            int VisoMetu = 2017 - GamybosMetai + 1;
            double Ridapermetus = (double)Rida / VisoMetu;
            return Ridapermetus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marke?");
            string marke = Console.ReadLine();
            Console.WriteLine("Modelis?");
            string modelis = Console.ReadLine();
            Console.WriteLine("Gamybos metai?");
            int gamybosMetai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rida?");
            int rida = Convert.ToInt32(Console.ReadLine());

            Automobilis auto = new Automobilis(marke, modelis, gamybosMetai, rida);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                auto.Marke, auto.Modelis, auto.GamybosMetai, auto.Rida, auto.kilometruPerMetus());
            Console.ReadKey();
        }
    }
}
