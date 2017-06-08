using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormuleP1P2
{
    class Program
    {
        // y=P1+P2* ((Pos + D)/Comp+F)). Duoti du taskai A ir B zr salygos kintamuosius ir jei D=-1, tai F=-2


        static void Main(string[] args)
        {
            // Kintamieji duoti sąlygoj
            double Ay = 4;
            double APos = 100;
            double AComp = 150;

            double By = 0.5;
            double BPos = 20;
            double BComp = 15;

            double D = -1; // tinka abiem taskam
            double F = -2;// tinka abiem taskam

            double P1;
            double P2;

            // tieses formule y=kx+b; cia analogiskai P1 yra b, o k - P2. 
            // Issiskaiciuojam su A ir B tasku kintamaisias pagal lygciu sistema.

            // ISSISKAICIAVIMAS I LYGCIU SISTEMA

            // Ay = P1 + P2 * ((APos+D)/(AComp+F))
            // 4=P1+P2*((100-1)/(150-2);
            // P1 = 4-P2*(99/148)

            // By = P1 + P2 * ((BPos+D)/(BComp+F));
            // P1 = 0.5 - P2 * ((20-1)/(15-2));

            // SPRENDIMAS
            // P1 = Ay - P2 * ((APos + D) / (AComp + F));
            // P1 = By - P2 * ((BPos + D) / (BComp + F));
            // lygciu sistemoj sulyginam P1 ir issiskaiciuojam P2, tada rasim ir P1; 

            //Ay - P2 * ((APos + D) / (AComp + F)) = By - P2 * ((BPos + D) / (BComp + F));

            // isivedam papildomus kintamuosius pagal tieses formule y = kx + b
            double Ax = (APos + D) / (AComp + F);
            double Bx = (BPos + D) / (BComp + F);

            // tada formule tampa
            // Ay - P2*Ax = By - P2*Bx
            // P2*Bx-P2*Ax = By - Ay;
            // P2 = (By - Ay)/(Bx - Ax);

            P2 = (By - Ay) / (Bx - Ax);
            P1 = Ay - P2 * Ax;

            Console.WriteLine("ATSAKYMAS");
            Console.WriteLine("P1 = {0}, P2 = {1}", P1, P2);
            Console.ReadKey();

        }
    }
}
