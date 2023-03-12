using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc3
{
    internal class Vypocet
    {

        public static double Vypocitej(double cislo1, string operace, double cislo2)
        {
            switch (operace)
            {
                case "+":
                    return Secti(cislo1, cislo2);
                case "-":
                    return Odecti(cislo1, cislo2);
                case "*":
                    return Vynasob(cislo1, cislo2);
                case "/":
                    return Vydel(cislo1, cislo2);
                default:
                    return Math.Pow(cislo1, cislo2);
            }
        }

        public static double Secti(double cislo1, double cislo2)
        {
            return cislo1 + cislo2;
        }

        static double Odecti(double cislo1, double cislo2)
        {
            return cislo1 - cislo2;
        }

        static double Vynasob(double cislo1, double cislo2)
        {
            return cislo1 * cislo2;
        }

        static double Vydel(double cislo1, double cislo2)
        {
            return cislo1 / cislo2;
        }
    }
}
