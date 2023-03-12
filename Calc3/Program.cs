using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc3
{
    internal class Program
    {
        static double NactiCislo()
        {
            Console.WriteLine("Zadej číslo:");
            double cislo;
            while (!double.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Špatně zadané číslo. Zadej znovu číslo:");
            }
            return cislo;
        }

        static string NactiOperator()
        {
            string[] vsechnyOperace = { "+", "-", "*", "/", "^", "c", "q" };
            Console.WriteLine("Zvol jeden z operátorů: + - * / ^, c pro vynulování nebo q pro ukončení");
            string operace = Console.ReadLine();

            while (!vsechnyOperace.Contains(operace))
            {
                Console.WriteLine("Špatně zadaný operátor. Zvol: + - * / ^, c pro vynulování nebo q pro ukončení");
                operace = Console.ReadLine();
            }
            return operace;
        }

        static void Main(string[] args)
        {
            double cislo1 = 0;
            double cislo2 = 0;
            string operace = "";
            double vysledek = 0;
            string zadano = "";

            while (true)
            { 
                //Načtení prvního čísla
                cislo1 = NactiCislo();

                while(true)
                {
                    //Načtení operátoru
                    operace = NactiOperator();
 
                    if (operace == "c")
                    {
                        Console.WriteLine("Vynulováno");
                        break;
                    }

                    if (operace == "q")
                    {
                        return;
                    }

                    //Načtení dalšího čísla
                    cislo2 = NactiCislo();

                    // Výpočet a výpis výsledku
                    if (cislo2 == 0 && operace == "/")
                    {
                        Console.WriteLine("Dělení nulou není možné. Začni znovu.");
                        break;
                    }
                    else
                    {
                        vysledek = Vypocet.Vypocitej(cislo1, operace, cislo2);
                        zadano = cislo1.ToString() + " " + operace + " " + cislo2.ToString();
                        Console.WriteLine($"Výpočet: {zadano} = {vysledek}");
                        cislo1 = vysledek;
                    }
                }
            }
        }
    }
}
