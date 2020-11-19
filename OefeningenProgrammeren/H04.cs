using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OefeningenProgrammeren
{
    class H04
    {
        static public void Keuzemenu()
        {
            Console.WriteLine(@"Kies uit de volgende methodes door een cijfer in te geven
1 - BMIBerekenaar
2 - Pythagoras
3 - Cirkels
4 - Orakeltje");
            Console.WriteLine();
            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                BMIBerekenaar();
            }
            if (keuze == "2")
            {
                Pythagoras();
            }
            if (keuze == "3")
            {
                Cirkels();
            }
            if (keuze == "4")
            {
                Orakeltje();
            }
        }

        static public void BMIBerekenaar()
        {
            Console.WriteLine("Hoeveel weeg je in kg?");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoe groot ben je in m?");
            double grootte = Convert.ToDouble(Console.ReadLine());
            grootte = Math.Pow(grootte, 2);
            double bmi = (gewicht / grootte);
            Console.WriteLine($"Je BMI is {bmi:F2}");
        }

        static public void Pythagoras()
        {
            Console.WriteLine("Geef de lengte van de eerste rechthoekszijde");
            double eersteZijde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef de lengte van de tweede rechthoekszijde");
            double tweedeZijde = Convert.ToDouble(Console.ReadLine());
            eersteZijde = Math.Pow(eersteZijde, 2);
            tweedeZijde = Math.Pow(tweedeZijde, 2);
            double derdeZijde = eersteZijde + tweedeZijde;
            derdeZijde = Math.Sqrt(derdeZijde);
            Console.WriteLine($"De lengte van de schuine zijde is {derdeZijde}");
        }

        public static void Cirkels()
        {
            Console.WriteLine("Geef de straal");
            double straal = Convert.ToDouble(Console.ReadLine());
            const double PI = Math.PI;
            double omtrek = (2 * PI * straal);
            double oppervlakte = (Math.Pow(straal, 2) * PI);
            Console.WriteLine($"De omtrek van de cirkel met straal {straal:F2} is {omtrek:F2}");
            Console.WriteLine($"De oppervlakte van de cirkel met straal {straal:F2} is {oppervlakte:F2}");
        }
        static public void Orakeltje()
        {
            Console.WriteLine("Hoe oud ben je nu?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int yearsToLive = rnd.Next(100);
            int ageYouDie = leeftijd + yearsToLive;
            Console.WriteLine($"Je zal nog {yearsToLive} jaar leven. Je zal dus {ageYouDie} worden.");
        }
    }
}